using FoodMgmt.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodMgmt.Application.Interfaces
{
    public interface IBrandService
    {
        List<Brand> GetBrands();
     
        int Create(Brand brand);
        Brand GetById(int brandId);
    }
}
