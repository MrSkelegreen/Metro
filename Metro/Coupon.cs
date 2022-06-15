using System;
using System.Collections.Generic;

namespace Metro
{
    public partial class Coupon
    {
        public Coupon()
        {
            Pays = new HashSet<Pay>();
            Users = new HashSet<User>();
        }

        public int Idcoupon { get; set; }
        public decimal? Balance { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<Pay> Pays { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
