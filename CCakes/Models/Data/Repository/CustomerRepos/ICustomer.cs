using CCakes.Models.Data.DTOs.Customer;

namespace CCakes.Models.Data.Repository.CustomerRepos
{
    public interface ICustomer
    {
        Tasks<bool> AddCustomerAsync(AddCustomerDTO model);
        Tasks<bool> UpdateCustomerAsync(AddCustomerDTO model, int id);
        Task<List<CustomerDTO>> GetCustomerAsync();
        Task<CustomerDTO> GetCustomerByIdAsync(int id);
        Task<bool> DeleteCustomerAsync(int id);
    }
}