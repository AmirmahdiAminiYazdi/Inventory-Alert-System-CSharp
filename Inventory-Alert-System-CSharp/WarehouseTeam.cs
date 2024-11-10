using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Alert_System_CSharp
{
    // Subscriber class representing a Warehouse Team member who receives stock alerts
    public class WarehouseTeam
    {
        // Method to handle stock low events for warehouse team
        public void OnStockLow(object sender, StockEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n[Warehouse Team Alert] ⚠️ Low stock alert for '{e.ProductName}'. Current stock level: {e.CurrentStock}. Please check inventory and prepare for restocking.");
            Console.ResetColor();
        }
    }
}
