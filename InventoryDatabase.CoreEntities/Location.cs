using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDatabase.CoreEntities
{
    public class Location
    {

        public int LocationID { get; set; }

        public string LocationName { get; set; } = string.Empty;

        public string LocationAddress { get; set; } = string.Empty;

        public List<Inventory> LocationInventories { get; set; } = new List<Inventory>();



    }
}
