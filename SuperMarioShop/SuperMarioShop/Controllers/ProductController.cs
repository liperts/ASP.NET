using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperMarioShop.Data.interfaces;
using SuperMarioShop.Data.Models;
using SuperMarioShop.ViewModels;

namespace SuperMarioShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;

        public ProductController(ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        //public ViewResult List()
        //{
        //    ViewBag.Name = "DotNet, How?";
        //    // var products = _productRepository.Products;
        //    ProductListViewModel viewModel = new ProductListViewModel();
        //    viewModel.Products = _productRepository.Products;
        //    viewModel.CurrentCategory = "ProductCategory";
        //    // return View(products);
        //    return View(viewModel);
        //}

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Product> products;

            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.Products.OrderBy(p => p.ProductId);
                currentCategory = "All products";
            }
            else
            {
                if (string.Equals("Mug", _category, StringComparison.OrdinalIgnoreCase))
                {
                    products = _productRepository.Products.Where(p => p.Category.CategoryName.Equals("Mug")).OrderBy(p => p.Name);
                }
                else
                    products = _productRepository.Products.Where(p => p.Category.CategoryName.Equals("T-Shirt")).OrderBy(p => p.Name);

                currentCategory = _category;
            }

            return View (new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }
    }
}
