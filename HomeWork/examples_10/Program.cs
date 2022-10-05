// Напишите программу, которая на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа

int usernum;

while (true)
{
    Console.Write("Введи трехзначное число ");
    if (int.TryParse(Console.ReadLine(), out usernum))
        if (1 <= usernum / 100)
            if (usernum / 100 < 10)
                break;
    Console.WriteLine("Попробуй еще раз, у тебя получится");
    
}
int a = usernum /10;
int b = a%10;
Console.WriteLine($"ты ввел {usernum} и второе число в нем - это {b}");
