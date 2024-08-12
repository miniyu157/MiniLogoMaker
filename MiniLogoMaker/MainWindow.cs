using KlxPiaoAPI;
using KlxPiaoControls;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace MiniLogoMaker
{
    public partial class MainWindow : KlxPiaoForm
    {
        private const string githubLink = "https://github.com/miniyu157/MiniLogoMaker";
        private Image? Image { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            versionShowLabel.Text = $"Version: {GetProductVersion()}";

            selectFileButton.Click += SelectFileButton_Click;
            saveFileButton.Click += SaveFileButton_Click;
            saveClipboardButton.Click += SaveClipboardButton_Click;
            githubButton.Click += GithubButton_Click;

            zoomTrackBar.ValueChanged += (sender, e) => RefreshDraw();
            shadowPointBar.ValueChanged += (sender, e) => RefreshDraw();
            offsetPointBar.ValueChanged += (sender, e) => RefreshDraw();
            widthTrackBar.ValueChanged += (sender, e) => RefreshDraw();
            heightTrackBar.ValueChanged += (sender, e) => RefreshDraw();

            shadowPointBar.ValueChanged -= (sender, e) => RefreshDraw();
            offsetPointBar.ValueChanged -= (sender, e) => RefreshDraw();

            AttachColorPanelevents(backColorPanel);
            AttachColorPanelevents(foreColorPanel);
            AttachColorPanelevents(shadowColorPanel);

            void AttachColorPanelevents(KlxPiaoPanel klxPiaoPanel)
            {
                klxPiaoPanel.Click += (sender, e) =>
                {
                    ColorDialog colorDialog = new()
                    {
                        Color = klxPiaoPanel.BackColor,
                        FullOpen = true
                    };
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        klxPiaoPanel.BackColor = colorDialog.Color;
                        RefreshDraw();
                    }
                };
            }
        }

        private void GithubButton_Click(object? sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo() { FileName = githubLink, UseShellExecute = true });
        }

        private void SaveClipboardButton_Click(object? sender, EventArgs e)
        {
            using Image? image = shadowImageBox.Image;
            if (image != null)
            {
                Clipboard.SetImage(image);
            }
        }

        private void SaveFileButton_Click(object? sender, EventArgs e)
        {
            using Image? saveImage = shadowImageBox.Image;
            if (saveImage != null)
            {
                SaveFileDialog saveFileDialog = new()
                {
                    Filter = "PNG|*.png"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    saveImage.Save(saveFileDialog.FileName);
                }
            }
        }

        private void SelectFileButton_Click(object? sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                Filter = "Image File|*.png;*.jpg;*.bmp"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image = Image.FromFile(ofd.FileName);
                RefreshDraw();
            }
        }

        public static string? GetProductVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            AssemblyInformationalVersionAttribute? productVersion =
                (AssemblyInformationalVersionAttribute?)Attribute.GetCustomAttribute(assembly, typeof(AssemblyInformationalVersionAttribute));

            if (productVersion?.InformationalVersion is string versionStr)
            {
                var plusSymbolIndex = versionStr.IndexOf('+');
                if (plusSymbolIndex != -1)
                {
                    versionStr = versionStr[..plusSymbolIndex];
                }

                return versionStr;
            }

            return "Unknown Version";
        }

        private async void RefreshDraw()
        {
            if (Image != null)
            {
                statusLabel.Text = "Status: Generating...";
                using Bitmap image = (Bitmap)Image.Clone();

                originalImageBox.Image = image.CreateTransparentBackground(10);
                shadowImageBox.Image = await MakerLogoAsync(
                    image,                                                          // Original Image
                    new Size((int)widthTrackBar.Value, (int)heightTrackBar.Value),  // Base Size
                    backColorPanel.BackColor,                                       // Background Color
                    foreColorPanel.BackColor,                                       // Foreground Color
                    shadowColorPanel.BackColor,                                     // Shadow Color
                    shadowPointBar.Value,                                           // Shadow Position
                    offsetPointBar.Value,                                           // Drawing Offset
                    new SizeF(zoomTrackBar.Value / 100, zoomTrackBar.Value / 100),  // Resize
                    ResizeMode.Percentage);                                         // Resize Mode
                statusLabel.Text = "Status: Finish.";
            }
        }

        private static async Task<Bitmap> MakerLogoAsync(Bitmap originalImage, Size baseSize, Color backColor, Color foreColor, Color shadowColor, Point shadowPosition, Point drawingOffset, SizeF imageResize, ResizeMode resizeMode = ResizeMode.Pixel)
        {
            return await Task.Run(() => MakerLogo(originalImage, baseSize, backColor, foreColor, shadowColor, shadowPosition, drawingOffset, imageResize, resizeMode));
        }

        private static Bitmap MakerLogo(Bitmap originalImage,
                                    Size baseSize,
                                    Color backColor,
                                    Color foreColor,
                                    Color shadowColor,
                                    Point shadowPosition,
                                    Point drawingOffset,
                                    SizeF imageResize,
                                    ResizeMode resizeMode = ResizeMode.Pixel)
        {
            Bitmap baseBitmap = new(baseSize.Width, baseSize.Height);

            using (Graphics g = Graphics.FromImage(baseBitmap))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                Size drawSize = resizeMode switch
                {
                    ResizeMode.Pixel => new Size(originalImage.Width, originalImage.Height),
                    ResizeMode.Percentage => new Size((int)(originalImage.Width * imageResize.Width), (int)(originalImage.Height * imageResize.Height)),
                    _ => throw new Exception("ResizeMode Error.")
                };

                if (drawSize.Width == 0 || drawSize.Height == 0)
                {
                    g.Clear(backColor);
                    return baseBitmap;
                }

                Point drawPos = new(
                    (baseSize.Width - drawSize.Width) / 2 + drawingOffset.X,
                    (baseSize.Height - drawSize.Height) / 2 + drawingOffset.Y);

                g.Clear(backColor);

                using Image foreImage = originalImage.ResetImage(drawSize).ReplaceNonFullyTransparentPixels(foreColor);
                using Image shadowImage = originalImage.ResetImage(drawSize).ReplaceNonFullyTransparentPixels(shadowColor);

                for (int x = 0; x != shadowPosition.X; x += shadowPosition.X > 0 ? 1 : -1)
                {
                    float slope = shadowPosition.Y / (float)shadowPosition.X;
                    g.DrawImage(shadowImage, drawPos.X + x, drawPos.Y + x * slope);
                }

                for (int y = 0; y != shadowPosition.Y; y += shadowPosition.Y > 0 ? 1 : -1)
                {
                    float slope = shadowPosition.X / (float)shadowPosition.Y;
                    g.DrawImage(shadowImage, drawPos.X + y * slope, drawPos.Y + y);
                }

                g.DrawImage(foreImage, drawPos);
            }

            return baseBitmap;
        }
    }
}