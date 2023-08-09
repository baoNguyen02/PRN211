using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Account
    {
        public Account()
        {
            PaymentHistories = new HashSet<PaymentHistory>();
        }

        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Role { get; set; }

        public virtual ICollection<PaymentHistory> PaymentHistories { get; set; }
    }
}
