using System.Collections.Generic;
using System.Threading.Tasks;

public class ProductSyncService
{
    private readonly NebimService _nebimService;
    private readonly MarketPlaceService _marketPlaceService;

    public ProductSyncService(NebimService nebimService, MarketPlaceService marketPlaceService)
    {
        _nebimService = nebimService;
        _marketPlaceService = marketPlaceService;
    }

    public async Task SyncProductsAsync()
    {
        var products = await _nebimService.GetProductsAsync();
        foreach (var product in products)
        {
            await _marketPlaceService.SendProductAsync(product);
        }
    }
}
