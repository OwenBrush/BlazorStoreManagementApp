using InventoryDatabase.CoreEntities;

namespace InventoryDatabase.UseCases.Inventories
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
    }
}