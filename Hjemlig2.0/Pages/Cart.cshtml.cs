using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hjemlig2._0.Services;
using Hjemlig2._0.Models;
using Hjemlig2._0.Interfaces;

namespace Hjemlig2._0.Pages
{
    public class CartModel : PageModel
    {
        public IProductRepo productRepo { get; }
        public CartService cartService { get; }
        [BindProperty]
        public Products Product { get; set; }
        [BindProperty]
        public List<Products> ProductsInCart { get; set; }
        public CartModel(CartService _cartService, IProductRepo _productRepo)
        {
            cartService = _cartService;
            ProductsInCart = new List<Products>();
            productRepo = _productRepo;
        }

        public IActionResult OnGet(int id)
        {
            Products product = productRepo.GetProduct(id);
            cartService.AddProductToCart(product);
            ProductsInCart = cartService.GetCartProducts();
            return Page();
        }
        public IActionResult OnPostDelete(int id)
        {
            cartService.RemoveCartProduct(id);
            ProductsInCart = cartService.GetCartProducts();
            return Page();
        }
    }
}
