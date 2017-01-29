using System;

namespace Sol.Common
{
    public interface IDatedEntity<T> :IEntity<T>
    {
        DateTime? ModifiedUtc { get; set; }

        DateTime CreatedUtc { get; set; }
    }
}
