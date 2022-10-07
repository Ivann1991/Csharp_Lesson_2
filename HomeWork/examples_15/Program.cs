// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли это день выходным

Console.Clear();
int usernum;

while (true)
{
    Console.WriteLine("Введи число от 1 до 7 ");
    if (int.TryParse(Console.ReadLine(), out usernum))
        break;
    Console.WriteLine("Ошибка ввода, попробуй еще раз");
}

if (usernum >= 1 && usernum <= 7)
{
    if (usernum == 1)
        Console.WriteLine($"Ты ввел число {usernum} - это понедельник");
    if (usernum == 2)
        Console.WriteLine($"Ты ввел число {usernum} - это вторник");
    if (usernum == 3)
        Console.WriteLine($"Ты ввел число {usernum} - это среда");    
    if (usernum == 4)
        Console.WriteLine($"Ты ввел число {usernum} - это четверг");   
    if (usernum == 5)
        Console.WriteLine($"Ты ввел число {usernum} - это пятница! ну почти выходной =)");
    if (usernum == 6)
        Console.WriteLine($"Ты ввел число {usernum} - УРАА СУББОТА!!! ВЫХОДНОЙ!"); 
    if (usernum == 7)
        Console.WriteLine($"Ты ввел число {usernum} - УРАА ВОСКРСЕНЬЕ!!! ВЫХОДНОЙ!!! но завтра на работу =( ");            
}
else
    Console.WriteLine($"Твоё число {usernum} не попадает в требуемый диапозон чисел ");


