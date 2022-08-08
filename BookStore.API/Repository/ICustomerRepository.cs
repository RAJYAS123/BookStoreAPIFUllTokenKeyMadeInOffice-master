using BookStore.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public interface ICustomerRepository
    {
        Task<CustomerModel> AddCustomer(CustomerModel model);
        Task<List<CustomerModel>> GetAllBooksAsync();
        Task<CustomerModel> GetCustomerByIdAsync(int Id);
        Task UpdateCustomerAsync(int Id, CustomerModel customer);
        Task DeleteCustomerAsync(int Id);
    }
}
