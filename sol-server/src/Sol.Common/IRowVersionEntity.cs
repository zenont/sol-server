namespace Sol.Common
{
    public interface IRowVersionEntity<T>:IEntity<T>
    {
        byte[] RowVersion { get; set; }
    }
}

