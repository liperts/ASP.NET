using Microsoft.AspNetCore.Mvc;
using GamesForEveryone.Models;

namespace GamesForEveryone.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Checkout() => View(new Order());
    }
}
