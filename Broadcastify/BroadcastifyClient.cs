using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ScannerSuite.Broadcastify;

public class BroadcastifyClient
{
    private const string BaseUrl = "https://www.broadcastify.com";
    private static readonly string BrowsePageUrl = $"{BaseUrl}/listen";
    private static readonly string BrowsePageUrlWithCountry = $"{BrowsePageUrl}/coid/";
    
    private readonly HttpClient _httpClient;
    
    public BroadcastifyClient()
    {
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("User-Agent", 
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");
    }
    
    private async Task<string> GetHtmlAsync(string url)
    {
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Request error: {ex.Message}");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
            return null;
        }
    }
    
}