using System;
namespace Lessons
{
    internal class Program
    {
        static int Find(int findNum, int[] myArray)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == findNum)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введiть скiльки елементiв буде в масивi : ");
                int Num = int.Parse(Console.ReadLine());
                int[] myArray = new int[Num];
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine("Введiть {0}-й елемент", i + 1);

                    myArray[i] = int.Parse(Console.ReadLine());
                }
                Console.Write("Наш мисив : ");
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write(myArray[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Введiть цифру якого iндекса хочете вивести : ");
                int findNum = int.Parse(Console.ReadLine());

                int b = Find(findNum, myArray);
                if (b >= 0)
                {
                    Console.WriteLine("Iндекс вказаного числа : " + b);
                }
                else
                {
                    Console.WriteLine("Не коректнi данi чи не правильно вказане число!!!");
                }
            }
            catch
            {
                Console.WriteLine("Не коректнi данi чи не правильно вказане число!!!");
            }
        }
    }
}