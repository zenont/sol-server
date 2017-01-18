using Sol.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sol.Common;
using Sol.Entities;
using System.Threading;
using Sol.RelationalDb;
using Microsoft.EntityFrameworkCore;
using NeinLinq;
using Sol.RelationalDb.Extensions;

namespace Sol.Services.Abstractions
{
    public abstract class InvoiceServiceBase: EntityServiceBase, IInvoiceService
    {
        protected InvoiceServiceBase(SolDb solDb) : base(solDb)
        {
        }

        public virtual async Task DeleteInvoiceAsync(Invoice entity, CancellationToken cancellationToken = default(CancellationToken))
        {
            SolDb.Remove(entity);
            await SolDb.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task<Invoice> FindInvoiceByIdAsync(int id, CancellationToken cancellationToken = default(CancellationToken))
        {
            return await SolDb.FindAsync<Invoice>(id, cancellationToken);
        }

        public virtual async Task<IEnumerable<Invoice>> GetInvoiceAsync(
            int? deliveryPointId = null, 
            int? zoneId = null, 
            DateTime? start = null, 
            DateTime? end = null, 
            EvaluationStates? evaluationState = null, 
            string orderBy = "Start", 
            bool? isAsc = true,
            int? skip = 0, 
            int? take = 100, 
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return await SolDb.Invoice
                .Include(s => s.DeliveryPoint)
                .Include(s => s.Zone)
                .Where(x => deliveryPointId == null || x.DeliveryPointId == deliveryPointId)
                .Where(x => zoneId == null || x.ZoneId == zoneId)
                .Where(x => evaluationState == null || x.EvaluationState == evaluationState)
                .Where(x => start == null || x.Start >= start)
                .Where(x => end == null || x.End <= end)
                .OrderBy(orderBy ?? "Start", descending: !(isAsc ?? true))
                .Skip(skip ?? 0)
                .Take(take ?? 0)
                .ToListAsync(cancellationToken);
        }

        public virtual async Task<Invoice> SaveInvoiceAsync(Invoice entity, CancellationToken cancellationToken = default(CancellationToken))
        {
            SolDb.AddOrUpdate(entity);
            await SolDb.SaveChangesAsync(cancellationToken);
            return entity;
        }
    }
}
