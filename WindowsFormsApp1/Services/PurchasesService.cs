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
    class PurchasesService
    {
        protected Context DB { get; private set; }
       public PurchasesService()
        {
            // Injecting Our Db context
            DB = new Context();
        }
        #region BaseCrud
        /// <summary>
        /// Method gets list with objects from DB
        /// </summary>
        /// <returns>List of objects</returns>
        public async Task<List<Purchases>> GetAllWeaponsList()
        {
            // Getting all objects from DB
            var purchases = await DB.Purchases.ToListAsync();
            // Returning list with objects from DB
            return purchases;
        }

        /// <summary>
        /// Method add or updates object in DB
        /// </summary>
        /// <param name="purchases">New or updated object</param>
        /// <returns>New or updated object</returns>
        public async Task<Purchases> Save(Purchases purchases)
        {
            if (purchases.Id == null || purchases.Id.Equals(Guid.Empty))
            {
                // Adding new object to DB
                DB.Purchases.Add(purchases);
            }
            else
            {
                // Updating object in DB
                DB.Purchases.Update(purchases);
            }
            
           // Saving changes in DB
           await DB.SaveChangesAsync();
            return purchases;
        }

        /// <summary>
        /// Method deletes object from DB
        /// </summary>
        /// <param name="id">Id of an object that we want to delete</param>
        /// <returns></returns>
        public async Task Delete(Guid id)
        {
            // Getting object from DB with the same id like in param
            var purchasesToDelete = await DB.Purchases.FirstOrDefaultAsync(x => x.Id == id);
            if (purchasesToDelete == null)
            {
                // If it's null then we throw exception
                throw new Exception("Not found");
            }
            // Removing object from DB
            DB.Purchases.Remove(purchasesToDelete);
            // Saving changes in DB
            await DB.SaveChangesAsync();
        }
        #endregion BaseCrud
    }
}
