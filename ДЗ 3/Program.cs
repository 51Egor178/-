using System;

class Program
{
    static void Main()
    {
        // Произвольный массив
        int[] myArray = { 1, 2, 3, 4, 5 };

        // Вывод элементов массива, начиная с конца, с использованием рекурсии
        PrintArrayReverse(myArray, myArray.Length - 1);

        Console.ReadLine();
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        // Базовый случай: если индекс меньше 0, выходим из рекурсии
        if (index < 0)
            return;

        // Выводим текущий элемент массива
        Console.Write(array[index] + " ");

        // Рекурсивный вызов для следующего элемента с уменьшением индекса
        PrintArrayReverse(array, index - 1);
    }
}

