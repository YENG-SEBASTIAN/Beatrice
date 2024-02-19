using aspCake.Data.DTOs;
using aspCake.Data.Repository.CustomerRepo;


namespace aspCake.Data.Service.Customer
{
    public interface ICustomerService 
    {
        Task<bool> InsertData(CustomerDTO customerDTO);
        Task<bool> UpdateData(CustomerDTO customerDTO, int id);
        Task<List<CustomerDTO>> GetAllDataAsync();
        Task<CustomerDTO> GetDataAsync(int id);
        Task<bool> DeleteData(int id);
    }
}