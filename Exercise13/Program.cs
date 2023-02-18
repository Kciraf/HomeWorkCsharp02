// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

System.Console.Write("Введите число: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

bool StopFlag = false;
int result = -1;    // если нет перезаписи, то ошибочный результат в виде "-1"

if(num >= 100)
{
    while(StopFlag == false)
    {
        if(num < 1000)
        {
            result = num % 10;
            StopFlag = true;
        }
        else
        {
            num = num / 10;
        }
    }
    System.Console.WriteLine("Третьей цифрой введенного числа является: " + result);
}
else
{
    System.Console.WriteLine("Введенное число не является трехзначным, третьей цифры у него нет.");
}

