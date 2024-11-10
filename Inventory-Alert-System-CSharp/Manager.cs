using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_Alert_System_CSharp;

namespace Inventory_Alert_System_CSharp
{
    // Subscriber class representing a Manager who receives stock alerts
    public class Manager
    {
        // Method to handle stock low events for managers
        public void OnStockLow(object sender, StockEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n[Manager Alert] 🚨 Attention! Stock of '{e.ProductName}' is critically low ({e.CurrentStock} units remaining). Immediate action recommended.");
            Console.ResetColor();
        }
    }
}
