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

        public async Task<City> CreateAsync(City city)
        {
           await dbContext.Cities.AddAsync(city);
           await dbContext.SaveChangesAsync();
           return city;
        
        }

        public async Task<City?> DeleteAsync(Guid Id)
        {
            var existingCity = await dbContext.Cities.FirstOrDefaultAsync(c => c.Id == Id);
            if (existingCity == null)
            {
                return null;
            }
            dbContext.Cities.Remove(existingCity);
            await dbContext.SaveChangesAsync();
            return existingCity;
        }

        public async Task<List<City>> GetAllAsync()
        {
            return await dbContext.Cities.ToListAsync();
        }

        public async Task<City?> GetByIdAsync(Guid Id)
        {
            return await  dbContext.Cities.FirstOrDefaultAsync(c => c.Id == Id);  
        }

        public async Task<City?> UpdateAsync(Guid Id, City city)
        {
            var existingCity = await dbContext.Cities.FirstOrDefaultAsync(x => x.Id == Id);
            if (existingCity == null)
            {
                return null;
            }

            existingCity.Name = city.Name;
            existingCity.Country = city.Country;

            await dbContext.SaveChangesAsync();
            return existingCity;

        }
    }
}
