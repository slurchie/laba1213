using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings
{
    class Sorting
    {  
           // Methods
            static private void Swap(ref int x, ref int y)
            {
                int t = x;
                x = y;
                y = t;
            }

            static private int FindMinIndex(int[] array, int start)
            {
                int minpos = start;
                for (int i = start; i < array.Length; i++)
                {
                    if (array[i] < array[minpos])
                    {
                        minpos = i;
                    }
                }
                return minpos;
            }

            static private void FindMaxMinIndex(int[] array, int start, out int minpos, out int maxpos)
            {
                minpos = start;
                maxpos = start;
                for (int i = start; i < array.Length - start; i++)
                {
                    if (array[i] < array[minpos])
                    {
                        minpos = i;
                    }
                    if (array[i] > array[maxpos])
                    {
                        maxpos = i;
                    }
                }
            }

            static private int Partition(int[] array, int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array[pivot], ref array[i]);
                    }
                }

                pivot++;
                Swap(ref array[pivot], ref array[maxIndex]);
                return pivot;
            }

            static private int[] QuickSort(int[] array, int minIndex, int maxIndex)
            {
                if (minIndex >= maxIndex)
                {
                    return array;
                }

                var pivotIndex = Partition(array, minIndex, maxIndex);
                QuickSort(array, minIndex, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, maxIndex);

                return array;
            }
           

            public static int[] QuickSort(int[] array) => QuickSort(array, 0, array.Length - 1);

            public static int[] BubbleSort(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            Swap(ref array[i], ref array[j]);
                        }
                    }
                }
                return array;
            }

            public static int[] CocktailShakerSort(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            Swap(ref array[i], ref array[j]);
                        }
                    }

                    for (int j = array.Length - 1 - i; j < 0; j--)
                    {
                        if (array[i] < array[j])
                        {
                            Swap(ref array[i], ref array[j]);
                        }
                    }
                }
                return array;
            }

            public static int[] SelectionSort(int[] array)
            {
                int minIndex = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    minIndex = FindMinIndex(array, i + 1);
                    if (array[i] > array[minIndex])
                    {
                        Swap(ref array[i], ref array[minIndex]);
                    }
                }
                return array;
            }

            public static int[] DoubleSelectionSort(int[] array)
            {
                int minIndex = 0, maxIndex = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    FindMaxMinIndex(array, i + 1, out minIndex, out maxIndex);
                    if (array[i] > array[minIndex])
                    {
                        Swap(ref array[i], ref array[minIndex]);
                    }
                    if (minIndex != maxIndex && array[array.Length - 1 - i] < array[maxIndex])
                    {
                        Swap(ref array[array.Length - 1 - i], ref array[maxIndex]);
                    }
                }
                return array;
            }

            public static int[] CountingSort(int[] array)
            {
                int min, max;
                int lastWrite = -1;
                FindMaxMinIndex(array, 0, out min, out max);
                min = array[min];
                max = array[max];
                int[] counts = new int[Math.Abs(max - min) + 1];
                foreach (int i in array)
                {
                    counts[i - min]++;
                }
                for (int i = 0; i < counts.Length; i++)
                {
                    if (counts[i] > 0)
                    {
                        for (int j = 0; j < counts[i]; j++)
                        {
                            lastWrite++;
                            array[lastWrite] = i + min;
                        }
                    }
                }
                return array;
            }

            public static int[] InsertionSort(int[] array)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j > 0; j--)
                    {
                        if (array[j - 1] > array[j])
                        {
                            Swap(ref array[j - 1], ref array[j]);
                        }
                    }
                }
                return array;
            }

            public static int[] RadixSort(int[] array)
            {
                int i, j;
                int[] tmp = new int[array.Length];
                for (int shift = 31; shift > -1; --shift)
                {
                    j = 0;
                    for (i = 0; i < array.Length; ++i)
                    {
                        bool move = (array[i] << shift) >= 0;
                        if (shift == 0 ? !move : move)
                            array[i - j] = array[i];
                        else
                            tmp[j++] = array[i];
                    }
                    Array.Copy(tmp, 0, array, array.Length - j, j);
                }
                return array;
            }
        }
    }



