using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDatabase.CoreEntities
{
    public class InventoryFilter
    {
        public string NameContains { get; set; } = string.Empty;
        public int MinimumQuantity { get; set; } = int.MinValue;
        public int MaximumQuantity { get; set; } = int.MaxValue;
        public double MinimumPrice { get; set; } = double.MinValue;
        public double MaximumPrice { get; set; } = double.MaxValue;

    }
}
