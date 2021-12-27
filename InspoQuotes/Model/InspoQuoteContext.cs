using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InspoQuotes.Model
{
    public class InspoQuoteContext : DbContext
    {
        public InspoQuoteContext(DbContextOptions<InspoQuoteContext> options) : base(options)
        {

        }
        public DbSet<Model.InspoQuote> InspoQuotes {get;set;}
    }
}
