namespace HSPA_TEST.DAL.Repositories
{
    public interface ICityRepository
    {
        Task GetById(Guid id);
    }
}
