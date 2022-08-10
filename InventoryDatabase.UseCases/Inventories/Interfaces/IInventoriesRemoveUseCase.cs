using InventoryDatabase.CoreEntities;

namespace InventoryDatabase.UseCases.Inventories.Interfaces
{
    public interface IInventoriesRemoveUseCase
    {
        public bool Execute(List<Inventory> list, Inventory inv);
    }
}