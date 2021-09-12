using Hjemlig2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hjemlig2._0.Interfaces
{
    public interface IProductRepo
    {
        List<Products> GetAllProducts();
        void CreateProduct(Products product);

        Products GetProduct(int id);
    }
}
