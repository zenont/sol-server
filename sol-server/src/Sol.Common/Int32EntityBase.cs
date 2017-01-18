using System;

namespace Sol.Common
{
    public class Int32EntityBase : ITimestampEntity<int>, IDatedEntity<int>
    {
        public DateTime CreateUtc
        {
            get;set;
        }

        public int Id
        {
            get; set;
        }

        public bool IsNew
        {
            get
            {
                return Id == 0;
            }
        }

        public DateTime? ModifyUtc
        {
            get;set;
        }

        public byte[] Timestamp
        {
            get;set;
        }
    }
}
