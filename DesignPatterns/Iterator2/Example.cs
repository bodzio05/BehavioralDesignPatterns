using System;

namespace DesignPatterns.Iterator2
{
    public static class Example
    {
        public static void Execute_Example()
        {
            // Build a collection
            Collection collection = new Collection();
            collection[0] = new Item("Item A");
            collection[1] = new Item("Item B");
            collection[2] = new Item("Item C");
            collection[3] = new Item("Item D");
            collection[4] = new Item("Item E");
            collection[5] = new Item("Item F");
            collection[6] = new Item("Item G");
            collection[7] = new Item("Item H");
            collection[8] = new Item("Item I");

            Iterator iterator = new Iterator(collection);
            iterator.Step = 2;
            Console.WriteLine("Iterating over collection:");
            for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();
        }
    }
}
