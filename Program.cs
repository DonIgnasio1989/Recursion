//добавлены задачи на рекурсию
static void PrintNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m + " ");
        PrintNumbers(m + 1, n);
    }
}