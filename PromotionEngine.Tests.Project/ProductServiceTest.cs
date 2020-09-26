using Moq;
using NUnit.Framework;
using PromotionEngine.Abstraction;
using PromotionEngine.Implementation;
using PromotionEngine.Model;
using System.Collections.Generic;

namespace PromotionEngine.Tests.Project
{
    [TestFixture]
    public class ProductServiceTest
    {
        protected readonly Mock<IProductService> mockProductService;
        public ProductServiceTest()
        {
            mockProductService = new Mock<IProductService>(MockBehavior.Strict);
        }

        private ProductService CreateMockProductService()
        {
            return new ProductService();
        }

        [Test]
        public void ScenarioA()
        {
            //Arrange
            var underTest = CreateMockProductService();
            var testProducts = TestBaseData.ScenarioAProducts();
            //Act
            var actualResult = underTest.GetTotalPrice(testProducts);
            //Assert
            Assert.AreEqual(100, actualResult);
        }

        [Test]
        public void ScenarioB()
        {
            //Arrange
            var underTest = CreateMockProductService();
            var testProducts = TestBaseData.ScenarioBProducts();
            //Act
            var actualResult = underTest.GetTotalPrice(testProducts);
            //Assert
            Assert.AreEqual(370, actualResult);
        }

        [Test]
        public void ScenarioC()
        {
            //Arrange
            var underTest = CreateMockProductService();
            var testProducts = TestBaseData.ScenarioCProducts();
            //Act
            var actualResult = underTest.GetTotalPrice(testProducts);
            //Assert
            Assert.AreEqual(280, actualResult);
        }
    }
}