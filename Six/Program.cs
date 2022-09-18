using System;
namespace Lessons
{
    internal class Program
    {
        static void foo(ref int[] myArray, int newSize)
        {
            int[] newArray = new int[newSize]; // создание нового масива для добавления елемента
            for (int i = 0; i < myArray.Length && i < newSize; i++) // цикл для копирования данных со старого масива в новый
                newArray[i] = myArray[i]; // копирование данных масива
            myArray = newArray; // измена ссылки масива
            for (int i = 0; i < newSize; i++) // Заполнения елементов массива если увеличение массива
            {
                if (newArray[i] >= i)
                {

                }
                else
                {
                    Console.WriteLine($"Введите {i}-й елемент");
                    newArray[i] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] myArray = new int[6]; // Создание массива 
            for (int i = 0; i < myArray.Length; i++) // Заполнение массива
            {
                myArray[i] = random.Next(100);
            }
            Console.Write("Введите размер нового массива : ");
            int newSize = int.Parse(Console.ReadLine()); // рaзмер нового масива 
            foo(ref myArray, newSize); // вызов метода 
            for (int i = 0; i < myArray.Length; i++) // вывод нашего масива
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadLine();
        }
    }
}