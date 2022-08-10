using InventoryDatabase.CoreEntities;
using InventoryDatabase.UseCases.Inventories.Interfaces;


namespace InventoryDatabase.UseCases.Inventories
{
    public class InventoriesFilterUseCase : IInventoriesFilterUseCase
    {
        public async Task<IEnumerable<Inventory>> ExecuteAsync(List<Inventory> inventories, InventoryFilter filter)
        {
                return await Task.FromResult(
                       inventories.Where(x => !(x.InventoryName.Contains(filter.NameContains, StringComparison.OrdinalIgnoreCase))
                                            | !(x.Quantity >= filter.MinimumQuantity)
                                            | !(x.Quantity <= filter.MaximumQuantity)
                                            | !(x.Price >= filter.MinimumPrice)
                                            | !(x.Price <= filter.MaximumPrice)
                                         )
                                            );
        }

    }
}

