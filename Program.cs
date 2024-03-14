// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Задаем значения M и N
//         int M = 1;
//         int N = 5;

//         Console.WriteLine($"Натуральные числа от {M} до {N}:");
//         PrintNaturalNumbers(M, N);
//     }

//     // Рекурсивная функция для вывода натуральных чисел от M до N
//     static void PrintNaturalNumbers(int M, int N)
//     {
//         if (M <= N)
//         {
//             Console.WriteLine(M); // Выводим текущее число
//             PrintNaturalNumbers(M + 1, N); // Рекурсивно вызываем функцию для следующего числа
//         }
//     }
// }

// uusing System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Произвольный массив
//         int[] array = {1, 2, 5, 0, 10, 34 };

//         Console.WriteLine("Элементы массива, начиная с конца:");
//         PrintArrayReverse(array, array.Length - 1); // Вызов рекурсивной функции для вывода элементов массива
//     }

//     // Рекурсивная функция для вывода элементов массива, начиная с конца
//     static void PrintArrayReverse(int[] array, int index)
//     {
//         if (index >= 0)
//         {
//             Console.WriteLine(array[index]); // Выводим текущий элемент
//             PrintArrayReverse(array, index - 1); // Рекурсивно вызываем функцию для предыдущего индекса
//         }
//     }
// }

using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 3;
        int n = 2;

        Console.WriteLine($"A({m}, {n}) = {AckermannFunction(m, n)}");
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
        else
        {
            throw new ArgumentException("Значение m и n должны быть неотрицательными.");
        }
    }
}
