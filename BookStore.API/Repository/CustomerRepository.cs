using AutoMapper;
using BookStore.API.Data;
using BookStore.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.API.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;
        public CustomerRepository(BookStoreContext context,IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public async Task<CustomerModel> AddCustomer(CustomerModel model)
        {

            var data = new CustomerModel()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Company = model.Company,
                CustomerType = model.CustomerType,
                CustomerStatus = model.CustomerStatus,
                Email = model.Email,
                Phone = model.Phone,
                MailAddress1 = model.MailAddress1,
                MainCity = model.MainCity,
                MainCountry = model.MainCountry,
                MainState = model.MainState,
                MainZip = model.MainZip,
                MailAddress2 = model.MailAddress2,
                MainAddress1 = model.MainAddress1,
                MiddleName = model.MiddleName,
                NameSuffix = model.NameSuffix
            };

            _context.CustomerModels.Add(data);
            await _context.SaveChangesAsync();
            return (data);

        }

        public async Task DeleteCustomerAsync(int Id)
        {
            var book = new CustomerModel() { Id = Id };

            _context.CustomerModels.Remove(book);

            await _context.SaveChangesAsync();
        }

        public async Task<List<CustomerModel>> GetAllBooksAsync()
        {
            var records = await _context.CustomerModels.ToListAsync();
            return _mapper.Map<List<CustomerModel>>(records);
        }

        public async Task<CustomerModel> GetCustomerByIdAsync(int Id)
        {
            var data = await _context.CustomerModels.FindAsync(Id);
            return _mapper.Map<CustomerModel>(data);
        }

        public async Task UpdateCustomerAsync(int Id, CustomerModel customer)
        {

            var emp = new CustomerModel()
            {
                Id = Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Company = customer.Company,
                CustomerStatus = customer.CustomerStatus,
                CustomerType = customer.CustomerType,
                MainCity = customer.MainCity,
                MainCountry = customer.MainCountry,
                Email= customer.Email,
                MailAddress1= customer.MailAddress1,
                MailAddress2 = customer.MailAddress2,
                MainAddress1 = customer.MainAddress1,
                MainState = customer.MainState,
                MainZip = customer.MainZip,
                MiddleName = customer.MiddleName,
                NameSuffix= customer.NameSuffix,
                Phone = customer.Phone
            };

            _context.CustomerModels.Update(emp);
            await _context.SaveChangesAsync();
        }
    }
}
