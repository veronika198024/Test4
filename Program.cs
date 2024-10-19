// Вывод натуральных чисел в промежутке от M до N
int M = 1; // Можно поменять значение для проверки
int N = 5; // Можно поменять значение для проверки

Console.WriteLine("Числа в промежутке:");
PrintRange(M, N);
static void PrintRange(int M, int N)
{
    if (M > N) return; // Базовый случай: если M больше N,прекращаем рекурсию

    Console.Write(M);
    if (M < N) Console.Write(", ");
    PrintRange(M + 1, N);
}

//Функция Аккермана
int m = 2; // Можно поменять значение для проверки
int n = 3; // Можно поменять значение для проверки
int result = Ackermann(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");
static int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else if (m > 0 && n > 0)
        return Ackermann(m - 1, Ackermann(m, n - 1));
    return 0; // Для случая, если входные данные неверные
}

//Вывод элементов массива в обратном порядке
int[] array = { 1, 2, 3, 4, 5 }; // Можно поменять значение для проверки

Console.WriteLine("Массив в обратном порядке:");
PrintArrayReverse(array, array.Length - 1);
static void PrintArrayReverse(int[] array, int index)
{
    if (index < 0) return; // Базовый случай: если индекс меньше 0,прекращаем рекурсию
    Console.Write(array[index]);
    if (index > 0) Console.Write(", ");
    PrintArrayReverse(array, index - 1);
}
