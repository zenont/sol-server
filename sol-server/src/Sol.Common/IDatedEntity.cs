using System;

namespace Sol.Common
{
    public interface IDatedEntity<T> :IEntity<T>
    {
        DateTime? ModifyUtc { get; set; }

        DateTime CreateUtc { get; set; }
    }
}
