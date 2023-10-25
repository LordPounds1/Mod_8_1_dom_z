using System;

namespace Mod_8_1_dom_z
{
    class Arr
    {
        int[] array;

        public Arr(int length)
        {
            array = new int[length];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = r.Next(-5, 6); // От -5 до 5
        }

        public int Length
        {
            get { return array.Length; }
        }

        public void Output()
        {
            foreach (int item in array)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Arr a1 = new Arr(10);
            Arr a2 = new Arr(20);
            Console.WriteLine("В массиве 1 " + a1.Length + " элементов.");
            Console.WriteLine("Массив 1:");
            a1.Output();
            Console.WriteLine("В массиве 2 " + a2.Length + " элементов.");
            Console.WriteLine("Массив 2:");
            a2.Output();
            Console.ReadLine();
        }
    }
}
