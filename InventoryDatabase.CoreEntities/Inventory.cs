namespace InventoryDatabase.CoreEntities
{
    public class Inventory
    {
        public string InventoryName { get; set; } = "Name";
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int InventoryID { get; set; }

        public Inventory(string inventoryName = "Name", int quantity=0, double price=0, int inventoryID = 0)
        {
            InventoryName = inventoryName;
            Quantity = quantity;
            Price = price;
            InventoryID = inventoryID;
        }

    }
}