using System;
using System.Collections.Generic;

namespace Metro
{
    public partial class User
    {
        public User()
        {
            Letters = new HashSet<Letter>();
            Tickets = new HashSet<Ticket>();
        }

        public int Id { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Firtsname { get; set; } = null!;
        public string? Lastname { get; set; }
        public int? IdCoupon { get; set; }

        public virtual Coupon? IdCouponNavigation { get; set; }
        public virtual ICollection<Letter> Letters { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
