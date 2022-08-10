using InventoryDatabase.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDatabase.UseCases.PluginInterfaces
{
    public interface ILocationRepository
    {
        List<Location> GetLocations();
        Task<Location> GetLocationByIndexAsync(int index);

        event EventHandler<EventArgs> OnChanged;
        void NotifyChanged();
    }



}
