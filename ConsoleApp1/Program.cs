using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public int[] array = new int[10] { 5, 3, 7, 5, 8, 6, 9, 5, 2, 1 };

        static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();
        }

        public Program()
        {
            Display();
            SelectionSort();    
            Console.WriteLine();
            Display();

        }

        public void BubbleSort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void NBubbleSort()
        {
            bool sorted = false;
            for (int i = 0; (i < array.Length) && (!sorted);i++)
            {
                sorted = true;
                for (int j = 0; j < array.Length - 1 - i;j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        sorted = true;
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void SelectionSort()
        {
            int minPos;
            for (int i = 0; i < array.Length - 1;i++)
            {
                minPos = i;

                for (int j = i + 1; j < array.Length;j++)
                {
                    if (array[minPos] > array[j])
                    {
                        minPos = j;
                    }

                    int temp = array[i];
                    array[i] = array[minPos];
                    array[minPos] = temp;

                }
            }
        }

        public void InsertionSort()
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int move = i - 1;

                while (move >= 0 && array[move] > temp)
                {
                    array[move + 1] = array[move];

                }
                array[move + 1] = temp;
            }
        }

        public void Display()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                //Console.WriteLine();
            }
        }

        
    }
}
