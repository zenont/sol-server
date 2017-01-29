using System;

namespace Sol.Common
{
    public class Int32EntityBase : IRowVersionEntity<int>, IDatedEntity<int>
    {
        public DateTime CreatedUtc
        {
            get;set;
        }

        public int Id
        {
            get; set;
        }

        public bool IsNew => Id == 0;

        public DateTime? ModifiedUtc
        {
            get;set;
        }

        public byte[] RowVersion
        {
            get;set;
        }
    }
}
