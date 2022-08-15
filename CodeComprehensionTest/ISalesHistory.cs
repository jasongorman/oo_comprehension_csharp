namespace CodeComprehensionTest;

public interface ISalesHistory
{
    int WithinDateRange(int productId, DateTime startDate, DateTime endDate);
}