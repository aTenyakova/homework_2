// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 6)
{
    Console.WriteLine("Этот день не является выходным");
}
else if (number > 7)
{
    Console.WriteLine("Неверное число");
}
else Console.WriteLine("Этот день является выходным");