using Assignment_1_Web_Application_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_1_Web_Application_MVC.Data
{
    public class ItemsDbContext : DbContext
    {
        public ItemsDbContext(DbContextOptions<ItemsDbContext> options) : base(options) 
        {
        }

        public DbSet<Items> Items { get; set; }

        public DbSet<Sales> Sales { get; set; }
    }
}