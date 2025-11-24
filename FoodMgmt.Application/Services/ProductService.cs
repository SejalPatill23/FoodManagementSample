using FoodMgmt.Domain.Entity;
using FoodMgmt.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMgmt.Application.Services
{
    public class ProductService
    {
        private readonly AppDBContext _appDBContext;
        public ProductService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        public List<Product> GetProduct()
        {
            var products = _appDBContext.Product.Include(p=>p.Brand).ToList();
            return products;
        }
    }
}
