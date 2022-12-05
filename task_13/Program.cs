// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdNumber;
if (number > 99 && number < 1000)
{
    thirdNumber = number % 10;
    Console.WriteLine(thirdNumber);
}
else if (number > 999 && number < 10000)
{
    thirdNumber = number % 100 / 10;
    Console.WriteLine(thirdNumber);
}
else if (number > 9999 && number < 100000)
{
    thirdNumber = number % 1000 / 100;
    Console.WriteLine(thirdNumber);
}
else if (number > 99999 && number < 1000000)
{
    thirdNumber = number % 10000 / 1000;
    Console.WriteLine(thirdNumber);
}
else if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
// Честно, пока не понимаю, как сделать код универсальным для любого числа (без number.Length)