using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Abstraction
{
    public interface IProductService
    {
        int GetTotalPrice(List<Product> products);
    }
}
