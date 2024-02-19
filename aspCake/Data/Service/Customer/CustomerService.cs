using Microsoft.EntityFrameworkCore;
using aspCake.Data.DTOs;
using aspCake.Models;
using aspCake.Data.Service.Customer;

namespace aspCake.Data.Service.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly BcakesContext _dbcontext;

        // public BcakesContext Dbcontext => _dbcontext;

        public CustomerService(BcakesContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<bool> InsertData(CustomerDTO customerDTO){
            aspCake.Models.Customer customer = new()
            {
                FirstName = customerDTO.FirstName,
                LastName = customerDTO.LastName,
                Email = customerDTO.Email
            };
            await _dbcontext.Customers.AddAsync(customer);
            await _dbcontext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteData(int id){
            aspCake.Models.Customer customer = await _dbcontext.Customers.Where(x => x.id == id).FirstOrDefaultAsync();
            if(customer == null){
                return false;
            }

            _dbcontext.Customers.Remove(customer);
            await _dbcontext.SaveChangesAsync();

            return true;
        }

        public async Task<CustomerDTO> GetDataAsync(int id){
            aspCake.Models.Customer customer = await _dbcontext.Customers.Where(x => x.id = id).FirstOrDefaultAsync();
            if(customer == null){
                return new CustomerDTO();
            }

            CustomerDTO customerDTO = new()
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email
            };

            return customerDTO;
        }

        public async Task<List<CustomerDTO>> GetAllDataAsync(){
            aspCake.Models.Customer customer = await _dbcontext.Customers.ToListAsync();
            if(customer == null){
                return new List<CustomerDTO>();
            }

            List<CustomerDTO> customerDTO = customer.Select(x => new CustomerDTO
            {
                CustomerId = x.CustomerId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email
            }).ToList();

            return customerDTO;
        }

        public async Task<bool> UpdateData(CustomerDTO customerDTO, int id){
            aspCake.Models.Customer customer = await _dbcontext.Customers.Where(x => x.id == id).FirstOrDefaultAsync();

            if(customer == null){
                return false;
            }

            customer.FirstName = customerDTO.FirstName;
            customer.LastName = customerDTO.LastName;
            customer.Email = customerDTO.Email;

            _dbcontext.Customers.Update(customer);
            await _dbcontext.SaveChangesAsync();

            return true;
        }

    }
}