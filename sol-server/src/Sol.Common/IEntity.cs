namespace Sol.Common
{
    public interface IEntity<T>
    {
        T Id { get; set; }

        bool IsNew { get; }
    }
}
