using InventoryDatabase.CoreEntities;
using InventoryDatabase.UseCases.Inventories;
using InventoryDatabase.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDatabase.UseCases.Inventories
{
    public class FilterInventoriesUseCase : IFilterInventoriesUseCase
    {
        public async Task<IEnumerable<Inventory>> ExecuteAsync(List<Inventory> inventories, InventoryFilter filter)
        {
                return await Task.FromResult(
                       inventories.Where(x => x.InventoryName.Contains(filter.NameContains, StringComparison.OrdinalIgnoreCase)
                                            & x.Quantity >= filter.MinimumQuantity
                                            & x.Quantity <= filter.MaximumQuantity
                                            & x.Price >= filter.MinimumPrice
                                            & x.Price <= filter.MaximumPrice)
                                                );
        }

    }
}

