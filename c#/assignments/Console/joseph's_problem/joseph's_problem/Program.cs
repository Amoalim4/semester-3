using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joseph_s_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sq = { 2, 4, 8, 16, 32, 64, 128 };

            int[] newlist = {0};

            // declaring  variable

            int max_number = 0;

            int number = 0;

            // asking the user's input 
            Console.WriteLine("Enter the number");

            number = int.Parse(Console.ReadLine());

            for (int i = 0; i < (sq.Length); i++)
            {
                if (sq[i] <= number)
                {
                    newlist[i] = sq[i];
                }
                max_number = newlist.Max();

                
            }
            int[] array = { 1, 5, 2, 7 };

    int maxIndex = Enumerable.Range(0, array.Length).Aggregate((max, i) => array[max] > array[i] ? max : i);
    int maxInt = array[maxIndex];

    Console.WriteLine("Maximum int {maxInt} is found at index {maxIndex}", maxInt, maxIndex);

            Console.WriteLine(max_number);

            Console.ReadKey();
        }
    }
}
