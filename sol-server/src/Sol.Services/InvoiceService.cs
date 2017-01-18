using Sol.Services.Abstractions;
using Sol.RelationalDb;

namespace Sol.Services
{
    public class InvoiceService : InvoiceServiceBase
    {
        public InvoiceService(SolDb solDb) : base(solDb)
        {
        }
    }
}
