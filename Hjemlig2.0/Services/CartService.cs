using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hjemlig2._0.Models;

namespace Hjemlig2._0.Services
{
    public class CartService
    {
        public List<Products> _cartProducts;
        public CartService()
        {
            _cartProducts = new List<Products>();
        }

        public void AddProductToCart(Products prod)
        {
            _cartProducts.Add(prod);
        }

        public List<Products> GetCartProducts()
        {
            return _cartProducts;
        }

        public void RemoveCartProduct(int id)
        {
            foreach (var product in _cartProducts)
            {
                if (product.Id == id)
                {
                    _cartProducts.Remove(product);
                    break;
                }
            }
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0.00M;

            foreach (var product in _cartProducts)
            {
                totalPrice += (decimal)product.Price;
            }
            return totalPrice;
        }
    }
}