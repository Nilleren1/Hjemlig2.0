using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hjemlig2._0.Models;
using Hjemlig2._0.Interfaces;

namespace Hjemlig2._0.Pages
{
    public class ProductsModel : PageModel
    {
        IProductRepo repo;
        public List<Products> Products { get; private set; }
        [BindProperty]
        public Products Product { get; set; }
        public ProductsModel(IProductRepo repository)
        {
            repo = repository;
        }
        public IActionResult OnGet()
        {
            Products = repo.GetAllProducts();
            return Page();
        }
        public IActionResult OnPost() {
            if (ModelState.IsValid) {
                repo.CreateProduct(Product);
            }
            return Page();
        }
    }
}
