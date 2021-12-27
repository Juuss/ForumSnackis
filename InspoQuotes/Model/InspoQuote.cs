using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InspoQuotes.Model
{
    public class InspoQuote
    {
        public long Id { get; set; }
        public string Quote { get; set; }
        public string Author { get; set; }
    }
}
