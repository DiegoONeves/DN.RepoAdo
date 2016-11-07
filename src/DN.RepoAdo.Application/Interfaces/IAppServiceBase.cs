namespace DN.RepoAdo.Application.Interfaces
{
    public interface IAppServiceBase
    {
        void BeginTransaction();
        void RollBack();
        void Commit();
    }
}
