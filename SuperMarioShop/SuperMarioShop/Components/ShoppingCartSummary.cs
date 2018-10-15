using Microsoft.AspNetCore.Mvc;
using SuperMarioShop.Data.Models;
using SuperMarioShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarioShop.Components
{
    // ViewComponent will display details about our ShoppingCart,
    // like the amount of the items that we have in our ShoppingCart
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        // It will automatically used each time our component is involked
        public IViewComponentResult Invoke()
        {
            // var items = new List<ShoppingCartItem>() { new ShoppingCartItem(), new ShoppingCartItem() };
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }
    }
}
