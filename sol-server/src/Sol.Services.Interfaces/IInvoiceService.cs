using Sol.Common;
using Sol.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Sol.Services.Interfaces
{
    public interface IInvoiceService:IDisposable
    {
        Task<IEnumerable<Invoice>> GetInvoiceAsync(
            int? deliveryPointId = null,
            int? zoneId = null,
            DateTime? start = null,
            DateTime? end = null,
            EvaluationStates? evaluationState = null,
            string orderBy = "Start",
            bool? isAsc = true,
            int? skip = 0, 
            int? take = 100,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<Invoice> FindInvoiceByIdAsync(int id,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<Invoice> SaveInvoiceAsync(Invoice entity,
            CancellationToken cancellationToken = default(CancellationToken));

        Task DeleteInvoiceAsync(Invoice entity,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}
