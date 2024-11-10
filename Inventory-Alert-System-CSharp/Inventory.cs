using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Alert_System_CSharp
{
    // Publisher class representing an Inventory system
    public class Inventory
    {
        // Delegate declaration for the stock low event
        public delegate void StockLowEventHandler(object sender, StockEventArgs e);
        // Event declaration using the delegate
        public event StockLowEventHandler StockLow;

        // Properties of the Inventory class
        public string ProductName { get; }
        private int _stockLevel;

        // Constructor to initialize product details and starting stock level
        public Inventory(string productName, int initialStock)
        {
            ProductName = productName;
            _stockLevel = initialStock;
        }

        // Method to reduce stock and trigger an alert if the stock level is low
        public void ReduceStock(int amount)
        {
            _stockLevel -= amount;
            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine($"Product: {ProductName}");
            Console.WriteLine($"Stock Reduced by: {amount}");
            Console.WriteLine($"Current Stock Level: {_stockLevel}");
            Console.WriteLine("--------------------------------------------");

            // Trigger the StockLow event if stock level is at or below the threshold
            if (_stockLevel <= 5)
            {
                OnStockLow(new StockEventArgs(productName: ProductName, currentStock: _stockLevel));
            }





        }
        // Protected method to invoke the StockLow event with the current stock level information
        protected virtual void OnStockLow(StockEventArgs e)
        {
            StockLow?.Invoke(this, e);
        }
    }
   
    
   
}
