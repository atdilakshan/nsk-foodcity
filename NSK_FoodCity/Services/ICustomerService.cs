using NSK_FoodCity.Models;

namespace NSK_FoodCity.Services
{
    public interface ICustomerService
    {
        Task<CustomerResponseModel> Add(CustomerRequestModel requestModel);
        Task<List<CustomerResponseModel>> Get();
        Task<CustomerResponseModel> Get(Guid id);
        Task<CustomerResponseModel> Update(Guid id, CustomerRequestModel requestModel);
        Task Delete(Guid id);
    }
}
