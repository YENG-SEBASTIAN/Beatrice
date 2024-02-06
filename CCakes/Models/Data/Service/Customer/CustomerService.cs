using Microsoft.EntityFrameworkCore;
using CCakes.Models.Data.DTOs.Customer;
using CCakes.Models.Data.Repository.CustomerRepo;

namespace CCakes.Models.Data.Service.Customer
{
    public class CustomerService : ICustomer
    {
        private readonly BcakesContext _db;
        public CustomerService(BcakesContext db) {
            _db = db;
        }

        public async Task<bool> AddCustomerAsync(AddCustomerDTO model)
        {
            CCakes.Models.Customer customer = new()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email
            };
            await _db.Customers.AddAsync(customer);
            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteCustomerAsync(int id)
        {
            CCakes.Models.Customer customer = await _db.Customers
            .Where(x => x.CustomerId == id)
            .FirstOrDefaultAsync();

            if (customer == null)
            {
                return false;
            }

            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();


            return true;

        }

        public async Task<CustomerDTO> GetCustomerByIdAsync(int id)
        {
            CCakes.Models.Customer customer = await _db.Customers
            .Where(x => x.CustomerId == id)
            .FirstOrDefaultAsync();

            if (customer == null)
            {
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

        public async Task<List<CustomerDTO>> GetMCustomerAsync()
        {
            List<CCakes.Models.Customer> customers = await _db.Customers.ToListAsync();

            if(customers == null){
                return new List<CustomerDTO>();
            }

            List<CustomerDTO> customerDTOs = customers.Select(x => new CustomerDTO
            {
                CustomerId = x.CustomerId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email
            }).ToList();

            return customerDTOs;
        }

        public async Task<bool> UpdateCustomerAsync(AddCustomerDTO model, int id)
        {
            CCakes.Models.Customer customer = await _db.Customers
            .Where(x => x.CustomerId == id)
            .FirstOrDefaultAsync();

            if(customer == null){
                return false;
            }

            customer.FirstName = model.FirstName;
            customer.LastName = model.LastName;
            customer.Email = model.Email;

            _db.Customers.Update(customer);
            await _db.SaveChangesAsync();

            return true;
        }
    }
} 