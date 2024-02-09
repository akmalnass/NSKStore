using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using NSKStore.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NSKStore.Data;


namespace NSKStore.Controllers
{
    public class CartController : Controller
    {
        private readonly List<CartItem> _cartItem;
        private readonly NSKStoreContext _context;

        public CartController(NSKStoreContext context)
        {
            _cartItem = new List<CartItem>();
            _context = context;
        }

        public IActionResult Index()
        {
            return View("_CartPartial", _cartItem);
        }

        public IActionResult AddToCart(int productId, int quantity)
        {
            var product = _context.Products.Find(productId);

            if (product != null)
            {
                // Check if the product is already in the cart
                CartItem existingItem = _cartItem.FirstOrDefault(item => item.ProductId == productId);

                if (existingItem != null)
                {
                    // Update the quantity if the product is already in the cart
                    existingItem.Quantity += quantity;
                }
                else
                {
                    // Add a new item to the cart if the product is not in the cart
                    _cartItem.Add(new CartItem { ProductId = productId, Name = product.Name, Price = product.Price, Quantity = quantity });
                }

                // Redirect to the cart page after adding to the cart
                return Json(new { success = true, message = "Item added to the cart successfully." });

                }

                return Json(new { success = false, message = "Product not found." });
        }
    }
}
