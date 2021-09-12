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
    public class CreateProductModel : PageModel
    {
        public IProductRepo ProductRepo { get; }
        public List<Products> Products { get; set; }
        [BindProperty]
        public Products Product { get; set; }

        public CreateProductModel(IProductRepo _productRepo)
        {
                ProductRepo = _productRepo;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ProductRepo.CreateProduct(Product);
            return RedirectToPage("/Products");
        }
    }
}
