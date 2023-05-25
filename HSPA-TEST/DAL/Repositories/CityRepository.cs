using HSPA_TEST.DAL.Data;
using HSPA_TEST.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace HSPA_TEST.DAL.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext dbContext;

        public CityRepository(DataContext dbContext) 
        {
            this.dbContext = dbContext;
        }

        public async Task<List<City>> GetAllAsync()
        {
            return await dbContext.Cities.ToListAsync();
        }

        public async Task<City?> GetById(Guid Id)
        {
            return await dbContext.Cities.FirstOrDefaultAsync(x => x.Id == Id);

        }
    }
}
