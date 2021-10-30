namespace _01_Framework.Repository
{
    public interface IUnitofWork
    {
        void BeginTransaction();
        void CommitTransaction();
        void RollBack();

    }
}