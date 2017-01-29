using System;

namespace Sol.Common
{
    public abstract class GuidEntityBase: IRowVersionEntity<Guid>, IDatedEntity<Guid>
    {
        public Guid Id { get; set; }

        public bool IsNew => Id == Guid.Empty;

        public byte[] RowVersion { get; set; }

        public DateTime? ModifiedUtc { get; set; }

        public DateTime CreatedUtc { get; set; }
    }
}
