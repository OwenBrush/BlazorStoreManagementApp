using InventoryDatabase.CoreEntities;
using InventoryDatabase.UseCases.Inventories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDatabase.UseCases.Inventories
{
    public class InventoriesAddUseCase : IInventoriesAddUseCase
    {
        public bool Execute(List<Inventory> list, Inventory inv)
        {
            if (!list.Contains(inv))
            {
                string originName = inv.InventoryName;
                int i = 1;
                while(list.Where(x => x.InventoryName == inv.InventoryName).Any())
                {
                    i += 1;
                    inv.InventoryName = originName + $" ({i})";
                }
                list.Add(inv);
                return true;
            }
            return false;    
        }

    }
}
