using System;
using System.Collections.Generic;
using System.Linq;
using EDDAL.Model;
using Moq.EntityFramework;
using NUnit.Framework;

namespace EDDAL.UnitTest
{
    [TestFixture]
    public class SortingTest
    {
        //[TestMethod]
        //public void getAllSorting()
        //{
        //    var data = new List<Sorting>
        //    {
        //        new Sorting{AreaId=1,ParcelId=1,DeliveryTime=new DateTime(2018, 01, 11, 08, 0, 0),EntryTime=new DateTime(2018, 01, 10, 08, 0, 0),WarehouseId=1 },
        //                        new Sorting{AreaId=2,ParcelId=2,DeliveryTime=new DateTime(2018, 01, 11, 08, 0, 0),EntryTime=new DateTime(2018, 01, 10, 08, 0, 0),WarehouseId=2 },
        //        new Sorting{AreaId=3,ParcelId=3,DeliveryTime=new DateTime(2018, 01, 11, 08, 0, 0),EntryTime=new DateTime(2018, 01, 10, 08, 0, 0),WarehouseId=3 },

        //    }.
        //}

        public DbContextMock<EDTrackingServiceDBContext> ContextMock { get; set; }

        private IEnumerable<Sorting> CreateSortings()
        {
            return Enumerable.Range(1, 100).Select(i => new Sorting { Id = i, AreaId = i, ParcelId = i, WarehouseId = i, EntryTime = DateTime.Now });
        }

        [SetUp]
        public void Setup()
        {
        //    ContextMock = DbContextMockFactory.Create<TestContext>().
        //        MockSetFor(CreateSortings().ToArray());
        }
    }
}
