using System;
using System.Collections.Generic;

namespace OrderManagementApp.Models
{
    public class Order
    {
        public int Id { get; set; }  
        public string CustomerName { get; set; }  
        public DateTime OrderDate { get; set; }  

        
        public List<OrderItem> OrderItems { get; set; }
    }
}

