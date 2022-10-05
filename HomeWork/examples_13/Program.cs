// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что 3 цифры нет
int usernum;

while (true)
{
    Console.Write("Введи целое число ");
    if (int.TryParse(Console.ReadLine(), out usernum))
        break;
    Console.WriteLine("Ошибка ввода, попробуй еще раз");
}

if (usernum / 10 < 10)
{
    if (usernum / 10 > -10)
        Console.WriteLine($"в числе {usernum} нет третьего числа");
}

else
{
    int a = usernum;
    if (a > 0)
    {
        while (a > 999)
        {
            a = a / 10;
        }
    }
    if (a < 0)
    {
       while (a < -999)
        {
            a = a / 10;
        } 
    }

    a = a % 10;
    Console.Write($"в твоём числе {usernum} третья цифра это {a}");
}
