using InventoryDatabase.CoreEntities;
using InventoryDatabase.UseCases.Locations.Interfaces;

namespace InventoryDatabase.UseCases.Locations
{
    public class LocationsAddUseCase : ILocationsAddUseCase
    {
        public bool Execute(List<Location> list, Location loc)
        {
            if (!list.Contains(loc))
            {
                string originName = loc.LocationName;
                int i = 1;
                while (list.Where(x => x.LocationName == loc.LocationName).Any())
                {
                    i += 1;
                    loc.LocationName = originName + $" ({i})";
                }
                list.Add(loc);
                return true;
            }
            return false;
        }

    }
}
