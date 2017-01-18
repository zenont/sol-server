using Sol.RelationalDb;
using System;

namespace Sol.Services.Abstractions
{
    public abstract class EntityServiceBase:IDisposable
    {
        protected EntityServiceBase(SolDb solDb)
        {
            SolDb = solDb;
        }

        protected SolDb SolDb { get; set; }

        public void Dispose()
        {
            SolDb.Dispose();
        }
    }
}
