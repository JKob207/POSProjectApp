﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSProject
{
    public class Customer_drink
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int Quantity { get; set; }
        public int customerOrderID { get; set; }
        public Customer_order customer_Order { get; set; }
        public int DrinkID { get; set; }
        public Drink Drinks { get; set; }

    }
}
