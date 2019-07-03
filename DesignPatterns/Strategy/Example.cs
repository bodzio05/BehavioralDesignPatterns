using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public static class Example
    {
        public static void Execute_Example()
        {
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Konrad");
            studentRecords.Add("Marcin");
            studentRecords.Add("Mateusz");
            studentRecords.Add("Jakub");

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            // Wait for user
            Console.ReadKey();
        }
    }
}
