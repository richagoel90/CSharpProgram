using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MergeClass
    {
        public List<int> array { get; set; }
        
        public MergeClass()
        {
            array = new List<int>();
        }

        public void MergeSort(int start,int end)
        {
            if(end>start)
            {
                int mid = (start + end) / 2;
                MergeSort(start, mid);
                MergeSort(mid + 1, end);
                Merge(start, mid, end);
            }
            
        }
        public void Merge(int start,int mid,int end)
        {
           
            int leftsize = mid - start + 1;
            int rightsize = end - mid ;
            int i = 0, j = 0, k = start;

            List<int> left = new List<int>();
            List<int> right = new List<int>();
            for (i=0;i<leftsize;i++)
            {
                left.Add(array[start + i]);
            }
            for (i = 0; i < rightsize; i++)
            {
                right.Add(array[mid +1 + i]);
            }
            i = 0;
            while(i<leftsize && j<rightsize)
            {
                if(left[i]<=right[j])
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }
                k++;
            }
            while(i<leftsize)
            {
                array[k] = left[i];
                k++;
                i++;
            }
            while(j<rightsize)
            {
                array[k] = right[j];
                k++;
                j++;
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MergeClass merge = new MergeClass();
            Console.WriteLine("Enter the array elements press -1 to quit:");
            int number = int.Parse(Console.ReadLine());
            while(true)
            {
                if(number == -1)
                {
                    break;
                }
                merge.array.Add(number);
                number = int.Parse(Console.ReadLine());
            }
           
            int start = 0,end=(merge.array.Count-1);
            merge.MergeSort(start,end);
            Console.WriteLine();
            foreach (var num in merge.array)
            {
                Console.Write($"{num}->");
            }

        }
    }
}
