namespace BudgetManagement.Models
{
    public class PaymentMethod
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int ExpenseId { get; set; }
        public Expense Expense { get; set; }
    }
}
