using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication22
{
    class Program
    {
        class CArray
        {
            private int[] stuff;
            private int upperBound;
            private int numElements;
            public CArray(int size) //we define our own array
            {
                stuff = new int[size];
                upperBound = size - 1;
                numElements = 0;

            }
            
            public void insert(int item)
            {
                stuff[numElements] = item;
                numElements++;
            }
            
            public void display() //prints array
            {
                for (int i = 0; i <= upperBound; i++)
                    Console.Write(stuff[i] + " ");
                Console.ReadKey();

            }
            
            public void clear() //clears array
            {
                for (int i = 0; i <= upperBound; i++)
                    stuff[i] = 0;
                numElements = 0;

            }

            public void insertionSort() //sorting method
            {
                int inner, temp;

                for (int outer = 1; outer <= upperBound; outer++) //as 'outer' keeps increasing (and is below upper bound):
                {
                    display();
                    Console.WriteLine();
                    //^when program is run by Main method below, print each iteration so the user can see how the sort works^

                    temp = stuff[outer];
                    inner = outer;
                    while (inner > 0 && stuff[inner - 1] >= temp) //find lowest point in the list
                    {
                        stuff[inner] = stuff[inner - 1];
                        inner -= 1;
                        //^move stuff around and put each item in the proper location^
                    }

                    stuff[inner] = temp;
                }

            }
        }
        
        public void letsBeInsertive() // fucntions as the Main method
        {
            CArray nums = new CArray(15);
            Random rnd = new Random(50);
            for (int i = 0; i < 10; i++)

                //Insert a random integer from 0.0 to 50.0
                nums.insert((int)(rnd.NextDouble() * 50));

            Console.WriteLine("before sorting: ");
            nums.display();

            Console.WriteLine("during sorting: ");
            nums.insertionSort();

            Console.WriteLine("after sorting: ");
            nums.display();
        }
    }
}
