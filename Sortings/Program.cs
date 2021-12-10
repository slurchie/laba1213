using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Sortings;

namespace Sortings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] startGenerate = generate(30000);
            int[] array = new int[startGenerate.Length];
            Stopwatch watch = new Stopwatch();
            Array.Copy(startGenerate, array, startGenerate.Length);
            watch.Start();
            Sorting.BubbleSort(array);
            watch.Stop();
            Console.WriteLine($"Bubble sort: {watch.ElapsedMilliseconds} ms");
            watch.Reset();
            Array.Copy(startGenerate, array, startGenerate.Length);
            watch.Start();
            Sorting.CocktailShakerSort(array);
            watch.Stop();
            Console.WriteLine($"Cocktail sort: {watch.ElapsedMilliseconds} ms");
            watch.Reset();
            Array.Copy(startGenerate, array, startGenerate.Length);
            watch.Start();
            Sorting.SelectionSort(array);
            watch.Stop();
            Console.WriteLine($"Selection sort: {watch.ElapsedMilliseconds} ms");
            watch.Reset();
            Array.Copy(startGenerate, array, startGenerate.Length);
            watch.Start();
            Sorting.DoubleSelectionSort(array);
            watch.Stop();
            Console.WriteLine($"Double Selection sort: {watch.ElapsedMilliseconds} ms");
            watch.Reset();
            Array.Copy(startGenerate, array, startGenerate.Length);
            watch.Start();
            Sorting.InsertionSort(array);
            watch.Stop();
            Console.WriteLine($"Insertion sort: {watch.ElapsedMilliseconds} ms");
            watch.Reset();
            Array.Copy(startGenerate, array, startGenerate.Length);
            watch.Start();
            Sorting.CountingSort(array);
            watch.Stop();
            Console.WriteLine($"Counting sort: {watch.ElapsedMilliseconds} ms");
            watch.Reset();
            Array.Copy(startGenerate, array, startGenerate.Length);
            watch.Start();
            Sorting.RadixSort(array);
            watch.Stop();
            Console.WriteLine($"Radix sort: {watch.ElapsedMilliseconds} ms");
            watch.Reset();
            Array.Copy(startGenerate, array, startGenerate.Length);
            watch.Start();
            Sorting.QuickSort(array);
            watch.Stop();
            Console.WriteLine($"Quick sort: {watch.ElapsedMilliseconds} ms");
            watch.Reset();

            Console.ReadKey();
        }

        private static int[] generate(int length)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(-100000, 100000);
            }
            return array;
        }
    }

}
