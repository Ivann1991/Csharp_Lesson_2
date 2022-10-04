Console.Clear();
Console.Write("Введи первое целое число ");
string usernum1 = Console.ReadLine() ?? "";
int num1 = int.Parse(usernum1);
Console.Write("Введи второе целое число ");
string usernum2 = Console.ReadLine() ?? "";
int num2 = int.Parse(usernum2);
if (num2 > num1)
{
    if (num2 % num1 == 0)
        Console.WriteLine(num2 + " кратно " + num1);
    if (num2 % num1 != 0)
        Console.WriteLine(num2 + " некратно " + num1 + ", остаток = " + num2 % num1);

}
else 
{
    Console.Write (num2 + " некратно " + num1);
}