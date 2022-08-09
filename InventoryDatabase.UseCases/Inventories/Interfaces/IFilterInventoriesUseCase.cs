using InventoryDatabase.CoreEntities;

namespace InventoryDatabase.UseCases.Inventories
{
    public interface IFilterInventoriesUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(List<Inventory> inventories, InventoryFilter filter);
    }
}