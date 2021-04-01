using System;
using System.Linq;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = creatinArray();
            elementMaxTwo(v1);
        }

        static public int[] creatinArray()
        {
            Console.WriteLine("Укажите длину массива=");
            int Length = int.Parse(Console.ReadLine());

            int[] numbers = new int[Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Ведите элемент массива", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            return numbers;
        }



        static public void elementMaxTwo(int[] numbers)

        {
            int[] numbers2 = numbers.OrderByDescending(x => x).ToArray();
            Console.WriteLine("Второй максимальный элемент массива");
            Console.WriteLine(numbers2[1]);
           /* for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }*/
        }
    }
}
