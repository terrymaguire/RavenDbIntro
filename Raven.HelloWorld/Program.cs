using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raven.Client.Document;
using Raven.Client;

namespace Raven.HelloWorld
{
    class Program
    {
        static IDocumentStore store;

        static void Main(string[] args)
        {

            store = new DocumentStore { Url = "http://iedubv5nb010818:8082" };
            store.Initialize();

            SetupConfigs2();

            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit...");
            Console.ReadLine();
        }

        private static void SetupConfigs()
        {
            var config = new Config();
            string[] statusList = { "Pending", "Active", "Cancelled" };

            config.Statuses = statusList;

            using (var session = store.OpenSession("ACSTestbed"))
            {
                session.Store(config, "Config/Statuses");
                session.SaveChanges();
            }
        }

        private static void SetupConfigs2()
        {
            var config = new Config();
            string[] categoryList = { "Cat1", "Cat2", "Cat3" };

            config.Category = categoryList;

            using (var session = store.OpenSession("ACSTestbed"))
            {
                session.Store(config, "Config/Categories");
                session.SaveChanges();
            }
        }


        private static void GetStatuses()
        {
            Config config;

            using (var session = store.OpenSession("ACSTestbed"))
            {
                config = session.Load<Config>("Config/Statuses");
            }

            foreach (var status in config.Statuses)
            {
                Console.WriteLine("{0}", status);
            }

        }

        private static void LoadOrder()
        {
            using (var session = store.OpenSession("ACSTestbed"))
            {

                var order = session.Load<Order>("orders/2049");

                System.Diagnostics.Debug.WriteLine(order.OrderLines.Count());

                //var product = new Product
                //{
                //    Cost = 1.59m,
                //    Name = "Apple Juice"
                //};

                //session.Store(product);
                //session.SaveChanges();


                //var orderLine = new OrderLine
                //        {
                //            Product = product,
                //            Quantity = 1
                //        };

                //var order = new Order
                //{
                //    Customer = "customers/terry",
                //};

                //order.OrderLines.Add(orderLine);
                ////order.AddOrderLine(orderLine);

                //session.Store(order);

                //session.SaveChanges();
            }

        }
    }
}
