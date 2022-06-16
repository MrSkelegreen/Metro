using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro
{
    internal class Context
    {
        public static MetroContext db = new MetroContext();
        public static User userSession;       
    }
}
