
// Main program to set up inventory system, subscribers, and simulate stock reduction
using Inventory_Alert_System_CSharp;

class program
{
    static void Main()
    {
        // Create a new inventory item with an initial stock level
        var productInventory = new Inventory("Laptop", 10);


        // Initialize subscribers for stock alerts
        var manager = new Manager();
        var warehousTeam = new WarehouseTeam();
        var supplyTeam = new SupplyTeam();

        // Subscribe the subscribers to the StockLow event

        productInventory.StockLow += manager.OnStockLow;
        productInventory.StockLow += warehousTeam.OnStockLow;
        productInventory.StockLow += supplyTeam.OnStockLow;

        // Simulate stock reduction to trigger alerts when stock is low
        productInventory.ReduceStock(3); // Current stock: 7
        productInventory.ReduceStock(2); // Current stock: 5 (Event triggered)
        productInventory.ReduceStock(1); // Current stock: 4

    }
}