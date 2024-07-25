using NSK_FoodCity.Entities;

namespace NSK_FoodCity.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> Add(Customer customer);
        Task<List<Customer>> Get();
        Task<Customer> Get(Guid id);
        Task<Customer> Update(Customer customer);
        Task Delete(Customer customer);
    }
}
