namespace WebApp_Xunit.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T Entity);
        List<T> Get();
    }
}
