using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.AppContext;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Dependency injection
            var serviceProvide = new ServiceCollection()
                .AddScoped<WeaponService>()
                .AddScoped<AcessuaryService>()
                .AddScoped<AmmoService>()
                .AddScoped<AmmoShopService>()
                .AddScoped<CustomerService>()
                .AddScoped<EmployeeService>()
                .AddScoped<PurchasesService>()
                .AddScoped<WeaponTypeService>()

                .AddScoped<Context>()
                ;
            #endregion Dependency injection
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartMenu());
        }
    }
}
