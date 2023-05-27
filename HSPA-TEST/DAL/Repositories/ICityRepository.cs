using HSPA_TEST.DAL.Models;
using System.Runtime.InteropServices;

namespace HSPA_TEST.DAL.Repositories
{
    public interface ICityRepository
    {
        Task<List<City>> GetAllAsync();
        Task<City?> GetByIdAsync(Guid Id);

        Task<City>CreateAsync(City city);

        Task<City?> UpdateAsync(Guid Id, City city);

        Task<City?> DeleteAsync(Guid Id);


    }
}
