using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class PaymentHistory
    {
        public int Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public int AccountId { get; set; }
        public int ComputerId { get; set; }
        public int ServiceId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Computer Computer { get; set; } = null!;
        public virtual FoodService Service { get; set; } = null!;
    }
}
