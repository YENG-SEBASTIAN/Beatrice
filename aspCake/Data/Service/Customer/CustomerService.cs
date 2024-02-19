using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using aspCake.Data.DTOs;
using aspCake.Models;
using aspCake.Data.Service.Customer;

namespace aspCake.Data.Service.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly BcakesContext _dbContext;

        public CustomerService(BcakesContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> InsertData(CustomerDTO customerDTO)
        {
            var customer = new aspCake.Models.Customer
            {
                FirstName = customerDTO.FirstName,
                LastName = customerDTO.LastName,
                Email = customerDTO.Email
            };
            await _dbContext.Customers.AddAsync(customer);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteData(int id)
        {
            var customer = await _dbContext.Customers.FindAsync(id);
            if (customer == null)
            {
                return false;
            }

            _dbContext.Customers.Remove(customer);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<CustomerDTO> GetDataAsync(int id)
        {
            var customer = await _dbContext.Customers.FindAsync(id);
            if (customer == null)
            {
                return null;
            }

            var customerDTO = new CustomerDTO
            {
                CustomerId = customer.CustomerId,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email
            };

            return customerDTO;
        }

        public async Task<List<CustomerDTO>> GetAllDataAsync()
        {
            var customers = await _dbContext.Customers.ToListAsync();
            var customerDTOs = customers.Select(x => new CustomerDTO
            {
                CustomerId = x.CustomerId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email
            }).ToList();

            return customerDTOs;
        }

        public async Task<bool> UpdateData(CustomerDTO customerDTO, int id)
        {
            var customer = await _dbContext.Customers.FindAsync(id);

            if (customer == null)
            {
                return false;
            }

            customer.FirstName = customerDTO.FirstName;
            customer.LastName = customerDTO.LastName;
            customer.Email = customerDTO.Email;

            _dbContext.Customers.Update(customer);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
