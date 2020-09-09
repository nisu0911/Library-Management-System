using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entity
{
    public class BookDetails
    {
        public int BookID { get; set; }
        public string Author { get; set; }
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public byte[] Photo { get; set; }
        public string IsReference { get; set; }
        public string AddedDate { get; set; }
    }
}
