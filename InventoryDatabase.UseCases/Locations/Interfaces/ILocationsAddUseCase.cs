using InventoryDatabase.CoreEntities;
namespace InventoryDatabase.UseCases.Locations.Interfaces
{
    public interface ILocationsAddUseCase
    {
        public bool Execute(List<Location> list, Location loc);
    }
}