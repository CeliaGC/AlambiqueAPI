using Entities.Entities;
using Logic.Logic;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace TestProject
{
    [TestClass]
    public class InsertProductItemTest
    {

        public readonly ProductLogic _productLogic;
        [TestMethod]

        public void InsertProductItem()
        {
            var ProductA = new ProductItem();
            var ProductList = new List<ProductItem>();
           
            ProductA.IdWeb = default;

            ProductList.Add(ProductA);


            Assert.IsNotNull(ProductA.IdWeb);
        }

    }


}