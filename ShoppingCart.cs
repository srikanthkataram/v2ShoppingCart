using System;
using System.Collections.Generic;

namespace v2ShoppingCart
{   
    public class ShoppingCart
    {
        // A list to hold the items in the cart
        private List<string> items;

        // A list to hold the prices of the items in the cart
        private List<double> prices;

        // A list to hold the quantities of the items in the cart
        private List<int> quantities;

        public ShoppingCart()
        {
            // Initialize the lists
            items = new List<string>();
            prices = new List<double>();
            quantities = new List<int>();
        }

        public ShoppingCart(List<string> items, List<double> prices, List<int> quantities)
        {
            // Set the fields to the given values
            this.items = items;
            this.prices = prices;
            this.quantities = quantities;
        }
        
        public void AddItem(string item, double price, int quantity)
        {
            // Add the item, price, and quantity to the lists
            items.Add(item);
            prices.Add(price);
            quantities.Add(quantity);
        }

        public double GetTotalCost()
        {
            // Initialize a variable to hold the total cost
            double totalCost = 0;

            // Loop through the items in the cart
            for (int i = 0; i < items.Count; i++)
            {
                // Add the cost of the item to the total cost
                totalCost += prices[i] * quantities[i];
            }

            // Return the total cost
            return totalCost;
        }

        public List<string> GetItems()
        {
            // Return the list of items
            return items;
        }

        public void RemoveItem(string item)
        {
            // Find the index of the item in the list
            int index = items.IndexOf(item);

            // If the item was found, remove it from the lists
            if (index != -1)
            {
                items.RemoveAt(index);
                prices.RemoveAt(index);
                quantities.RemoveAt(index);
            }
        }
    }
}
