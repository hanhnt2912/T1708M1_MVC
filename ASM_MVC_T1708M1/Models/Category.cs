using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASM_MVC_T1708M1.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Daescription { get; set; }
        public string Picture { get; set; }

        public List<Product> Products { get; set; }
    }
}
