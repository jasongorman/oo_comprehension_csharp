namespace CodeComprehensionTest;

public class RestockLevel
{
    private readonly IWarehouse _warehouse;
    private readonly IAverageDailySales _averageDailySales;

    public RestockLevel(IWarehouse warehouse, IAverageDailySales averageDailySales)
    {
        _warehouse = warehouse;
        _averageDailySales = averageDailySales;
    }
    
    public int Calculate(int productId)
    {
        Product product = _warehouse.FetchProduct(productId);
        return (int) Math.Ceiling(_averageDailySales.ForProduct(product) * product.LeadTime);
    }
}