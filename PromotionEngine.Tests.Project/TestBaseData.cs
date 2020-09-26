using PromotionEngine.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Tests.Project
{
    public class TestBaseData
    {
        public static List<Product> ScenarioAProducts()
        {
            return new List<Product>
            {
                new Product("A")
                {
                    OrderId="A", Price=50
                },
                new Product("B")
                {
                    OrderId="B", Price=30
                },
                new Product("C")
                {
                    OrderId="C", Price=20
                }
            };
        }

        public static List<Product> ScenarioBProducts()
        {
            return new List<Product>
            {
                new Product("A")
                {
                    OrderId="A", Price=50
                },
                new Product("A")
                {
                    OrderId="A", Price=50
                },
                new Product("A")
                {
                    OrderId="A", Price=50
                },
                new Product("A")
                {
                    OrderId="A", Price=50
                },
                new Product("A")
                {
                    OrderId="A", Price=50
                },
                new Product("B")
                {
                    OrderId="B", Price=30
                }, new Product("B")
                {
                    OrderId="B", Price=30
                }, new Product("B")
                {
                    OrderId="B", Price=30
                }, new Product("B")
                {
                    OrderId="B", Price=30
                }, new Product("B")
                {
                    OrderId="B", Price=30
                }, 
                new Product("C")
                {
                    OrderId="C", Price=20
                }
            };
        }

        public static List<Product> ScenarioCProducts()
        {
            return new List<Product>
            {
                new Product("A")
                {
                    OrderId="A", Price=50
                },new Product("A")
                {
                    OrderId="A", Price=50
                },new Product("A")
                {
                    OrderId="A", Price=50
                },
                new Product("B")
                {
                    OrderId="B", Price=30
                },new Product("B")
                {
                    OrderId="B", Price=30
                },new Product("B")
                {
                    OrderId="B", Price=30
                },new Product("B")
                {
                    OrderId="B", Price=30
                },new Product("B")
                {
                    OrderId="B", Price=30
                },
                new Product("C")
                {
                    OrderId="C", Price=20
                },
                new Product("D")
                {
                    OrderId="D", Price=15
                }
            };
        }
    }
}
