using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PrettyHairBL;

namespace PrettyHairTests2
{
    [TestClass]
    public class PrettyHairTests
    {
       
        [TestMethod]
        public void CheckStock_GetProducts_ReturnListOfAllProducts()
        {
            //Arrange
            StockRepository2 stockRepository = new StockRepository2();
            List<Product> productsOnRepository = new List<Product>();
            productsOnRepository.Add(new Product());
            productsOnRepository.Add(new Product());
            stockRepository.Products = productsOnRepository;

            //Act
            List<Product> listOfProducts = stockRepository.GetProducts();

            //Assert
            CollectionAssert.AreEqual(listOfProducts, productsOnRepository);

        }
        [TestMethod]
        public void CheckStock_CheckStockForProductsMarkedUnsellable_ReturnOnlyProductsMarkedAsUnsellable()
        {
            StockRepository2 stockRepository = new StockRepository2();
            List<Product> productsOnRepository = new List<Product>();
            productsOnRepository.Add(new Product { Description = "Item1", Price= 10.0m, Unsellable = true });
            productsOnRepository.Add(new Product { Description = "Item1", Price = 10.0m, Unsellable = false });
            stockRepository.Products = productsOnRepository;

            List<Product> unsellables = stockRepository.GetUnsellableProducts();

            Assert.AreEqual(1, unsellables.Count);

        }
        [TestMethod]
        public void CheckStock_DeleteProducts_ProductListIsOneShorterThanBefore()
        {

        }
        [TestMethod]
        public void CheckStock_AdjustPriceOnProduct_PriceHasChanged()
        {

        }
        [TestMethod]
        public void CheckStock_AdjustDescriptionOnProduct_DescriptionHasChanged()
        {

        }
    }
}
