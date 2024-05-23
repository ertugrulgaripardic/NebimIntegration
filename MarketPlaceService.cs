using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class MarketPlaceService
{
    private readonly HttpClient _httpClient;

    public MarketPlaceService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task SendProductAsync(Product product)
    {
        // Pazaryeri API'sine ürün gönderme
        var response = await _httpClient.PostAsJsonAsync("https://marketplaceapiendpoint.com/products", product);
        response.EnsureSuccessStatusCode();
    }
}
