using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class FoodService
    {
        public FoodService()
        {
            Orders = new HashSet<Order>();
            PaymentHistories = new HashSet<PaymentHistory>();
        }

        public int Id { get; set; }
        public string ServiceName { get; set; } = null!;
        public int Price { get; set; }
        public string? Image { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PaymentHistory> PaymentHistories { get; set; }
    }
}
