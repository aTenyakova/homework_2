// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondNumber = number % 100 / 10;
if (number > 99 && number < 1000)
{
    Console.WriteLine(secondNumber);
}
else Console.WriteLine($"Число {number} не является трехзначным");