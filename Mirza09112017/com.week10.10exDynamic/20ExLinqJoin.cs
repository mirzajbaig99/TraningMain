namespace Mirza09112017.com.week10._10exDynamic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class ExLinqJoin
    {
        class Item
        {
            public string Name { get; set; }
            public int ItemNumber { get; set; }

            public Item(string n, int inum)
            {
                Name = n;
                ItemNumber = inum;
            }

        }

        class InStockStatus
        {
            public int ItemNumber { get; set; }
            public bool InStock { get; set; }

            public InStockStatus(int n, bool b)
            {
                ItemNumber = n;
                InStock = b;
            }

        }
        class Temp
        {
            public string Name { get; set; }
            public bool InStock { get; set; }

            public Temp(string n, bool b)
            {
                Name = n;
                InStock = b;
            }

        }
        class JoinDemo
        {
            static void Main()
            {
                Item[] items = {
             new Item("Pliers", 1424),
             new Item("Hammer", 7892),
             new Item("Wrench", 8534),
             new Item("Saw", 6411)
        };
                InStockStatus[] statusList = {
             new InStockStatus(1424, true),
             new InStockStatus(7892, false),
             new InStockStatus(8534, true),
             new InStockStatus(6411, true)
        };

                // Create a query that joins Item with InStockStatus to
                // produce a list of item names and availability. Notice
                // that a sequence of Temp objects is produced.
                var MethodItemInStock = items.Join(statusList
                                                    , i => i.ItemNumber
                                                    ,s => s.ItemNumber,(list1,list2) 
                                                    => new { list1.Name,list2.InStock});

                var ItemsInStock = from item in items
                                   let Number = item.ItemNumber
                                   join status in statusList
                                     on item.ItemNumber equals status.ItemNumber
                                    orderby status.InStock, Number
                                   select new { Name = Number, status.InStock };

                var inStockList = from item in items
                                  join entry in statusList
                                    on item.ItemNumber equals entry.ItemNumber
                                  select new Temp(item.Name, entry.InStock);

                Console.WriteLine("Item\tAvailable\n");

                // Execute the query and display the results.
                foreach (Temp t in inStockList)
                    Console.WriteLine("{0}\t{1}", t.Name, t.InStock);

                Console.WriteLine("----------------");
                // Create a query that joins Item with InStockStatus to
                // produce a list of item names and availability.
                // Now, an anonymous type is used.

                var inStockList2 = from item in items
                                   join entry in statusList
                                     on item.ItemNumber equals entry.ItemNumber
                                   select new { item.Name, entry.InStock };

                Console.WriteLine("Item\tAvailable\n");

                // Execute the query and display the results.
                foreach (var t in inStockList2)
                    Console.WriteLine("{0}\t{1}", t.Name, t.InStock);



            }
        }


}
}
