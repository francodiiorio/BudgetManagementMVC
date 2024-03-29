namespace BudgetManagement.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
    }
}
