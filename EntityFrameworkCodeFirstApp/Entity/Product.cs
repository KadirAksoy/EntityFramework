using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstApp.Entity
{
    public class Product
    {
        [Key] 
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public String ProductBrand { get; set; }
        public String ProductCategory { get; set; }
        public int ProductStok { get; set; }
        public Category Category { get; set; }
    }
}
