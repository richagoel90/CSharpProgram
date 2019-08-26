using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class QuickSortalgo
    {
        public List<int> array { get; set; }
        public QuickSortalgo()
        {
            array = new List<int>();
        }

        public void QuickSort(int start, int end)
        {
            if (start < end)
            {
                int position = partition(start, end);
                QuickSort(start, position - 1);
                QuickSort(position + 1, end);
            }
        }
        int partition(int start, int end)
        {
            int pivot = array[end];
            int i = start - 1;
            for (int j = start; j < end; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    array[i] ^= array[j];
                    array[j] ^= array[i];
                    array[i] ^= array[j];
                }
            }
            array[i + 1] ^= array[end];
            array[end] ^= array[i + 1];
            array[i + 1] ^= array[end];
            return i + 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                QuickSortalgo quick = new QuickSortalgo();
                Console.WriteLine("Enter the array elements and press -1 to quit");
                int number = int.Parse(Console.ReadLine());
                while(true)
                {
                    if(number==0-1)
                    {
                        break;
                    }

                    quick.array.Add(number);
                    number = int.Parse(Console.ReadLine());

                }
                int start = 0;
                int end = quick.array.Count - 1;
                quick.QuickSort(start,end);
                Console.WriteLine();
                foreach(var num in quick.array)
                {
                    Console.Write($"{num}->");
                }
        }
    }
}
