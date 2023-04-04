using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EDDAL_API.Controllers;
using System.Collections.Generic;
using EDDAL.Model;
using EDDAL;

namespace EDDAL_API.Test
{
    [TestClass]
    public class TestSortingsController
    {
        DALFacade dal = new DALFacade();
        [TestMethod]
        public void testFacade()
        {
            DALFacade dal = new DALFacade();
            dal.getAllSortings();
            dal.getSingleSorting(1);
        }

        [TestMethod]
        public void GetAllSortings_ShouldReturnAllSortings()
        {
            var testSortings = GetTestSortings();

            var controller = new SortingsController();
            var result = controller.GetAllSortings(testSortings) as List<Sorting>;
            Assert.AreEqual(testSortings.Count, result.Count);
        }

        [TestMethod]
        public void GetSorting_ShouldReturnCorrectSorting()
        {
            var dalSorting = dal.addSorting(GetTestSingleSorting());
            //var testSorting=dal.getSingleSorting(1);
            
            var testSorting = GetTestSortings();
            Assert.AreEqual(testSorting, dalSorting);
        
           // var controller = new SortingsController();
           // var result=controller.GetSingleSorting(1) as 
        }

        public List<Sorting> GetTestSortings()
        {
            var testSortings = new List<Sorting>();
            testSortings.Add(new Sorting { Id = 1, AreaId = 1, ParcelId = 1, DeliveryTime = new DateTime(2018, 01, 11, 08, 0, 0), EntryTime = new DateTime(2018, 01, 10, 08, 0, 0), WarehouseId = 1 });
            testSortings.Add(new Sorting { Id = 2, AreaId = 2, ParcelId = 1, DeliveryTime = new DateTime(2018, 01, 11, 08, 0, 0), EntryTime = new DateTime(2018, 01, 10, 08, 0, 0), WarehouseId = 1 });
            return testSortings;
        }
        public Sorting GetTestSingleSorting()
        {
            var testSingleSorting= new Sorting { Id = 1, AreaId = 1, ParcelId = 1, DeliveryTime = new DateTime(2018, 01, 11, 08, 0, 0), EntryTime = new DateTime(2018, 01, 10, 08, 0, 0), WarehouseId = 1 };
            return testSingleSorting;
        }
    }
}
