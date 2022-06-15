using System;
using System.Collections.Generic;

namespace Metro
{
    public partial class Pay
    {
        public int Idpay { get; set; }
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }
        public bool PayType { get; set; }
        public int Idcoupon { get; set; }

        public virtual Coupon IdcouponNavigation { get; set; } = null!;
    }
}
