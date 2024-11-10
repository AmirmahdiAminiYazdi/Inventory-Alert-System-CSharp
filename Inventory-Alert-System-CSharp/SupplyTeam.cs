namespace Inventory_Alert_System_CSharp
{
    // Subscriber class representing a Supply Team member who receives stock alerts
    public class SupplyTeam
    {
        // Method to handle stock low events for supply team
        public void OnStockLow(object sender, StockEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n[Supply Team Alert] 🔄 Restocking needed for '{e.ProductName}'. Current stock: {e.CurrentStock}. Please initiate the restocking process.");
            Console.ResetColor(); ;
        }
    }
}
