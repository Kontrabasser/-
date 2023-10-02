using System;
class Askold
{
    static void Main()
    {
        Console.WriteLine("введіть число");
        string input = Console.ReadLine();
        string[] inputNumbers = input.Split(' ');

        int negativeCount = 0;
int i = 0;

       while (inputNumbers.Length > i)
        {
            var inputNumber = inputNumbers [i] ;
            i ++;
            if (int.TryParse(inputNumber, out int parsedNumber) && parsedNumber < 0)
            {
                negativeCount++;
            }
        }

        Console.WriteLine("Кількість негативних чисел: " + negativeCount);
    }
}