using InventoryDatabase.CoreEntities;

namespace InventoryDatabase.UseCases.Inventories.Interfaces
{
    public interface IInventoriesAddUseCase
    {
        bool Execute(List<Inventory> list, Inventory inv);
    }
}