using CodeComprehensionTest;

var restockLevel = new RestockLevel(
    new StubWarehouse(new Product {Id = 811, LeadTime = 14}),
    new ThirtyDaySalesAverage(new StubSalesHistory(45))
);

Console.WriteLine(restockLevel.Calculate(811));

// What will the program output?

public class StubWarehouse : IWarehouse
{
    private readonly Product _product;

    public StubWarehouse(Product product)
    {
        _product = product;
    }

    public Product FetchProduct(int productId)
    {
        return _product;
    }
}

public class StubSalesHistory : ISalesHistory
{
    private readonly int _sales;

    public StubSalesHistory(int sales)
    {
        _sales = sales;
    }

    public int WithinDateRange(int productId, DateTime startDate, DateTime endDate)
    {
        return _sales;
    }
}