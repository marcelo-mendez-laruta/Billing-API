using BillingLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BillingLibrary
{
    public class BillingContext : DbContext
    {
        private object options;

        public DbSet<BillModel> Bills { get; set; }
        public DbSet<ClientModel> Clients { get; set; }
        public string DbPath { get; }
        public BillingContext()
        {
            var MyConfig = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            DbPath = MyConfig.GetSection("DbPath").Value!;
            var path = DbPath ?? "H:\\";
            DbPath = Path.Join(path, "billing.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var _utils= new Utils();
            modelBuilder.Entity<BillModel>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<ClientModel>().HasData(new ClientModel[] {
                new ClientModel{Id=1,Name="Joseph Carlton"},
                new ClientModel{Id=2,Name="Maria Juarez"},
                new ClientModel{Id=3,Name="Albert Kenny"},
                new ClientModel{Id=4,Name="Jessica Phillips"},
                new ClientModel{Id=5,Name="Charles Johnson"}
            });
            modelBuilder.Entity<BillModel>().HasData(new BillModel[] {
                new BillModel{Id=1,Period= 202001,Category= "SEWER",Amount= _utils.GetRandomAmount(),ClientId= 1 },
                new BillModel{Id=2,Period= 202002,Category= "SEWER",Amount= _utils.GetRandomAmount(),ClientId= 1 },
                new BillModel{Id=3,Period= 202001,Category= "ELECTRICITY",Amount= _utils.GetRandomAmount(),ClientId= 1 },
                new BillModel{Id=4,Period= 202002,Category= "ELECTRICITY",Amount= _utils.GetRandomAmount(),ClientId= 1 },
                new BillModel{Id=5,Period= 202001,Category= "WATER",Amount= _utils.GetRandomAmount(),ClientId= 1 },
                new BillModel{Id=6,Period= 202002,Category= "WATER",Amount= _utils.GetRandomAmount(),ClientId= 1 },
                new BillModel{Id=7,Period= 202001,Category= "SEWER",Amount= _utils.GetRandomAmount(),ClientId= 2 },
                new BillModel{Id=8,Period= 202002,Category= "SEWER",Amount= _utils.GetRandomAmount(),ClientId= 2 },
                new BillModel{Id=9,Period= 202001,Category= "ELECTRICITY",Amount= _utils.GetRandomAmount(),ClientId= 2 },
                new BillModel{Id=10,Period= 202002,Category= "ELECTRICITY",Amount= _utils.GetRandomAmount(),ClientId= 2 },
                new BillModel{Id=11,Period= 202001,Category= "WATER",Amount= _utils.GetRandomAmount(),ClientId= 2 },
                new BillModel{Id=12,Period= 202002,Category= "WATER",Amount= _utils.GetRandomAmount(),ClientId= 2 },
                new BillModel{Id=13,Period= 202001,Category= "SEWER",Amount= _utils.GetRandomAmount(),ClientId= 3 },
                new BillModel{Id=14,Period= 202002,Category= "SEWER",Amount= _utils.GetRandomAmount(),ClientId= 3 },
                new BillModel{Id=15,Period= 202001,Category= "ELECTRICITY",Amount= _utils.GetRandomAmount(),ClientId= 3 },
                new BillModel{Id=16,Period= 202002,Category= "ELECTRICITY",Amount= _utils.GetRandomAmount(),ClientId= 3 },
                new BillModel{Id=17,Period= 202001,Category= "WATER",Amount= _utils.GetRandomAmount(),ClientId= 3 },
                new BillModel{Id=18,Period= 202002,Category= "WATER",Amount= _utils.GetRandomAmount(),ClientId= 3 },
                new BillModel{Id=19,Period= 202001,Category= "SEWER",Amount= _utils.GetRandomAmount(),ClientId= 4 },
                new BillModel{Id=20,Period= 202002,Category= "SEWER",Amount= _utils.GetRandomAmount(),ClientId= 4 },
                new BillModel{Id=21,Period= 202001,Category= "ELECTRICITY",Amount= _utils.GetRandomAmount(),ClientId= 4 },
                new BillModel{Id=22,Period= 202002,Category= "ELECTRICITY",Amount= _utils.GetRandomAmount(),ClientId= 4 },
                new BillModel{Id=23,Period= 202001,Category= "WATER",Amount= _utils.GetRandomAmount(),ClientId= 4 },
                new BillModel{Id=24,Period= 202002,Category= "WATER",Amount= _utils.GetRandomAmount(),ClientId= 4 },
                new BillModel{Id=25,Period= 202001,Category= "SEWER",Amount= _utils.GetRandomAmount(),ClientId= 5 },
                new BillModel{Id=26,Period= 202002,Category= "SEWER",Amount= _utils.GetRandomAmount(),ClientId= 5 },
                new BillModel{Id=27,Period= 202001,Category= "ELECTRICITY",Amount= _utils.GetRandomAmount(),ClientId= 5 },
                new BillModel{Id=28,Period= 202002,Category= "ELECTRICITY",Amount= _utils.GetRandomAmount(),ClientId= 5 },
                new BillModel{Id=29,Period= 202001,Category= "WATER",Amount= _utils.GetRandomAmount(),ClientId= 5 },
                new BillModel{Id=30,Period= 202002,Category= "WATER",Amount= _utils.GetRandomAmount(),ClientId= 5 }
            });

        }
        
    }

}
