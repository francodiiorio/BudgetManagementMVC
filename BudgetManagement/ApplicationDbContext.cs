﻿using BudgetManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace BudgetManagement
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<PaymentVoucher> PaymentVouchers { get; set;}
    }
}
