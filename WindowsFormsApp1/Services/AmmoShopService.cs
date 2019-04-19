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
    class AmmoShopService
    {
        protected Context DB = new Context();

        #region BaseCrud
        /// <summary>
        /// Method gets list with objects from DB
        /// </summary>
        /// <returns>List of objects</returns>
        public async Task<List<AmmoShop>> GetList()
        {
            // Getting all objects from DB
            var weaponShops = await DB.AmmoShops.ToListAsync();
            // Returning list with objects from DB
            return weaponShops;
        }

        /// <summary>
        /// Method add or updates object in DB
        /// </summary>
        /// <param name="weapon">New or updated object</param>
        /// <returns>New or updated object</returns>
        public async Task<AmmoShop> Save(AmmoShop weaponShop)
        {
            if (weaponShop.Id == null || weaponShop.Id.Equals(Guid.Empty))
            {
                // Adding new object to DB
                DB.AmmoShops.Add(weaponShop);
            }
            else
            {
                // Updating object in DB
                DB.AmmoShops.Update(weaponShop);
            }
            // Saving changes in DB
            await DB.SaveChangesAsync();
            return weaponShop;
        }

        /// <summary>
        /// Method deletes object from DB
        /// </summary>
        /// <param name="id">Id of an object that we want to delete</param>
        /// <returns></returns>
        public async Task Delete(Guid id)
        {
            // Getting object from DB with the same id like in param
            var weaponShopToDelete = await DB.AmmoShops.FirstOrDefaultAsync(x => x.Id == id);
            if (weaponShopToDelete == null)
            {
                // If it's null then we throw exception
                throw new Exception("Not found");
            }
            // Removing object from DB
            DB.AmmoShops.Remove(weaponShopToDelete);
            // Saving changes in DB
            await DB.SaveChangesAsync();
        }
        #endregion BaseCrud

        #region Filtration method

        /// <summary>
        /// Method gets filtered ammo shops query, depending on the filter option
        /// </summary>
        /// <param name="filterOption">Filter option, by which filtration will be done</param>
        /// <returns></returns>
        public async Task<List<AmmoShop>> FilterMethod(string filterSorting) {
            // Getting our warehouse query, that we will filter
            var ammoShopQuery = await DB.AmmoShops.ToListAsync();
            // Checking if our filter option is null
            if (!String.IsNullOrEmpty(filterSorting))
            {
                // If it's not null, then we set this option to lover case
                var filter = filterSorting.ToLower();
                // Filtering our query, where warehouse address or name contains something similar to our option
                ammoShopQuery = ammoShopQuery.Where(x => x.ShopName.ToLower().Contains(filter)
                || x.Address.ToLower().Contains(filter)
                || x.WorkTime.ToLower().Contains(filter)).ToList();
            }
            else
            {
                // TODO: This is only for short period of time, need to make functionality where user can chose by what field user can sort and in whick direction
                // If our option is null, then we just sorting our query by name
                ammoShopQuery = ammoShopQuery.OrderByDescending(x => x.ShopName).ToList();
            }
            return ammoShopQuery;
        }
        #endregion Filtration method
    }
}
