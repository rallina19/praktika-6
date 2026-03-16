using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika_6
{
    internal class Program
    {
        /*
       static void Swap(ref int aa, ref int bb) //1.1
       {
           Console.WriteLine($"После обмена: a = {bb}, b = {aa}");
       }

       static void Divide(int dividend, int divisor, out int quotient, out int remainder) //1.2
       {
           quotient = dividend / divisor;
           remainder = dividend % divisor;
           Console.WriteLine($"Частное: {quotient}, остаток: {remainder}");
       }
       */

        static void Main(string[] args)
        {
            /*
            //1.1
            Console.WriteLine("Введите первое число (a):");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число (b):");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"До обмена: a = {a}, b = {b}");
            Swap(ref a, ref b);

            //1.2
            Console.WriteLine("\nВведите делимое:");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите делитель:");
            int divisor = Convert.ToInt32(Console.ReadLine());
            Divide(dividend, divisor, out int quotient, out int remainder);
            */

            /*
            //2
            Console.WriteLine("Введите числа через пробел:");
            string[] nums = Console.ReadLine().Split(' ');
            int[] numbers = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                numbers[i] = int.Parse(nums[i]);
            }

            FindMinMax(out int min, out int max, numbers);
            Console.WriteLine($"Минимум: {min},Максимум: {max}");


            //Тестовый вызов с произвольным набором чисел
            Console.WriteLine("\nТестовый вариант: 3 7 2 9 1");
            FindMinMax(out min, out max, 3, 7, 2, 9, 1);
            Console.WriteLine($"Мин: {min}, Макс: {max}");
            */

            /*
            //3
            int[] array = new int[10];
            FillRandom(array, 1, 101);

            Console.WriteLine("Сгенерированный массив:");
            PrintArray(array);

            int EvenNum = CountEven(array);
            Console.WriteLine($"\nКоличество четных: {EvenNum}");

            Console.WriteLine("\nВведите дополнительные числа через запятую:");
            string[] newNums = Console.ReadLine().Split(',');
            int[] newNumbers = new int[newNums.Length];
            for (int i = 0; i < newNums.Length; i++)
            {
                newNumbers[i] = int.Parse(newNums[i]);
            }

            int newArray = array.Length;
            Array.Resize(ref array, newArray + newNumbers.Length);

            for (int i = 0; i < newNumbers.Length; i++)
            {
                array[newArray + i] = newNumbers[i];
            }

            Console.WriteLine("\nМассив после добавления:");
            PrintArray(array);

            int EvenNum1 = CountEven(array);
            Console.WriteLine($"\nКоличество четных: {EvenNum1}");
            */
        }

        /*
        //2
        static void FindMinMax(out int min, out int max, params int[] numbers)
        {
            if (numbers.Length == 0)
            {
                min = int.MinValue;
                max = int.MaxValue;
                Console.WriteLine("Ошибка! Вы не ввели числа через пробел.");
                return;
            }

            min = numbers[0]; max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min) min = numbers[i];
                if (numbers[i] > max) max = numbers[i];
            }

        }
        */


        /*
        //3
        static void FillRandom(int[] array, int min, int max)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(min, max);
            }
        }

        static int CountEven(int[] array, int index = 0)
        {
            //базовый случай
            if (index >= array.Length)
                return 0;
            //рекурсивный случай
            if (array[index] % 2 == 0)
            {
                return 1 + CountEven(array, index + 1);
            }
            else
            {
                return 0 + CountEven(array, index + 1);
            }
        }

        static void PrintArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                    Console.Write(", ");
            }
        }
        */
    }
}
