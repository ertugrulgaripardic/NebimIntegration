using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

public class NebimService
{
    private readonly HttpClient _httpClient;

    public NebimService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Product>> GetProductsAsync()
    {
        // Nebim ERP API endpoint and credentials
        var response = await _httpClient.GetAsync("cd C:\Users\zerri\NebimIntegration");
        response.EnsureSuccessStatusCode();
        var products = await response.Content.ReadFromJsonAsync<List<Product>>();
        return products;
    }
}
