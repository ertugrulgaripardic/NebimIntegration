using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        var httpClient = new HttpClient();
        var nebimService = new NebimService(httpClient);
        var marketPlaceService = new MarketPlaceService(httpClient);

        var productSyncService = new ProductSyncService(nebimService, marketPlaceService);
        await productSyncService.SyncProductsAsync();
    }
}
