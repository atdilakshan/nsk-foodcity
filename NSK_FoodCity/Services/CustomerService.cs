using NSK_FoodCity.Entities;
using NSK_FoodCity.Models;
using NSK_FoodCity.Repositories;

namespace NSK_FoodCity.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerResponseModel> Add(CustomerRequestModel requestModel)
        {
            Customer entity = new()
            {
                Id = new Guid(),
                Name = requestModel.Name,
                PhonNumber = requestModel.PhonNumber,
                Email = requestModel.Email
            };

            var customer = await _customerRepository.Add(entity);

            CustomerResponseModel response = new()
            {
                Id = customer.Id,
                Name = customer.Name,
                PhonNumber = customer.PhonNumber,
                Email = customer.Email
            };

            return response;
        }

        public async Task<List<CustomerResponseModel>> Get()
        {
            var customers = await _customerRepository.Get();

            List<CustomerResponseModel> response = [];

            foreach (var customer in customers)
            {
                CustomerResponseModel res = new()
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    PhonNumber = customer.PhonNumber,
                    Email = customer.Email
                };

                response.Add(res);
            }
            return response;
        }

        public async Task<CustomerResponseModel> Get(Guid id)
        {
            var customer = await _customerRepository.Get(id);

            CustomerResponseModel response = new()
            {
                Id = customer.Id,
                Name = customer.Name,
                PhonNumber = customer.PhonNumber,
                Email = customer.Email
            };
            return response;
        }

        public async Task<CustomerResponseModel> Update(Guid id, CustomerRequestModel requestModel)
        {
            var existingCustomer = await _customerRepository.Get(id);

            if (existingCustomer == null)
            {
                throw new Exception("Record not found!");
            }

            Customer entity = new()
            {
                Name = requestModel.Name,
                PhonNumber = requestModel.PhonNumber,
                Email = requestModel.Email
            };

            var customer = await _customerRepository.Update(entity);

            CustomerResponseModel response = new()
            {
                Id = customer.Id,
                Name = customer.Name,
                PhonNumber = customer.PhonNumber,
                Email = customer.Email
            };

            return response;
        }

        public async Task Delete(Guid id)
        {

            var existingCustomer = await _customerRepository.Get(id);

            if (existingCustomer == null)
            {
                throw new Exception("Record not found!");
            }

            await _customerRepository.Delete(existingCustomer);
        }
    }
}
