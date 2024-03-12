using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем значения M и N
        int M = 1;
        int N = 10;

        Console.WriteLine($"Натуральные числа от {M} до {N}:");
        PrintNaturalNumbers(M, N);
    }

    // Рекурсивная функция для вывода натуральных чисел от M до N
    static void PrintNaturalNumbers(int M, int N)
    {
        if (M <= N)
        {
            Console.WriteLine(M); // Выводим текущее число
            PrintNaturalNumbers(M + 1, N); // Рекурсивно вызываем функцию для следующего числа
        }
    }
}
