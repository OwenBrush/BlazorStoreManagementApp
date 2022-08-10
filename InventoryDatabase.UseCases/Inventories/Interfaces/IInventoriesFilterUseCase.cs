using InventoryDatabase.CoreEntities;

namespace InventoryDatabase.UseCases.Inventories.Interfaces
{
    public interface IInventoriesFilterUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(List<Inventory> inventories, InventoryFilter filter);
    }
}