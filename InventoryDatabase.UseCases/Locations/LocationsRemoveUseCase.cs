using InventoryDatabase.CoreEntities;
using InventoryDatabase.UseCases.Locations.Interfaces;


namespace InventoryDatabase.UseCases.Locations
{
    public class LocationsRemoveUseCase : ILocationsRemoveUseCase
    {
        public bool Execute(List<Location> list, Location loc)
        {
            return list.Remove(loc);
        }

    }
}
