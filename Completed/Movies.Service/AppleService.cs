using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Movies.Service
{
    public class AppleService
    {
        public static Lazy<AppleService> Instance { get; } = new Lazy<AppleService>(() => new AppleService());

        private HttpClient _client;

        public AppleService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://itunes.apple.com");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<ApiResponse> GetMoviesAsync(string term)
        {
            var response = await _client.GetAsync($"/search?term={Uri.EscapeUriString(term)}&media=movie").ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return ApiResponse.FromJson(jsonResponse);
        }
    }
}
