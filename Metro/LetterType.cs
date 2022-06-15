using System;
using System.Collections.Generic;

namespace Metro
{
    public partial class LetterType
    {
        public LetterType()
        {
            Letters = new HashSet<Letter>();
        }

        public bool IdletterType { get; set; }
        public string? Type { get; set; }

        public virtual ICollection<Letter> Letters { get; set; }
    }
}
