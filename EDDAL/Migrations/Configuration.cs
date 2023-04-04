namespace EDDAL.Migrations
{
    using EDDAL.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EDDAL.EDTrackingServiceDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EDDAL.EDTrackingServiceDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            Area ares1 = new Area
            {
                Id = 1,
                Name = "Esbjerg",
                Zip = 6700
            };
            Area ares2 = new Area
            {
                Id = 2,
                Name = "Esbjerg N",
                Zip = 6715
            };
            Area ares3 = new Area
            {
                Id = 3,
                Name = "Esbjerg Ø",
                Zip = 6705
            };

            Employee e1 = new Employee
            {
                Id = 1,
                Name = "postman1",
                PhoneNum = 123456,
                Address = "postman address1"
            };
            Employee e2 = new Employee
            {
                Id = 2,
                Name = "postman2",
                PhoneNum = 223456,
                Address = "postman address2"
            };

            Parcel p1 = new Parcel
            {
                Id = 1,
                RecevierName = "recevier1",
                Weight = 2,
                Address = "recevier1 address",
                Status = Status.SORTING,
            };//"2018-02-11T00:11:50.6667513+00:00"
            Parcel p2 = new Parcel
            {
                Id = 2,
                RecevierName = "recevier1",
                Weight = 2,
                Address = "recevier1 address",
                Status = Status.DELIVERY,
            };
            Parcel p3 = new Parcel
            {
                Id = 3,
                RecevierName = "recevier2",
                Weight = 2,
                Address = "recevier2 address",
                Status = Status.WAIT_DELIVERY,
            };

            Sorting sort1 = new Sorting
            {
                Id=1,
                ParcelId = 3,
                AreaId = 1,
                EntryTime = new DateTime(2018, 01, 10, 08, 0, 0)//"2018-01-10 8:00:00"
            };
            Sorting sort2 = new Sorting
            {
                Id=1,
                ParcelId = 2,
                AreaId = 1,
                EntryTime = new DateTime(2018, 01, 10, 08, 0, 0),//"2018-01-10 8:00:00"
                OutTime = new DateTime(2018, 01, 11, 08, 0, 0)
            };
            Tracking tracking1 = new Tracking
            {
                Id = 1,
                ParcelId = 2,
                DeliveryId = 1,

            };
            Tracking tracking2 = new Tracking
            {
                Id=2,
                ParcelId = 2,
                DeliveryId = 1,

            };
            Delivery delivery1 = new Delivery()
            {
                Id = 1,
                EmployeeId = 1,
                getTime = new DateTime(2018, 01, 11, 9, 0, 0),
                CurrentTime = new DateTime(2018, 01, 11, 10, 0, 0),
                CurrrentLocation="delivery1 location1",
            };
            Delivery delivery2 = new Delivery()
            {
                Id = 1,
                EmployeeId = 1,
                getTime = new DateTime(2018, 01, 11, 9, 0, 0),
                CurrentTime = new DateTime(2018, 01, 11, 11, 0, 0),
                CurrrentLocation = "delivery1 location2",
            };


            context.Areas.Add(ares1);
            context.Areas.Add(ares2);
            context.Areas.Add(ares3);
            context.Employees.Add(e1);
            context.Employees.Add(e2);
            context.Parcels.Add(p1);
            context.Parcels.Add(p2);
            context.Parcels.Add(p3);
            context.Sorting.Add(sort1);
            context.Sorting.Add(sort2);
            context.Tracking.Add(tracking1);
            context.Tracking.Add(tracking2);
            context.Delivery.Add(delivery1);
            context.Delivery.Add(delivery2);

            base.Seed(context);

        }
    }

}
