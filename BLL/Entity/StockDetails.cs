using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity
{
    public class StockDetails
    {
        public int StockID { get; set; }
        public Nullable<int> BookID { get; set; }
        public Nullable<int> Quantity { get; set; }
    }
}
