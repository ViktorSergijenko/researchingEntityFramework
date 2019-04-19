using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WindowsFormsApp1.AppContext;
using WindowsFormsApp1.Models;
namespace WindowsFormsApp1.Services
{
    class CustomerService
    {
        protected Context DB { get; private set; }
        public CustomerService()
        {

            DB = new Context();
        }
        #region BaseCrud
        /// <summary>
        /// Method gets list with objects from DB
        /// </summary>
        /// <returns>List of objects</returns>
        public async Task<List<Customer>> GetAllWeaponsList()
        {
            // Getting all objects from DB
            var customer = await DB.Customers.ToListAsync();
            // Returning list with objects from DB
            return customer;
        }

        /// <summary>
        /// Method add or updates object in DB
        /// </summary>
        /// <param name="customer">New or updated object</param>
        /// <returns>New or updated object</returns>
        public async Task<Customer> Save(Customer customer)
        {
            if (customer.Id == null || customer.Id.Equals(Guid.Empty))
            {
                // Adding new object to DB
                DB.Customers.Add(customer);
            }
            else
            {
                // Updating object in DB
                DB.Customers.Update(customer);
            }
            // Saving changes in DB
            await DB.SaveChangesAsync();
            return customer;
        }

        /// <summary>
        /// Method deletes object from DB
        /// </summary>
        /// <param name="id">Id of an object that we want to delete</param>
        /// <returns></returns>
        public async Task Delete(Guid id)
        {
            // Getting object from DB with the same id like in param
            var customerToDelete = await DB.Customers.FirstOrDefaultAsync(x => x.Id == id);
            if (customerToDelete == null)
            {
                // If it's null then we throw exception
                throw new Exception("Not found");
            }
            // Removing object from DB
            DB.Customers.Remove(customerToDelete);
            // Saving changes in DB
            await DB.SaveChangesAsync();
        }
        #endregion BaseCrud
    }
}
