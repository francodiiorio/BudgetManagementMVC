using System.ComponentModel.DataAnnotations;

namespace BudgetManagement.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public List<PaymentMethod> PaymentMethods { get; set; }
        public List<PaymentVoucher> PaymentVouchers { get; set; }
    }
}
