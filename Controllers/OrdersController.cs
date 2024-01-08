using Microsoft.AspNetCore.Mvc;
using ProductStore.Models;
using ProductStore.Work.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStore.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly ProductManager _productManager;
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
