//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Raven.HelloWorld.Infrastructure.rw
//{
//    class Program
//    {
//        private static void SetupConfigs()
//        {
//            var statusList = new Config<string>
//            {
//                //Id = "Config/Statuses",
//                Items = new List<string>
//                        {
//                            "Pending",
//                            "Active",
//                            "Cancelled"
//                        }
//            };

//            using (var session = store.OpenSession("ACSTestbed"))
//            {
//                session.Store(statusList, "Statuses");
//                session.SaveChanges();
//            }
//        }

//        private static void GetStatuses()
//        {
//            Config<string> statuses;

//            using (var session = store.OpenSession("ACSTestbed"))
//            {
//                statuses = session.Load<Config<string>>("Config/Statuses");
//            }

//            foreach (var status in statuses.Items)
//            {
//                Console.WriteLine("{0}", status);
//            }

//        }
//    }
//}
