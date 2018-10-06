using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperMarioShop.Data.interfaces;
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

        public ViewResult List()
        {
            ViewBag.Name = "DotNet, How?";
            // var products = _productRepository.Products;
            ProductListViewModel viewModel = new ProductListViewModel();
            viewModel.Products = _productRepository.Products;
            viewModel.CurrentCategory = "ProductCategory";
            // return View(products);
            return View(viewModel);
        }
    }
}
