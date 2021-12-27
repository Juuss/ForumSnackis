using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snackis.Models
{
    public interface IInspoQuoteGateway
    {
        Task<List<Models.InspoQuote>> GetInspoQuote();
        Task<Models.InspoQuote> GetInspoQuote(long id);
        Task<Models.InspoQuote> PostInspoQuote(Models.InspoQuote InspoQuote);
        Task PutInspoQuote(long EditId, Models.InspoQuote InspoQuote);
        Task<Models.InspoQuote> DeleteInspoQuote(long deleteId);
        Task<Models.InspoQuote> GetRandom();
    }
}
