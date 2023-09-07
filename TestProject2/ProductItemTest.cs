using Entities.Entities;

namespace TestProject2
{
    [TestClass]
    public class ProductItemTest
    {
        [TestMethod]
        public void ProductItemConstructorGeneratesDataCorrectly()
        {
            var newProduct = new ProductItem();

            Assert.IsNotNull(newProduct.IdWeb);
            Assert.IsTrue(newProduct.IsActive);
            Assert.AreNotEqual(false, newProduct.IsPublic);
            Assert.IsTrue((DateTime.Now - newProduct.InsertDate).TotalSeconds < 1);
            Assert.AreEqual(newProduct.ProductBrand, "Sumama");
        }
    }

}
