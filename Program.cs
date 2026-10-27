using System;

class Program
{
    static void Main()
    {
        // Питання до користувача
        Console.Write("Введіть натуральне число (більше 1): ");
        if (!int.TryParse(Console.ReadLine(), out int number) || number <= 1)
        {
            Console.WriteLine("Некоректне введення. Потрібно вказати ціле число, більше 1.");
            return;
        }

        // Рівень А
        int checkedDivisorsCount = 0;
        int firstDivisor = 0;
        bool isPrime = true;

        for (int d = 2; d * d <= number; d++)
        {
            checkedDivisorsCount++;
            if (number % d == 0)
            {
                isPrime = false;
                firstDivisor = d;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"Число {number} є простим.");
            Console.WriteLine($"Кількість перевірених дільників: {checkedDivisorsCount}");
        }
        else
        {
            Console.WriteLine($"Число {number} є складеним.");
            Console.WriteLine($"Перший знайдений дільник: {firstDivisor}");
            Console.WriteLine($"Кількість перевірених дільників: {checkedDivisorsCount}");
        }

        // Рівень Б
        Console.WriteLine();
        Console.Write("Введіть розмір квадрата n (від 3 до 20): ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 3 && n <= 20)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i + j == n - 1)
                    {
                        Console.Write('#');
                    }
                    else if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Некоректний розмір для Рівня Б.");
        }
    }
}