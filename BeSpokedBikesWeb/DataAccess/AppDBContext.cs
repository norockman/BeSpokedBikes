using Microsoft.EntityFrameworkCore;
using BeSpokedBikesWeb.Models;

namespace BeSpokedBikesWeb.DataAccess
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Salesperson> Salespersons { get; set; }

        #region Seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasData(
                    new Customer
                    {
                        Id = 1,
                        FirstName = "Jeffery",
                        LastName = "Petties",
                        Address = "4697 Robinson Lane Worthington, OH 43085",
                        Phone = "740-337-9500",
                        StartDate = new DateTime(2020, 1, 28)
                    },
                    new Customer
                    {
                        Id = 2,
                        FirstName = "Barbara",
                        LastName = "Weiss",
                        Address = "2345 Beech Street Concord, CA 94520",
                        Phone = "925-825-6717",
                        StartDate = new DateTime(2021, 5, 8)
                    },
                    new Customer
                    {
                        Id = 3,
                        FirstName = "Thomas",
                        LastName = "Kearney",
                        Address = "2436 Kessla Way Hardeeville, SC 29927",
                        Phone = "843-288-0173",
                        StartDate = new DateTime(2022, 3, 15)
                    });

            modelBuilder.Entity<Discount>()
                .HasData(
                    new Discount
                    {
                        Id = 1,
                        Product = "Aventon 2022 Soltera 7 Speed Electric Road Bike",
                        BeginDate = new DateTime(2020, 1, 28),
                        EndDate = new DateTime(2020, 1, 30),
                        DiscountPercentage = 10
                    },
                    new Discount
                    {
                        Id = 2,
                        Product = "Specialized 2021 Turbo Creo SL E5 Comp Electric Road Bike",
                        BeginDate = new DateTime(2021, 5, 8),
                        EndDate = new DateTime(2021, 5, 15),
                        DiscountPercentage = 5
                    },
                    new Discount
                    {
                        Id = 3,
                        Product = "Cervelo 2022 Aspero Apex 1 Gravel Road Bike",
                        BeginDate = new DateTime(2022, 2, 3),
                        EndDate = new DateTime(2021, 2, 11),
                        DiscountPercentage = 20
                    });

            modelBuilder.Entity<Product>()
                .HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "Aventon 2022 Soltera 7 Speed Electric Road Bike",
                        Manufacturer = "Aventon",
                        Style = "Sport",
                        PurchasePrice = 2499.99M,
                        SalePrice = 2799.99M,
                        QtyOnHand = 10,
                        CommissionPercentage = 1
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Specialized 2021 Turbo Creo SL E5 Comp Electric Road Bike",
                        Manufacturer = "Specialized",
                        Style = "Sport",
                        PurchasePrice = 1499.99M,
                        SalePrice = 1799.99M,
                        QtyOnHand = 16,
                        CommissionPercentage = 2
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Cervelo 2022 Aspero Apex 1 Gravel Road Bike",
                        Manufacturer = "Cervelo",
                        Style = "Sport",
                        PurchasePrice = 499.99M,
                        SalePrice = 799.99M,
                        QtyOnHand = 4,
                        CommissionPercentage = 3
                    });

            modelBuilder.Entity<Sale>()
                .HasData(
                    new Sale
                    {
                        Id = 1,
                        Customer = "Jeffery Petties",
                        Product = "Cervelo 2022 Aspero Apex 1 Gravel Road Bike",
                        Salesperson = "Amanda Barber",
                        SalesDate = new DateTime(2021, 4, 7)
                    });

            modelBuilder.Entity<Salesperson>()
                .HasData(
                    new Salesperson
                    {
                        Id = 1,
                        FirstName = "Amanda",
                        LastName = "Barber",
                        Phone = "650-846-2128",
                        Address = "3029 Duck Creek Road Palo Alto, CA 94306",
                        StartDate = new DateTime(2020, 1, 1),
                        TerminationDate = null,
                        Manager = String.Empty
                    },
                    new Salesperson
                    {
                        Id = 2,
                        FirstName = "Jim",
                        LastName = "Mayfield",
                        Phone = "941-496-1012",
                        Address = "683 Medical Center Drive Venice, FL 34285",
                        StartDate = new DateTime(2021, 3, 9),
                        TerminationDate = null,
                        Manager = "Amanda Barber",
                    },
                    new Salesperson
                    {
                        Id = 3,
                        FirstName = "James",
                        LastName = "Lawson",
                        Phone = "214-454-1619",
                        Address = "2450 Poco Mas Drive Dallas, TX 75247",
                        StartDate = new DateTime(2021, 6, 8),
                        TerminationDate = new DateTime(2022, 2, 19),
                        Manager = "Amanda Barber",
                    });
        }
        #endregion
    }
}
