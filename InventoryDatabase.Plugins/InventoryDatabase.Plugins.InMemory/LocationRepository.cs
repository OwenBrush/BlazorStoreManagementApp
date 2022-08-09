using InventoryDatabase.CoreEntities;
using InventoryDatabase.UseCases.PluginInterfaces;

namespace InventoryDatabase.Plugins.InMemory
{
    public class LocationRepository : ILocationRepository
    {
        private List<Location> locations = new List<Location>();

        public LocationRepository()
        {
            locations = new List<Location>()
            {
                new Location   {  
                                LocationID = 0,
                                LocationName = "Bike Store",
                                LocationAddress = "9000 Universe Dr. Toledo",
                                LocationInventories = new List<Inventory>
                                    {
                                    new Inventory { InventoryID = 1, InventoryName = "Bike Seat", Quantity = 10, Price = 2},
                                    new Inventory { InventoryID = 2, InventoryName = "Bike Body", Quantity = 10, Price = 15},
                                    new Inventory { InventoryID = 3, InventoryName = "Bike Wheels", Quantity = 20, Price = 8 },
                                    new Inventory { InventoryID = 4, InventoryName = "Bike Pedals", Quantity = 20, Price = 1 }
                                    }
                               },
                new Location   {
                                LocationID = 1,
                                LocationName = "Shoe Store",
                                LocationAddress = "383 Swampy Rd. Tadoussac",
                                LocationInventories = new List<Inventory>
                                    {
                                    new Inventory { InventoryID = 1, InventoryName = "Bike Shoes", Quantity = 7, Price = 258.98},
                                    new Inventory { InventoryID = 2, InventoryName = "Running Shoes", Quantity = 23, Price = 190.72},
                                    new Inventory { InventoryID = 3, InventoryName = "Hiking Boots", Quantity = 12, Price = 386.23 },
                                    new Inventory { InventoryID = 4, InventoryName = "Casual Shoes", Quantity = 11, Price = 250.42 },
                                    new Inventory { InventoryID = 4, InventoryName = "Rain Boots", Quantity = 30, Price = 90 },
                                    }
                               }
            };
        }

        public async Task<IEnumerable<Location>> GetLocationsAsync()
        {
            return  locations;
        }

        public async Task<Location> GetLocationByIDAsync(int id)
        {
           return locations[id];
        }
    }
}