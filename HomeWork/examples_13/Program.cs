// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что 3 цифры нет
Console.Clear();
int usernum;

while (true)
{
    Console.Write("Введи целое число ");
    if (int.TryParse(Console.ReadLine(), out usernum))
        break;
    Console.WriteLine("Ошибка ввода, попробуй еще раз");
}
int a = Math.Abs(usernum);
if (a / 10 < 10)
    Console.WriteLine($"в числе {usernum} нет третьего числа");

else
{
    if (a > 0)
    {
        while (a > 999)
        {
            a = a / 10;
        }
    }
    a = a % 10;

    Console.Write($"в твоём числе {usernum} третья цифра это {a}");
}
