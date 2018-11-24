using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM_MVC_T1708M1.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public string UnitslnStock { get; set; }
        public string UnitsOnOrder { get; set; }
        public string ReorderLevel { get; set; }
        public string Discontinued { get; set; }

       
    }
}
