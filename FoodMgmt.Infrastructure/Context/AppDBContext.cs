using FoodMgmt.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMgmt.Infrastructure.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>option) : base(option) 
        {

        }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
