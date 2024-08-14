using KlxPiaoControls;

namespace MiniLogoMaker
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            KlxPiaoTrackBar.InteractionStyleClass interactionStyleClass1 = new KlxPiaoTrackBar.InteractionStyleClass();
            KlxPiaoAPI.Animation animation1 = new KlxPiaoAPI.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            RoundedButton.DisabledStyleClass disabledStyleClass1 = new RoundedButton.DisabledStyleClass();
            RoundedButton.InteractionStyleClass interactionStyleClass2 = new RoundedButton.InteractionStyleClass();
            KlxPiaoAPI.Animation animation2 = new KlxPiaoAPI.Animation();
            KlxPiaoAPI.Animation animation3 = new KlxPiaoAPI.Animation();
            RoundedButton.DisabledStyleClass disabledStyleClass2 = new RoundedButton.DisabledStyleClass();
            RoundedButton.InteractionStyleClass interactionStyleClass3 = new RoundedButton.InteractionStyleClass();
            KlxPiaoAPI.Animation animation4 = new KlxPiaoAPI.Animation();
            KlxPiaoTrackBar.InteractionStyleClass interactionStyleClass4 = new KlxPiaoTrackBar.InteractionStyleClass();
            KlxPiaoTrackBar.InteractionStyleClass interactionStyleClass5 = new KlxPiaoTrackBar.InteractionStyleClass();
            KlxPiaoAPI.Animation animation5 = new KlxPiaoAPI.Animation();
            RoundedButton.DisabledStyleClass disabledStyleClass3 = new RoundedButton.DisabledStyleClass();
            RoundedButton.InteractionStyleClass interactionStyleClass6 = new RoundedButton.InteractionStyleClass();
            KlxPiaoAPI.Animation animation6 = new KlxPiaoAPI.Animation();
            KlxPiaoAPI.Animation animation7 = new KlxPiaoAPI.Animation();
            RoundedButton.DisabledStyleClass disabledStyleClass4 = new RoundedButton.DisabledStyleClass();
            RoundedButton.InteractionStyleClass interactionStyleClass7 = new RoundedButton.InteractionStyleClass();
            KlxPiaoAPI.Animation animation8 = new KlxPiaoAPI.Animation();
            KlxPiaoAPI.Animation animation9 = new KlxPiaoAPI.Animation();
            RoundedButton.DisabledStyleClass disabledStyleClass5 = new RoundedButton.DisabledStyleClass();
            RoundedButton.InteractionStyleClass interactionStyleClass8 = new RoundedButton.InteractionStyleClass();
            KlxPiaoAPI.Animation animation10 = new KlxPiaoAPI.Animation();
            originalImageBox = new ImageBox();
            shadowImageBox = new ImageBox();
            label1 = new Label();
            shadowPointBar = new PointBar();
            zoomTrackBar = new KlxPiaoTrackBar();
            offsetPointBar = new PointBar();
            backColorPanel = new KlxPiaoPanel();
            label2 = new Label();
            label3 = new Label();
            shadowColorPanel = new KlxPiaoPanel();
            label4 = new Label();
            foreColorPanel = new KlxPiaoPanel();
            saveFileButton = new RoundedButton();
            saveClipboardButton = new RoundedButton();
            widthTrackBar = new KlxPiaoTrackBar();
            heightTrackBar = new KlxPiaoTrackBar();
            klxPiaoPanel1 = new KlxPiaoPanel();
            versionButton = new RoundedButton();
            label6 = new Label();
            klxPiaoPanel2 = new KlxPiaoPanel();
            githubButton = new RoundedButton();
            label5 = new Label();
            selectFileButton = new RoundedButton();
            statusLabel = new KlxPiaoLabel();
            klxPiaoPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // originalImageBox
            // 
            originalImageBox.BackColor = Color.FromArgb(30, 30, 30);
            originalImageBox.BaseBackColor = Color.FromArgb(30, 30, 30);
            originalImageBox.BorderColor = Color.Pink;
            originalImageBox.BorderCornerRadius = new KlxPiaoAPI.CornerRadius(36F, 36F, 36F, 36F);
            originalImageBox.BorderSize = 1;
            originalImageBox.EnableNewZoomMode = true;
            originalImageBox.IsEnableBorder = true;
            originalImageBox.Location = new Point(81, 80);
            originalImageBox.Name = "originalImageBox";
            originalImageBox.Size = new Size(256, 256);
            originalImageBox.TabIndex = 12;
            originalImageBox.TabStop = false;
            // 
            // shadowImageBox
            // 
            shadowImageBox.BackColor = Color.FromArgb(30, 30, 30);
            shadowImageBox.BaseBackColor = Color.FromArgb(30, 30, 30);
            shadowImageBox.BorderColor = Color.Pink;
            shadowImageBox.BorderCornerRadius = new KlxPiaoAPI.CornerRadius(36F, 36F, 36F, 36F);
            shadowImageBox.BorderSize = 1;
            shadowImageBox.EnableNewZoomMode = true;
            shadowImageBox.IsEnableBorder = true;
            shadowImageBox.Location = new Point(437, 80);
            shadowImageBox.Name = "shadowImageBox";
            shadowImageBox.Size = new Size(256, 256);
            shadowImageBox.TabIndex = 16;
            shadowImageBox.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.White;
            label1.Location = new Point(343, 178);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 17;
            label1.Text = "Convert To";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // shadowPointBar
            // 
            shadowPointBar.BackColor = Color.FromArgb(30, 30, 30);
            shadowPointBar.BaseBackColor = Color.FromArgb(30, 30, 30);
            shadowPointBar.BorderColor = Color.Pink;
            shadowPointBar.CoordinateDisplayFormat = "Shadow: {X}, {Y}";
            shadowPointBar.CoordinateTextAlign = ContentAlignment.BottomCenter;
            shadowPointBar.CoordinateTextOffset = new Point(0, -3);
            shadowPointBar.CornerRadius = new KlxPiaoAPI.CornerRadius(36F, 36F, 36F, 36F);
            shadowPointBar.CrosshairColor = Color.White;
            shadowPointBar.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            shadowPointBar.ForeColor = Color.White;
            shadowPointBar.Location = new Point(81, 358);
            shadowPointBar.MaxValue = new Point(300, 300);
            shadowPointBar.MinValue = new Point(-300, -300);
            shadowPointBar.MouseDownEventOption = KlxPiaoAPI.MouseValueChangedEventOption.OnNoEvent;
            shadowPointBar.MouseMoveEventOption = KlxPiaoAPI.MouseValueChangedEventOption.OnNoEvent;
            shadowPointBar.Name = "shadowPointBar";
            shadowPointBar.Size = new Size(109, 109);
            shadowPointBar.TabIndex = 21;
            shadowPointBar.Text = "label2";
            shadowPointBar.Value = new Point(100, 100);
            // 
            // zoomTrackBar
            // 
            zoomTrackBar.BackColor = Color.FromArgb(30, 30, 30);
            zoomTrackBar.BorderColor = Color.Pink;
            zoomTrackBar.BorderSize = 1;
            zoomTrackBar.CornerRadius = 10F;
            zoomTrackBar.ForeColor = Color.White;
            interactionStyleClass1.FocusBorderColor = null;
            interactionStyleClass1.FocusBorderSize = null;
            interactionStyleClass1.FocusTrackBackColor = null;
            interactionStyleClass1.FocusTrackForeColor = null;
            interactionStyleClass1.MouseOverBorderColor = null;
            interactionStyleClass1.MouseOverBorderSize = null;
            interactionStyleClass1.MouseOverTrackBackColor = null;
            interactionStyleClass1.MouseOverTrackForeColor = null;
            zoomTrackBar.InteractionStyle = interactionStyleClass1;
            zoomTrackBar.IsDrawValueText = true;
            zoomTrackBar.Location = new Point(437, 358);
            zoomTrackBar.MaxValue = 500F;
            zoomTrackBar.MouseDownEventOption = KlxPiaoAPI.MouseValueChangedEventOption.OnNoEvent;
            zoomTrackBar.MouseMoveEventOption = KlxPiaoAPI.MouseValueChangedEventOption.OnNoEvent;
            zoomTrackBar.Name = "zoomTrackBar";
            zoomTrackBar.Size = new Size(256, 40);
            zoomTrackBar.TabIndex = 25;
            zoomTrackBar.TrackBackColor = Color.FromArgb(60, 60, 60);
            zoomTrackBar.TrackForeColor = Color.FromArgb(30, 30, 30);
            zoomTrackBar.Value = 100F;
            zoomTrackBar.ValueTextDisplayFormat = "Zoom: {value}%";
            // 
            // offsetPointBar
            // 
            offsetPointBar.BackColor = Color.FromArgb(30, 30, 30);
            offsetPointBar.BaseBackColor = Color.FromArgb(30, 30, 30);
            offsetPointBar.BorderColor = Color.Pink;
            offsetPointBar.CoordinateDisplayFormat = "Offset: {X}, {Y}";
            offsetPointBar.CoordinateTextAlign = ContentAlignment.BottomCenter;
            offsetPointBar.CoordinateTextOffset = new Point(0, -3);
            offsetPointBar.CornerRadius = new KlxPiaoAPI.CornerRadius(36F, 36F, 36F, 36F);
            offsetPointBar.CrosshairColor = Color.White;
            offsetPointBar.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            offsetPointBar.ForeColor = Color.White;
            offsetPointBar.Location = new Point(228, 358);
            offsetPointBar.MouseDownEventOption = KlxPiaoAPI.MouseValueChangedEventOption.OnNoEvent;
            offsetPointBar.MouseMoveEventOption = KlxPiaoAPI.MouseValueChangedEventOption.OnNoEvent;
            offsetPointBar.Name = "offsetPointBar";
            offsetPointBar.Size = new Size(109, 109);
            offsetPointBar.TabIndex = 29;
            offsetPointBar.Text = "label2";
            // 
            // backColorPanel
            // 
            backColorPanel.BackColor = Color.FromArgb(231, 201, 224);
            backColorPanel.BaseBackColor = Color.FromArgb(30, 30, 30);
            backColorPanel.BorderColor = Color.Pink;
            backColorPanel.CornerRadius = new KlxPiaoAPI.CornerRadius(10F, 10F, 10F, 10F);
            backColorPanel.Cursor = Cursors.Hand;
            backColorPanel.IsEnableShadow = false;
            backColorPanel.Location = new Point(437, 416);
            backColorPanel.Name = "backColorPanel";
            backColorPanel.Size = new Size(45, 45);
            backColorPanel.TabIndex = 33;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.White;
            label2.Location = new Point(406, 460);
            label2.Name = "label2";
            label2.Size = new Size(109, 23);
            label2.TabIndex = 37;
            label2.Text = "BackColor";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.ForeColor = Color.White;
            label3.Location = new Point(620, 460);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 42;
            label3.Text = "ShadowColor";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // shadowColorPanel
            // 
            shadowColorPanel.BackColor = Color.FromArgb(213, 169, 199);
            shadowColorPanel.BaseBackColor = Color.FromArgb(30, 30, 30);
            shadowColorPanel.BorderColor = Color.Pink;
            shadowColorPanel.CornerRadius = new KlxPiaoAPI.CornerRadius(10F, 10F, 10F, 10F);
            shadowColorPanel.Cursor = Cursors.Hand;
            shadowColorPanel.IsEnableShadow = false;
            shadowColorPanel.Location = new Point(648, 416);
            shadowColorPanel.Name = "shadowColorPanel";
            shadowColorPanel.Size = new Size(45, 45);
            shadowColorPanel.TabIndex = 41;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.ForeColor = Color.White;
            label4.Location = new Point(437, 460);
            label4.Name = "label4";
            label4.Size = new Size(265, 23);
            label4.TabIndex = 39;
            label4.Text = "ForeColor";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // foreColorPanel
            // 
            foreColorPanel.BackColor = Color.White;
            foreColorPanel.BaseBackColor = Color.FromArgb(30, 30, 30);
            foreColorPanel.BorderColor = Color.Pink;
            foreColorPanel.CornerRadius = new KlxPiaoAPI.CornerRadius(10F, 10F, 10F, 10F);
            foreColorPanel.Cursor = Cursors.Hand;
            foreColorPanel.IsEnableShadow = false;
            foreColorPanel.Location = new Point(543, 416);
            foreColorPanel.Name = "foreColorPanel";
            foreColorPanel.Size = new Size(45, 45);
            foreColorPanel.TabIndex = 38;
            // 
            // saveFileButton
            // 
            saveFileButton.BackColor = Color.FromArgb(30, 30, 30);
            saveFileButton.BaseBackColor = Color.FromArgb(30, 30, 30);
            saveFileButton.BorderColor = Color.Pink;
            animation1.Easing = new PointF[]
    {
    (PointF)resources.GetObject("animation1.Easing"),
    (PointF)resources.GetObject("animation1.Easing1")
    };
            animation1.FPS = 30;
            animation1.Time = 150;
            saveFileButton.ColorAnimationConfig = animation1;
            disabledStyleClass1.BackColor = Color.Empty;
            disabledStyleClass1.BorderColor = Color.Empty;
            disabledStyleClass1.ForeColor = Color.Empty;
            saveFileButton.DisabledStyle = disabledStyleClass1;
            saveFileButton.ForeColor = Color.White;
            interactionStyleClass2.DownBackColor = Color.FromArgb(70, 0, 13);
            interactionStyleClass2.DownBorderColor = Color.Empty;
            interactionStyleClass2.DownForeColor = Color.Empty;
            interactionStyleClass2.DownSize = new Size(0, 0);
            interactionStyleClass2.OverBackColor = Color.FromArgb(100, 0, 17);
            interactionStyleClass2.OverBorderColor = Color.Empty;
            interactionStyleClass2.OverForeColor = Color.Empty;
            interactionStyleClass2.OverSize = new Size(0, 0);
            saveFileButton.InteractionStyle = interactionStyleClass2;
            saveFileButton.IsEnableAnimation = true;
            saveFileButton.Location = new Point(17, 166);
            saveFileButton.Name = "saveFileButton";
            saveFileButton.Size = new Size(206, 40);
            animation2.Easing = new PointF[]
    {
    (PointF)resources.GetObject("animation2.Easing"),
    (PointF)resources.GetObject("animation2.Easing1")
    };
            animation2.FPS = 100;
            animation2.Time = 300;
            saveFileButton.SizeAnimationConfig = animation2;
            saveFileButton.TabIndex = 46;
            saveFileButton.Text = "Save to File";
            // 
            // saveClipboardButton
            // 
            saveClipboardButton.BackColor = Color.FromArgb(30, 30, 30);
            saveClipboardButton.BaseBackColor = Color.FromArgb(30, 30, 30);
            saveClipboardButton.BorderColor = Color.Pink;
            animation3.Easing = new PointF[]
    {
    (PointF)resources.GetObject("animation3.Easing"),
    (PointF)resources.GetObject("animation3.Easing1")
    };
            animation3.FPS = 30;
            animation3.Time = 150;
            saveClipboardButton.ColorAnimationConfig = animation3;
            disabledStyleClass2.BackColor = Color.Empty;
            disabledStyleClass2.BorderColor = Color.Empty;
            disabledStyleClass2.ForeColor = Color.Empty;
            saveClipboardButton.DisabledStyle = disabledStyleClass2;
            saveClipboardButton.ForeColor = Color.White;
            interactionStyleClass3.DownBackColor = Color.FromArgb(70, 0, 13);
            interactionStyleClass3.DownBorderColor = Color.Empty;
            interactionStyleClass3.DownForeColor = Color.Empty;
            interactionStyleClass3.DownSize = new Size(0, 0);
            interactionStyleClass3.OverBackColor = Color.FromArgb(100, 0, 17);
            interactionStyleClass3.OverBorderColor = Color.Empty;
            interactionStyleClass3.OverForeColor = Color.Empty;
            interactionStyleClass3.OverSize = new Size(0, 0);
            saveClipboardButton.InteractionStyle = interactionStyleClass3;
            saveClipboardButton.IsEnableAnimation = true;
            saveClipboardButton.Location = new Point(17, 216);
            saveClipboardButton.Name = "saveClipboardButton";
            saveClipboardButton.Size = new Size(206, 40);
            animation4.Easing = new PointF[]
    {
    (PointF)resources.GetObject("animation4.Easing"),
    (PointF)resources.GetObject("animation4.Easing1")
    };
            animation4.FPS = 100;
            animation4.Time = 300;
            saveClipboardButton.SizeAnimationConfig = animation4;
            saveClipboardButton.TabIndex = 50;
            saveClipboardButton.Text = "Save to Clipboard";
            // 
            // widthTrackBar
            // 
            widthTrackBar.BackColor = Color.FromArgb(30, 30, 30);
            widthTrackBar.BorderColor = Color.Pink;
            widthTrackBar.BorderSize = 1;
            widthTrackBar.CornerRadius = 10F;
            widthTrackBar.ForeColor = Color.White;
            interactionStyleClass4.FocusBorderColor = null;
            interactionStyleClass4.FocusBorderSize = null;
            interactionStyleClass4.FocusTrackBackColor = null;
            interactionStyleClass4.FocusTrackForeColor = null;
            interactionStyleClass4.MouseOverBorderColor = null;
            interactionStyleClass4.MouseOverBorderSize = null;
            interactionStyleClass4.MouseOverTrackBackColor = null;
            interactionStyleClass4.MouseOverTrackForeColor = null;
            widthTrackBar.InteractionStyle = interactionStyleClass4;
            widthTrackBar.IsDrawValueText = true;
            widthTrackBar.Location = new Point(17, 60);
            widthTrackBar.MaxValue = 1024F;
            widthTrackBar.MouseDownEventOption = KlxPiaoAPI.MouseValueChangedEventOption.OnNoEvent;
            widthTrackBar.MouseMoveEventOption = KlxPiaoAPI.MouseValueChangedEventOption.OnNoEvent;
            widthTrackBar.Name = "widthTrackBar";
            widthTrackBar.Size = new Size(95, 40);
            widthTrackBar.TabIndex = 54;
            widthTrackBar.TrackBackColor = Color.FromArgb(60, 60, 60);
            widthTrackBar.TrackForeColor = Color.FromArgb(30, 30, 30);
            widthTrackBar.Value = 256F;
            widthTrackBar.ValueTextDisplayFormat = "Width: {value}";
            // 
            // heightTrackBar
            // 
            heightTrackBar.BackColor = Color.FromArgb(30, 30, 30);
            heightTrackBar.BorderColor = Color.Pink;
            heightTrackBar.BorderSize = 1;
            heightTrackBar.CornerRadius = 10F;
            heightTrackBar.ForeColor = Color.White;
            interactionStyleClass5.FocusBorderColor = null;
            interactionStyleClass5.FocusBorderSize = null;
            interactionStyleClass5.FocusTrackBackColor = null;
            interactionStyleClass5.FocusTrackForeColor = null;
            interactionStyleClass5.MouseOverBorderColor = null;
            interactionStyleClass5.MouseOverBorderSize = null;
            interactionStyleClass5.MouseOverTrackBackColor = null;
            interactionStyleClass5.MouseOverTrackForeColor = null;
            heightTrackBar.InteractionStyle = interactionStyleClass5;
            heightTrackBar.IsDrawValueText = true;
            heightTrackBar.Location = new Point(128, 60);
            heightTrackBar.MaxValue = 1024F;
            heightTrackBar.MouseDownEventOption = KlxPiaoAPI.MouseValueChangedEventOption.OnNoEvent;
            heightTrackBar.MouseMoveEventOption = KlxPiaoAPI.MouseValueChangedEventOption.OnNoEvent;
            heightTrackBar.Name = "heightTrackBar";
            heightTrackBar.Size = new Size(95, 40);
            heightTrackBar.TabIndex = 55;
            heightTrackBar.TrackBackColor = Color.FromArgb(60, 60, 60);
            heightTrackBar.TrackForeColor = Color.FromArgb(30, 30, 30);
            heightTrackBar.Value = 256F;
            heightTrackBar.ValueTextDisplayFormat = "Height: {value}";
            // 
            // klxPiaoPanel1
            // 
            klxPiaoPanel1.BackColor = Color.FromArgb(30, 30, 30);
            klxPiaoPanel1.BaseBackColor = Color.FromArgb(30, 30, 30);
            klxPiaoPanel1.BorderColor = Color.Pink;
            klxPiaoPanel1.Controls.Add(versionButton);
            klxPiaoPanel1.Controls.Add(label6);
            klxPiaoPanel1.Controls.Add(klxPiaoPanel2);
            klxPiaoPanel1.Controls.Add(heightTrackBar);
            klxPiaoPanel1.Controls.Add(githubButton);
            klxPiaoPanel1.Controls.Add(label5);
            klxPiaoPanel1.Controls.Add(widthTrackBar);
            klxPiaoPanel1.Controls.Add(saveFileButton);
            klxPiaoPanel1.Controls.Add(saveClipboardButton);
            klxPiaoPanel1.CornerRadius = new KlxPiaoAPI.CornerRadius(36F, 36F, 36F, 36F);
            klxPiaoPanel1.Cursor = Cursors.Hand;
            klxPiaoPanel1.IsEnableShadow = false;
            klxPiaoPanel1.Location = new Point(735, 80);
            klxPiaoPanel1.Name = "klxPiaoPanel1";
            klxPiaoPanel1.Size = new Size(240, 397);
            klxPiaoPanel1.TabIndex = 42;
            // 
            // versionButton
            // 
            versionButton.BackColor = Color.FromArgb(30, 30, 30);
            versionButton.BaseBackColor = Color.FromArgb(30, 30, 30);
            versionButton.BorderColor = Color.Pink;
            animation5.Easing = new PointF[]
    {
    (PointF)resources.GetObject("animation5.Easing"),
    (PointF)resources.GetObject("animation5.Easing1")
    };
            animation5.FPS = 30;
            animation5.Time = 150;
            versionButton.ColorAnimationConfig = animation5;
            disabledStyleClass3.BackColor = Color.Empty;
            disabledStyleClass3.BorderColor = Color.White;
            disabledStyleClass3.ForeColor = Color.Empty;
            versionButton.DisabledStyle = disabledStyleClass3;
            versionButton.Enabled = false;
            versionButton.ForeColor = Color.White;
            interactionStyleClass6.DownBackColor = Color.FromArgb(70, 0, 13);
            interactionStyleClass6.DownBorderColor = Color.Empty;
            interactionStyleClass6.DownForeColor = Color.Empty;
            interactionStyleClass6.DownSize = new Size(0, 0);
            interactionStyleClass6.OverBackColor = Color.FromArgb(100, 0, 17);
            interactionStyleClass6.OverBorderColor = Color.Empty;
            interactionStyleClass6.OverForeColor = Color.Empty;
            interactionStyleClass6.OverSize = new Size(0, 0);
            versionButton.InteractionStyle = interactionStyleClass6;
            versionButton.IsEnableAnimation = true;
            versionButton.Location = new Point(128, 336);
            versionButton.Name = "versionButton";
            versionButton.Size = new Size(95, 40);
            animation6.Easing = new PointF[]
    {
    (PointF)resources.GetObject("animation6.Easing"),
    (PointF)resources.GetObject("animation6.Easing1")
    };
            animation6.FPS = 100;
            animation6.Time = 300;
            versionButton.SizeAnimationConfig = animation6;
            versionButton.TabIndex = 57;
            versionButton.Text = "Version: 0.0.0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Text Semibold", 14F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(17, 295);
            label6.Name = "label6";
            label6.Size = new Size(65, 26);
            label6.TabIndex = 56;
            label6.Text = "About";
            // 
            // klxPiaoPanel2
            // 
            klxPiaoPanel2.BackColor = Color.FromArgb(30, 30, 30);
            klxPiaoPanel2.BaseBackColor = Color.FromArgb(30, 30, 30);
            klxPiaoPanel2.BorderColor = Color.Pink;
            klxPiaoPanel2.CornerRadius = new KlxPiaoAPI.CornerRadius(10F, 10F, 10F, 10F);
            klxPiaoPanel2.Cursor = Cursors.Hand;
            klxPiaoPanel2.IsEnableShadow = false;
            klxPiaoPanel2.Location = new Point(17, 277);
            klxPiaoPanel2.Name = "klxPiaoPanel2";
            klxPiaoPanel2.Size = new Size(206, 1);
            klxPiaoPanel2.TabIndex = 34;
            // 
            // githubButton
            // 
            githubButton.BackColor = Color.FromArgb(30, 30, 30);
            githubButton.BaseBackColor = Color.FromArgb(30, 30, 30);
            githubButton.BorderColor = Color.Pink;
            animation7.Easing = new PointF[]
    {
    (PointF)resources.GetObject("animation7.Easing"),
    (PointF)resources.GetObject("animation7.Easing1")
    };
            animation7.FPS = 30;
            animation7.Time = 150;
            githubButton.ColorAnimationConfig = animation7;
            disabledStyleClass4.BackColor = Color.Empty;
            disabledStyleClass4.BorderColor = Color.Empty;
            disabledStyleClass4.ForeColor = Color.Empty;
            githubButton.DisabledStyle = disabledStyleClass4;
            githubButton.ForeColor = Color.White;
            githubButton.Image = Properties.Resources.github_light_128x128;
            githubButton.ImageAlign = ContentAlignment.MiddleLeft;
            githubButton.ImageOffset = new Point(10, 0);
            githubButton.ImageResizing = new SizeF(0.6F, 0.6F);
            githubButton.ImageResizingFormat = KlxPiaoAPI.ResizeMode.Percentage;
            interactionStyleClass7.DownBackColor = Color.FromArgb(70, 0, 13);
            interactionStyleClass7.DownBorderColor = Color.Empty;
            interactionStyleClass7.DownForeColor = Color.Empty;
            interactionStyleClass7.DownSize = new Size(0, 0);
            interactionStyleClass7.OverBackColor = Color.FromArgb(100, 0, 17);
            interactionStyleClass7.OverBorderColor = Color.Empty;
            interactionStyleClass7.OverForeColor = Color.Empty;
            interactionStyleClass7.OverSize = new Size(0, 0);
            githubButton.InteractionStyle = interactionStyleClass7;
            githubButton.IsEnableAnimation = true;
            githubButton.Location = new Point(17, 336);
            githubButton.Name = "githubButton";
            githubButton.Size = new Size(95, 40);
            animation8.Easing = new PointF[]
    {
    (PointF)resources.GetObject("animation8.Easing"),
    (PointF)resources.GetObject("animation8.Easing1")
    };
            animation8.FPS = 100;
            animation8.Time = 300;
            githubButton.SizeAnimationConfig = animation8;
            githubButton.TabIndex = 56;
            githubButton.Text = "Github";
            githubButton.TextAlign = ContentAlignment.MiddleRight;
            githubButton.TextOffset = new Point(-10, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Text Semibold", 14F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 18);
            label5.Name = "label5";
            label5.Size = new Size(73, 26);
            label5.TabIndex = 0;
            label5.Text = "Output";
            // 
            // selectFileButton
            // 
            selectFileButton.BackColor = Color.FromArgb(30, 30, 30);
            selectFileButton.BaseBackColor = Color.FromArgb(30, 30, 30);
            selectFileButton.BorderColor = Color.FromArgb(180, 201, 252);
            animation9.Easing = new PointF[]
    {
    (PointF)resources.GetObject("animation9.Easing"),
    (PointF)resources.GetObject("animation9.Easing1")
    };
            animation9.FPS = 30;
            animation9.Time = 150;
            selectFileButton.ColorAnimationConfig = animation9;
            disabledStyleClass5.BackColor = Color.Empty;
            disabledStyleClass5.BorderColor = Color.Empty;
            disabledStyleClass5.ForeColor = Color.Empty;
            selectFileButton.DisabledStyle = disabledStyleClass5;
            selectFileButton.ForeColor = Color.White;
            selectFileButton.ImageAlign = ContentAlignment.MiddleLeft;
            selectFileButton.ImageResizing = new SizeF(0.75F, 0.75F);
            selectFileButton.ImageResizingFormat = KlxPiaoAPI.ResizeMode.Percentage;
            interactionStyleClass8.DownBackColor = Color.FromArgb(2, 27, 85);
            interactionStyleClass8.DownBorderColor = Color.Empty;
            interactionStyleClass8.DownForeColor = Color.Empty;
            interactionStyleClass8.DownSize = new Size(0, 0);
            interactionStyleClass8.OverBackColor = Color.FromArgb(4, 37, 117);
            interactionStyleClass8.OverBorderColor = Color.Empty;
            interactionStyleClass8.OverForeColor = Color.Empty;
            interactionStyleClass8.OverSize = new Size(0, 0);
            selectFileButton.InteractionStyle = interactionStyleClass8;
            selectFileButton.IsEnableAnimation = true;
            selectFileButton.Location = new Point(169, 11);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(100, 33);
            animation10.Easing = new PointF[]
    {
    (PointF)resources.GetObject("animation10.Easing"),
    (PointF)resources.GetObject("animation10.Easing1")
    };
            animation10.FPS = 100;
            animation10.Time = 300;
            selectFileButton.SizeAnimationConfig = animation10;
            selectFileButton.TabIndex = 60;
            selectFileButton.Text = "Select File";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = false;
            statusLabel.BackColor = Color.FromArgb(30, 30, 30);
            statusLabel.BorderColor = Color.FromArgb(199, 199, 199);
            statusLabel.BorderSize = 1;
            statusLabel.CornerRadius = new KlxPiaoAPI.CornerRadius(24F, 24F, 24F, 24F);
            statusLabel.DrawTextOffset = new Point(10, 0);
            statusLabel.Enabled = false;
            statusLabel.ForeColor = Color.White;
            statusLabel.Location = new Point(278, 11);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(153, 33);
            statusLabel.TabIndex = 68;
            statusLabel.Text = "Status: Idle.";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1056, 556);
            Controls.Add(foreColorPanel);
            Controls.Add(shadowColorPanel);
            Controls.Add(backColorPanel);
            Controls.Add(statusLabel);
            Controls.Add(selectFileButton);
            Controls.Add(klxPiaoPanel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(offsetPointBar);
            Controls.Add(zoomTrackBar);
            Controls.Add(shadowPointBar);
            Controls.Add(label1);
            Controls.Add(originalImageBox);
            Controls.Add(shadowImageBox);
            Controls.Add(label4);
            EnableResizeButton = false;
            ForeColor = Color.White;
            IconDrawOffset = new Point(13, 11);
            InteractionColorScale = 0.5F;
            Name = "MainWindow";
            Resizable = false;
            Text = "MiniLogoMaker";
            TitleBoxBackColor = Color.FromArgb(30, 30, 30);
            TitleBoxDragThreshold = 60;
            TitleBoxForeColor = Color.White;
            TitleButtonDisabledColor = Color.DimGray;
            TitleButtonWidth = 46;
            TitleFont = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            TitleTextOffset = new Point(25, 11);
            klxPiaoPanel1.ResumeLayout(false);
            klxPiaoPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private KlxPiaoControls.ImageBox originalImageBox;
        private KlxPiaoControls.ImageBox shadowImageBox;
        private Label label1;
        private KlxPiaoControls.PointBar shadowPointBar;
        private KlxPiaoControls.KlxPiaoTrackBar zoomTrackBar;
        private KlxPiaoControls.PointBar offsetPointBar;
        private KlxPiaoControls.KlxPiaoPanel backColorPanel;
        private Label label2;
        private Label label3;
        private KlxPiaoControls.KlxPiaoPanel shadowColorPanel;
        private Label label4;
        private KlxPiaoControls.KlxPiaoPanel foreColorPanel;
        private RoundedButton saveFileButton;
        private RoundedButton saveClipboardButton;
        private KlxPiaoTrackBar widthTrackBar;
        private KlxPiaoTrackBar heightTrackBar;
        private KlxPiaoPanel klxPiaoPanel1;
        private Label label5;
        private RoundedButton githubButton;
        private RoundedButton selectFileButton;
        private KlxPiaoControls.KlxPiaoLabel statusLabel;
        private Label label6;
        private KlxPiaoPanel klxPiaoPanel2;
        private RoundedButton versionButton;
    }
}
