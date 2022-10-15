void Zadacha64()
{
    //Задача 64: Задайте значения M и N.
    //Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

    Console.WriteLine("Введите M");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите N");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    FindNumbers(m, n);
}

void FindNumbers(int m, int n)
{
    if (m > n)
        return;
    if (m % 3 == 0)
        Console.WriteLine(m);
    m++;
    FindNumbers(m, n);
}

void Zadacha66()
{
    //Задача 66: Задайте значения M и N.
    //Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    Console.WriteLine("Введите M");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите N");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine(FindSumNumbers(m, n));
}

int FindSumNumbers(int m, int n, int sum = 0)
{
    if (m > n)
        return sum;
    sum = sum + m;
    m++;
    return FindSumNumbers(m, n, sum);
}

void Zadacha68()
{
    //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

    Console.WriteLine("Введите m");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите n");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (m < 0 || n < 0)
    Console.WriteLine("Ввведены отрицательные числа");
    else Console.WriteLine($"А({m}, {n}) = {Akkerman(m, n)}");
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else return (Akkerman(m - 1, Akkerman(m, n - 1)));
}

//Zadacha64();
//Zadacha66();
Zadacha68();
