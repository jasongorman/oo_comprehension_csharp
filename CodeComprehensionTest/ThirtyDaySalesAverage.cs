namespace CodeComprehensionTest;

public class ThirtyDaySalesAverage : IAverageDailySales
{
    private readonly ISalesHistory _salesHistory;

    public ThirtyDaySalesAverage(ISalesHistory salesHistory)
    {
        _salesHistory = salesHistory;
    }

    public double ForProduct(Product product)
    {
        DateTime endDate = DateTime.Now;
        DateTime startDate = endDate.AddDays(-30);
        return _salesHistory.WithinDateRange(product.Id, startDate, endDate)/ 30.0;
    }
}