using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Alert_System_CSharp
{
    // Event arguments class to pass additional information to subscribers
    public class StockEventArgs : EventArgs
    {
        public string ProductName { get; }
        public int CurrentStock { get; }

        // Constructor to initialize product name and current stock level in event args
        public StockEventArgs(string productName, int currentStock)
        {
            ProductName = productName;
            CurrentStock = currentStock;
        }
    }

}
