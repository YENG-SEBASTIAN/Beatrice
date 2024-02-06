
using CCakes.Models.Data.DTOs.Customer;

namespace CCakes.Models.Data.Repository.CustomerRepo
{
    public interface ICustomer
    {
        Task<bool> AddCustomerAsync(AddCustomerDTO model);
        Task<bool> UpdateCustomerAsync(AddCustomerDTO model, int id);
        Task<List<CustomerDTO>> GetMCustomerAsync();
        Task<CustomerDTO> GetCustomerByIdAsync(int id);
        Task<bool> DeleteCustomerAsync(int id);

    }
}