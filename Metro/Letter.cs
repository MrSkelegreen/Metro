using System;
using System.Collections.Generic;

namespace Metro
{
    public partial class Letter
    {
        public int Idletter { get; set; }
        public int Iduser { get; set; }
        public bool LetterType { get; set; }
        public string Text { get; set; } = null!;

        public virtual User IduserNavigation { get; set; } = null!;
        public virtual LetterType LetterTypeNavigation { get; set; } = null!;
    }
}
