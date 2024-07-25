using Microsoft.EntityFrameworkCore;
using NSK_FoodCity.Data;
using NSK_FoodCity.Entities;

namespace NSK_FoodCity.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _dbContext;

        public CustomerRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Customer> Add(Customer customer)
        {
            var data = await _dbContext.AddAsync(customer);
            await _dbContext.SaveChangesAsync();
            return data.Entity;
        }

        public async Task<List<Customer>> Get()
        {
            var data = await _dbContext.Customers.ToListAsync();
            return data;
        }

        public async Task<Customer> Get(Guid id)
        {
            var data = await _dbContext.Customers.FirstOrDefaultAsync(c => c.Id == id);

            return data;
        }

        public async Task<Customer> Update(Customer customer)
        {
            var data = _dbContext.Update(customer);
            await _dbContext.SaveChangesAsync();
            return data.Entity;
        }

        public async Task Delete(Customer customer)
        {
            _dbContext.Remove(customer);
            await _dbContext.SaveChangesAsync();
        }
    }
}
