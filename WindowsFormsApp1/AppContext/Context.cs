using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.AppContext
{
    /// <summary>
    /// Class where we define all our entity queries that will be in table
    /// </summary>
    class Context : DbContext 
    {
        // Именно через класс Context мы будем обращаться в bazu dannih Смотри примеры в AmmoShopService там у меня сделано всё без выебонов, в остальных сервисах я юзал Dependency Injection который тебе нахуй не сдался
        // Место где я обьявляю все таблицы которые будут у меня в БД
      
        #region Defining All entity tables
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<AmmoShop> AmmoShops { get; set; }
        public DbSet<Ammo> Ammos { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<WeaponType> WeaponTypes { get; set; }
        public DbSet<Acessuary> Acessuarys { get; set; }
        public DbSet<Purchases> Purchases { get; set; }
        #endregion Defining All entity tables

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Это мой конекш стринг, путь к базе данных в которой создадуться все таблицы и тд(В самой БД делать в ручную таблицы не надо, за тебя всё делает EntityFramework)
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=mileit;Username=mileit;Password=mileit");
            
        }
        // Тут я оптсываю модели таблиц(Все его констреинты и тд(тут даже можно задать регих на поле или сделать его уникальным, просто почитай про это в инете))
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Если у тебя несколько обьектов в таблице, то для каждого нужно описать всё отдельно(смотри примеры в Employee and Purchases)
            // Бывает так, что модель вообще не надо описывать, так как у него нету никаих особых связей
            #region Employee model builder
            modelBuilder.Entity<Employee>()
                .HasOne(x => x.AmmoShop) // У Employee есть один обьект AmmoShop к которому он привязан(работать может лишь в одном магазине)
                .WithMany(X => X.Employees) // У AmmoShop есть лист с обьектами Employee, в одном магазине работает множество работников
                 .HasForeignKey(x => x.AmmoShopId) // Всё это связано полем AmmoShopId в классе Employee
                .IsRequired() // И поле которым всё связанно обязательна должна быть заполнена при создании Employee(бывают кейсы когда связывающие поля могут быть пустыми(смотри пример ниже))
                ;
            modelBuilder.Entity<Employee>()
               .HasMany(x => x.Employees)
                .WithOne(x => x.Boss)
                .HasForeignKey(x => x.ReportsTo) // Тут я не делал IsRequired потому что у Босса нету человека которому он подчиняется это та самая рекурсивная связь
                ;
            modelBuilder.Entity<Employee>()
                .HasOne(x => x.Boss)
                .WithMany()
                .HasForeignKey(x => x.ReportsTo)
                ;
            #endregion Employee model builder

            #region AmmoShop model builder
            modelBuilder.Entity<AmmoShop>()
               .HasMany(x => x.Employees)
               .WithOne(x => x.AmmoShop)
               .HasForeignKey(x => x.AmmoShopId)
               .IsRequired()
               ;
            #endregion AmmoShop model builder

            #region Weapon model builder
            modelBuilder.Entity<Weapon>()
                .HasOne(x => x.WeaponType)
                .WithMany(x => x.Weapons)
                .HasForeignKey(x => x.WeaponTypeId)
                .IsRequired()
                ;


            #endregion Weapon model builder

            #region Ammo model builder
            modelBuilder.Entity<Ammo>()
                .HasOne(x => x.WeaponTypes)
                .WithMany(x => x.Ammo)
                .HasForeignKey(x => x.WeaponTypeId)
                ;

            #endregion

            #region Purchase model builder
            modelBuilder.Entity<Purchases>()
                .HasOne(x => x.Acessuary)
                .WithMany(x => x.Purchases)
                .HasForeignKey(x => x.AcessuaryId)
                ;
            modelBuilder.Entity<Purchases>()
              .HasOne(x => x.Ammo)
              .WithMany(x => x.Purchases)
              .HasForeignKey(x => x.AmmoId)
              ;
            modelBuilder.Entity<Purchases>()
              .HasOne(x => x.AmmoShop)
              .WithMany(x => x.Purchases)
              .HasForeignKey(x => x.AmmoShopId)
              ;
            modelBuilder.Entity<Purchases>()
              .HasOne(x => x.Weapon)
              .WithMany(x => x.Purchases)
              .HasForeignKey(x => x.WeaponId)
              ;
            modelBuilder.Entity<Purchases>()
              .HasOne(x => x.Employee)
              .WithMany(x => x.Purchases)
              .HasForeignKey(x => x.EmployeeId)
              ;
            modelBuilder.Entity<Purchases>()
              .HasOne(x => x.Customer)
              .WithMany(x => x.Purchases)
              .HasForeignKey(x => x.CustomerId)
              ;
            #endregion Purchase model builder



            base.OnModelCreating(modelBuilder);
        }
    }
}
