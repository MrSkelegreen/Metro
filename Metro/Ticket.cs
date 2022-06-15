using System;
using System.Collections.Generic;

namespace Metro
{
    public partial class Ticket
    {
        public int Idticket { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public int Iduser { get; set; }

        public virtual User IduserNavigation { get; set; } = null!;
    }
}
