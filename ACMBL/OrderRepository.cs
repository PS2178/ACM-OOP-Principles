﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ACMBL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            // Create the instance of the Order class
            var order = new Order(orderId);

            // Code that retrieves the defined order

            // Temporary hard coded values to return
            // a populated order
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.UtcNow);
            }
            return new Order();
        }

        public OrderDisplay RetrieveOrderDisplay()
        {
            var orderDisplay = new OrderDisplay();

            // Code that retrieves the defined order fields

            // Temporary hard coded data

            return orderDisplay;
        }

        /// <summary>
        /// Save the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined order
            return true;
        }
    }
}
