using InventoryDatabase.CoreEntities;
namespace InventoryDatabase.UseCases.Locations.Interfaces
{
    public interface ILocationsRemoveUseCase
    {
        public bool Execute(List<Location> list, Location loc);
    }
}