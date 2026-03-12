using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class GeminiService
{
    private readonly HttpClient _http;

    private const string API_KEY = "YOUR_GEMINI_KEY";

    public GeminiService(HttpClient http)
    {
        _http = http;
    }

    public async Task<string> AnalyzeTravelCost(string data)
    {
        var body = new
        {
            contents = new[]
            {
                new
                {
                    parts = new[]
                    {
                        new { text = data}
                    }
                }
            }
        };

        var response = await _http.PostAsJsonAsync(
            $"https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent?key={API_KEY}",
            body
        );

        return await response.Content.ReadAsStringAsync();

    }
}