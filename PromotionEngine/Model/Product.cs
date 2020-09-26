using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Model
{
    public class Product
    {
        public string OrderId { get; set; }
        public int Price { get; set; }

        public Product(string orderId)
        {
            this.OrderId = orderId;
            switch (OrderId.ToUpper())
            {
                case "A":
                    this.Price = 50;

                    break;
                case "B":
                    this.Price = 30;

                    break;
                case "C":
                    this.Price = 20;

                    break;
                case "D":
                    this.Price = 15;
                    break;
            }
        }
    }
}
