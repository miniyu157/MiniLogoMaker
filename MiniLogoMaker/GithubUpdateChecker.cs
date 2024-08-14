using System.Text.Json;

namespace MiniLogoMaker
{
    public class GithubUpdateChecker
    {
        public GithubUpdateChecker() { }

        public GithubUpdateChecker(string url)
        {
            Url = url;
        }

        private string? Url { get; set; }
        private string? OriginalJson { get; set; }

        public async Task DownloadContentAsync()
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; MiniLogoMakerApp)");

            HttpResponseMessage response = await client.GetAsync(Url);
            response.EnsureSuccessStatusCode();

            string content = await response.Content.ReadAsStringAsync();
            OriginalJson = content;
        }

        public void GetUpdateData(out string? latestVersion, out string? updateContent, out string? downloadUrl)
        {
            if (string.IsNullOrEmpty(OriginalJson))
            {
                throw new InvalidOperationException("No JSON content available. Please call DownloadContentAsync first.");
            }

            using JsonDocument document = JsonDocument.Parse(OriginalJson);
            JsonElement root = document.RootElement;

            latestVersion = root.GetProperty("tag_name").GetString()?.TrimStart('v');
            updateContent = root.GetProperty("body").GetString();
            downloadUrl = root.GetProperty("assets")[0].GetProperty("browser_download_url").GetString();
        }
    }
}