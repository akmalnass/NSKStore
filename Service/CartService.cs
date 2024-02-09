using System.Collections.Generic;
using System.Linq;
using NSKStore.Models;

namespace NSKStore.Services
{
    public class CartService
    {
        private List<CartItem> _cartItems;

        public CartService()
        {
            // Initialize the cart items list
            _cartItems = new List<CartItem>();
        }

        public void AddToCart(Products product, int quantity)
        {
            // Check if the product is already in the cart
            CartItem existingItem = _cartItems.FirstOrDefault(item => item.Product?.Id == product.Id);

            if (existingItem != null)
            {
                // Update the quantity if the product is already in the cart
                existingItem.Quantity += quantity;
            }
            else
            {
                // Add a new item to the cart if the product is not in the cart
                _cartItems.Add(new CartItem { Product = product, Quantity = quantity });
            }
        }

        public List<CartItem> GetCartItems()
        {
            return _cartItems;
        }

        // Other cart-related methods can be added here
    }

    public class CartItem
    {
        public Products? Product { get; set; }
        public int Quantity { get; set; }
    }
}
