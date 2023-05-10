using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstApp.Entity
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public String CategoryName { get; set; }
        public ICollection<Product> Product { get; set; }

    }
}
