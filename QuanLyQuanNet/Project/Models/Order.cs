using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int ComputerId { get; set; }
        public int ServiceId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }

        public virtual Computer Computer { get; set; } = null!;
        public virtual FoodService Service { get; set; } = null!;
    }
}
