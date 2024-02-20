using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrocerySys_DAL.Models
{
    public class getCartModel
    {
        public int CartID { get; set; }
        public string UserName { get; set; }
        public string UserAddress { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Total { get; set; }
    }
}