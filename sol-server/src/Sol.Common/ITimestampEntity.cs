namespace Sol.Common
{
    public interface ITimestampEntity<T>:IEntity<T>
    {
        byte[] Timestamp { get; set; }
    }
}

