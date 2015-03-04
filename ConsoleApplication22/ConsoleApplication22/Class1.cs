using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication22
{
    class Class1
    {
        static int[] stuff = { 800, 11, 50, 771, 649, 770, 240, 9, 1, 99, 432, 111, 332, 90, 5 };
        
        public static void bubbleBuddy()
        {

            int spot = 0;

            for (int write = 0; write < stuff.Length; write++)
            {
                for (int sort = 0; sort < stuff.Length - 1; sort++)
                {
                    if (stuff[sort] > stuff[sort + 1]) //comparing adjacent items in the list.
                    {
                        spot = stuff[sort + 1]; //spot becomes the next number after index [sort]
                        stuff[sort + 1] = stuff[sort]; 
                        stuff[sort] = spot; //As it goes down the list, swap items if they are not in order
                    }
                }
            }

            //print each item in list after the sort alogrithm has been completed
            for (int i = 0; i < stuff.Length; i++) Console.Write(stuff[i] + " ");

            Console.ReadKey();
        }

        public void startSorting() //this class's main method
        {
            //print out initial array before sorting
            for (int x = 0; x < stuff.Length; x++)
                Console.Write(stuff[x] + " ");
            //
            Console.WriteLine("Now here's what it looks like after a bubble sort:");
            bubbleBuddy();
        }
    }
}
