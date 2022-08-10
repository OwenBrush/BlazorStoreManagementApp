using InventoryDatabase.CoreEntities;
using InventoryDatabase.UseCases.Inventories.Interfaces;

namespace InventoryDatabase.UseCases.Inventories
{
    public class InventoriesRemoveUseCase : IInventoriesRemoveUseCase
    {
        public bool Execute(List<Inventory> list, Inventory inv)
        {
            return list.Remove(inv);
        }

    }
}
