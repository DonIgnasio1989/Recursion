// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Задаем значения M и N
//         int M = 1;
//         int N = 10;

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

using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод значений m и n
        Console.Write("Введите число m: ");
        int m = ParseNonNegativeInt(Console.ReadLine());

        Console.Write("Введите число n: ");
        int n = ParseNonNegativeInt(Console.ReadLine());

        // Вычисление и вывод значения функции Аккермана
        Console.WriteLine($"Значение функции Аккермана для m = {m} и n = {n}: {AckermannFunction(m, n)}");
    }

    // Пользовательская функция для парсинга неотрицательного целого числа из строки
    static int ParseNonNegativeInt(string input)
    {
        int result;
        if (!int.TryParse(input, out result) || result < 0)
        {
            Console.WriteLine("Ошибка ввода. Введите неотрицательное целое число.");
            Environment.Exit(1);
        }
        return result;
    }

    // Рекурсивная функция для вычисления функции Аккермана
    static int AckermannFunction(int m, int n)
    {
        if (m == 1)
        {
            return n + 1;
        }
        else if (n == 1)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}


