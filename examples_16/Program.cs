Console.Clear();
Console.Write("Введи первое целое число ");
string usernum1 = Console.ReadLine() ?? "";
int num1 = int.Parse(usernum1);
Console.Write("Введи второе целое число ");
string usernum2 = Console.ReadLine() ?? "";
int num2 = int.Parse(usernum2);

if (num1%num2 == 0)
Console.WriteLine(num1 +" является квадратом " + num2);
else 
if (num2%num1 == 0)
Console.WriteLine(num2 +" является квадратом " + num1);
else 
Console.WriteLine(num2 +" неявляется квадратом " + num1 + " также как и " + num1 + " неявляется квадратом " + num2);