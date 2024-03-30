using Microsoft.EntityFrameworkCore;

namespace BudgetManagement.Models
{
    public class PaymentVoucher
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        [Unicode]
        public string Url { get; set; }
        public int Order { get; set; }
        public DateTime DateCreate { get; set; }
        public int ExpenseId { get; set; }
        public Expense Expense { get; set; }

    }
}
