using Hjemlig2._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hjemlig2._0.Models;
using Hjemlig2._0.Helpers;

namespace Hjemlig2._0.Services
{
    public class ProductRepo : IProductRepo
    {
        string JsonFileName = @"Data\jsonProducts.json";

        public List<Products> GetAllProducts()
        {
            return JsonFileReader.ReadJsonProducts(JsonFileName);
        }
        
        public void CreateProduct(Products product)
        {
            List<Products> products = GetAllProducts().ToList();
            products.Add(product);
            JsonFileWriter.WriteToJsonProducts(products, JsonFileName);
        }

        public Products GetProduct(int id)
        {
            foreach (var p in GetAllProducts())
            {
                if (p.Id == id)
                {
                    return p;
                }
            }
            return null;
        }

    }
}
