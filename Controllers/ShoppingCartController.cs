using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace v2ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        // Create a new shopping cart with initial values
        private ShoppingCart cart = new ShoppingCart(new List<string> { "Apple", "Banana" }, new List<double> { 0.99, 0.59 }, new List<int> { 2, 3 });

        // Add an item to the cart
        [HttpPost("add")]
        public void AddItem(string item, double price, int quantity)
        {
            cart.AddItem(item, price, quantity);
        }

        // Get the total cost of the items in the cart
        [HttpGet("total")]
        public double GetTotalCost()
        {
            return cart.GetTotalCost();
        }

        // Get a list of all items in the cart
        [HttpGet("items")]
        public List<string> GetItems()
        {
            return cart.GetItems();
        }

        [HttpGet]
        public ShoppingCart GetCart()
        {
            return cart;
        }


        // Remove an item from the cart
        [HttpDelete("remove")]
        public void RemoveItem(string item)
        {
            cart.RemoveItem(item);
        }
    }
}
