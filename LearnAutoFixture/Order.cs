﻿using System;
using System.Collections.Generic;

namespace LearnAutoFixture
{
    public class Order
    {
        public int Id { get; set; }

        public Customer Customer { get; set; }
        public List<OrderItem> Items { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(Customer customer)
        {
            Customer = customer;
            Items = new List<OrderItem>();
        }

    }

    public class OrderItem
    {
        public string ProductName { get; set; }

        public int Quantity { get; set; }
    }

    public class Customer
    {
        public string CustomerName { get; set; }
    }
}