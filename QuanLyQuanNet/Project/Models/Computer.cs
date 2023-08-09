using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Computer
    {
        public Computer()
        {
            Orders = new HashSet<Order>();
            PaymentHistories = new HashSet<PaymentHistory>();
        }

        public int Id { get; set; }
        public string ComputerName { get; set; } = null!;
        public string Status { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PaymentHistory> PaymentHistories { get; set; }
    }
}
