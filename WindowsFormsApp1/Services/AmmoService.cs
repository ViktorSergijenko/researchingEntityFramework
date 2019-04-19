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
    class AmmoService
    {
        protected Context DB { get; private set; }
       public AmmoService()
        {
            // Injecting Our Db context
            DB = new Context();
        }
        #region BaseCrud
        /// <summary>
        /// Method gets list with objects from DB
        /// </summary>
        /// <returns>List of objects</returns>
        public async Task<List<Ammo>> GetList()
        {
            // Getting all objects from DB
            var ammo = await DB.Ammos.Include(x => x.WeaponTypes).ToListAsync();
            // Returning list with objects from DB
            return ammo;
        }

        /// <summary>
        /// Method add or updates object in DB
        /// </summary>
        /// <param name="ammo">New or updated object</param>
        /// <returns>New or updated object</returns>
        public async Task<Ammo> Save(Ammo ammo)
        {
            if (ammo.Id == null || ammo.Id.Equals(Guid.Empty))
            {
                // Adding new object to DB
                DB.Ammos.Add(ammo);
            }
            else
            {
                // Updating object in DB
                DB.Ammos.Update(ammo);
            }
            // Saving changes in DB
            await DB.SaveChangesAsync();
            return ammo;
        }

        /// <summary>
        /// Method deletes object from DB
        /// </summary>
        /// <param name="id">Id of an object that we want to delete</param>
        /// <returns></returns>
        public async Task Delete(Guid id)
        {
            // Getting object from DB with the same id like in param
            var ammoToDelete = await DB.Ammos.FirstOrDefaultAsync(x => x.Id == id);
            if (ammoToDelete == null)
            {
                // If it's null then we throw exception
                throw new Exception("Not found");
            }
            // Removing object from DB
            DB.Ammos.Remove(ammoToDelete);
            // Saving changes in DB
            await DB.SaveChangesAsync();
        }
        #endregion BaseCrud

        #region Filtration method
        /// <summary>
        /// Method gets filtered query, depending on the filter option
        /// </summary>
        /// <param name="filterOption">Filter option, by which filtration will be done</param>
        /// <returns></returns>
        public async Task<List<Ammo>> FilterMethod(string filterSorting)
        {
            // Getting our query, that we will filter
            var query = await DB.Ammos.ToListAsync();
            // Checking if our filter option is null
            if (!String.IsNullOrEmpty(filterSorting))
            {
                // If it's not null, then we set this option to lover case
                var filter = filterSorting.ToLower();
                // Filtering our query, where warehouse address or name contains something similar to our option
                query = query.Where(x => x.Name.ToLower().Contains(filter)
                || x.Price.ToString().Contains(filter)
                || x.WeaponTypes.Name.ToLower().Contains(filter)).ToList();
            }
            else
            {
                // TODO: This is only for short period of time, need to make functionality where user can chose by what field user can sort and in whick direction
                // If our option is null, then we just sorting our query by name
                query = query.OrderByDescending(x => x.Name).ToList();
            }
            return query;
        }
        #endregion Filtration method
    }
}
