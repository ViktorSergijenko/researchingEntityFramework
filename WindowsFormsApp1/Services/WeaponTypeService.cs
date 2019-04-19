using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.AppContext;
using Microsoft.Extensions.DependencyInjection;
using WindowsFormsApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace WindowsFormsApp1.Services
{
    class WeaponTypeService
    {
        protected Context DB { get; private set; }
        public WeaponTypeService()
        {
            DB = new Context();
        }
        #region BaseCrud
        /// <summary>
        /// Method gets list with objects from DB
        /// </summary>
        /// <returns>List of objects</returns>
        public async Task<List<WeaponType>> GetList()
        {
            // Getting all objects from DB
            var weaponType = await DB.WeaponTypes.ToListAsync();
            // Returning list with objects from DB
            return weaponType;
        }

        /// <summary>
        /// Method add or updates object in DB
        /// </summary>
        /// <param name="weaponType">New or updated object</param>
        /// <returns>New or updated object</returns>
        public async Task<WeaponType> Save(WeaponType weaponType)
        {
            if (weaponType.Id == null || weaponType.Id.Equals(Guid.Empty))
            {
                // Adding new object to DB
                DB.WeaponTypes.Add(weaponType);
            }
            else
            {
                // Updating object in DB
                DB.WeaponTypes.Update(weaponType);
            }
            // Saving changes in DB
            await DB.SaveChangesAsync();
            return weaponType;
        }

        /// <summary>
        /// Method deletes object from DB
        /// </summary>
        /// <param name="id">Id of an object that we want to delete</param>
        /// <returns></returns>
        public async Task Delete(Guid id)
        {
            // Getting object from DB with the same id like in param
            var weaponTypeToDelete = await DB.WeaponTypes.FirstOrDefaultAsync(x => x.Id == id);
            if (weaponTypeToDelete == null)
            {
                // If it's null then we throw exception
                throw new Exception("Not found");
            }
            // Removing object from DB
            DB.WeaponTypes.Remove(weaponTypeToDelete);
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
        public async Task<List<WeaponType>> FilterMethod(string filterSorting)
        {
            // Getting our query, that we will filter
            var query = await DB.WeaponTypes.ToListAsync();
            // Checking if our filter option is null
            if (!String.IsNullOrEmpty(filterSorting))
            {
                // If it's not null, then we set this option to lover case
                var filter = filterSorting.ToLower();
                // Filtering our query, where warehouse address or name contains something similar to our option
                query = query.Where(x => x.Name.ToLower().Contains(filter)).ToList();
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
