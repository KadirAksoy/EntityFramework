using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstApp.Entity
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public String CustomerName { get; set; }
        public String CustomerSurname { get; set; }
        public String CustomerAddress { get; set; }

    }
}
