using PromotionEngine.Abstraction;
using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class PromotionEngineApplication
    {
        private readonly IProductService _productService;
        public PromotionEngineApplication(IProductService productService)
        {
            _productService = productService;
        }
        public int Run()
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("Enter Total number of Orders..");
            int numberOfOrders = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfOrders; i++)
            {
                Console.WriteLine("Enter the type of product (SKU Ids):A,B,C or D");
                string skuType = Console.ReadLine();
                Product product = new Product(skuType);
                products.Add(product);
            }

            int totalPrice = GetTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
            return totalPrice;
        }

        public int GetTotalPrice(List<Product> products)
        {
            return _productService.GetTotalPrice(products: products);
        }
    }
}
