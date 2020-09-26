using PromotionEngine.Abstraction;
using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Implementation
{
    public class ProductService : IProductService
    {
        public int GetTotalPrice(List<Product> products)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 0;
            int CounterofC = 0;
            int priceofC = 0;
            int CounterofD = 0;
            int priceofD = 0;

            foreach (Product pr in products)
            {
                if (pr.OrderId.ToUpper() == "A")
                {
                    counterofA = counterofA + 1;
                    priceofA = pr.Price;
                }
                if (pr.OrderId.ToUpper() == "B")
                {
                    counterofB = counterofB + 1;
                    priceofB = pr.Price;
                }
                if (pr.OrderId.ToUpper() == "C")
                {
                    CounterofC = CounterofC + 1;
                    priceofC = pr.Price;
                }
                if (pr.OrderId.ToUpper() == "D")
                {
                    CounterofD = CounterofD + 1;
                    priceofD = pr.Price;
                }
            }
            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            int multiplierForCandD = (CounterofC <= CounterofD) ? CounterofC : CounterofD;
            int result = multiplierForCandD * 30;
            int number = CounterofC - CounterofD;
            if (number < 0)
            {
                CounterofC = 0;
                CounterofD = (-1) * number;
            }
            else
            {
                CounterofC = number;
                CounterofD = 0;
            }
            int totalPriceofC = (CounterofC * priceofC);
            int totalPriceofD = (CounterofD * priceofD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD + result;
        }
    }
}
