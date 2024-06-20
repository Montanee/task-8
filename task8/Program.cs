using System;

class Program
{
    static void Main()
    {
        int numberOfDays = 5; // Задаем количество дней для примера

        int[] temperatures = new int[numberOfDays];
        int sum = 0;
        int maxTemp = int.MinValue;
        int minTemp = int.MaxValue;

        for (int i = 0; i < numberOfDays; i++)
        {
            Console.Write($"Введите температуру для дня {i + 1}: ");
            temperatures[i] = Convert.ToInt32(Console.ReadLine());
            sum += temperatures[i];

            if (temperatures[i] > maxTemp)
            {
                maxTemp = temperatures[i];
            }

            if (temperatures[i] < minTemp)
            {
                minTemp = temperatures[i];
            }
        }

        double averageTemp = (double)sum / numberOfDays;

        Console.WriteLine($"Средняя температура: {averageTemp}");
        Console.WriteLine($"Максимальная температура: {maxTemp}");
        Console.WriteLine($"Минимальная температура: {minTemp}");
    }
}
