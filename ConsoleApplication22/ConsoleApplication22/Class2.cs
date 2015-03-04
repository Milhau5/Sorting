using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication22
{
    class SortApp
    {
        /*static Class1 bubbles;
        static Program insert;

        public SortApp()
        {
            bubbles = new Class1();
            insert = new Program();
        }*/

        static int choice;

        public static void Main(string[] args)
        {
            Class1 bubbles;
            Program insert;

            bubbles = new Class1();
            insert = new Program();
            
            Console.WriteLine("Today class we will learn about sorting stuff.");
            Console.WriteLine("Click 1 for example of insert sort, 2 for example of bubble sort.");
            Console.WriteLine("NOTE: If you pick '1', keep pressing a key until all steps are complete.");

            choice = int.Parse(Console.ReadLine().ToString());

            switch (choice)
            {
                case 1:
                    insert.letsBeInsertive();
                    break;
                case 2:
                    bubbles.startSorting();
                    break;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    choice = int.Parse(Console.ReadLine().ToString());
                    break;

            }
        }
    }
}
