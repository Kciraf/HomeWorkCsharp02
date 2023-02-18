// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите трехзаначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num>99 && num < 1000)
{
    int result = (num / 10) % 10;
    System.Console.WriteLine("Вторая цифра приведенного числа: " + result);
}
else
{
    System.Console.WriteLine("Введенное число не является трехзначным!");
}