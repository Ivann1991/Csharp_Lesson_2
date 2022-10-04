Console.Clear();
Console.Write("Введи целое число ");
string usernum = Console.ReadLine() ?? "";
int num = int.Parse(usernum);

int a1 = num%7;
int a2 = num%23;
if (a1+a2==0)
Console.WriteLine ("Ваше число " + num + ", одновременно кратно 7 и 23");
else
Console.Write ("Ваше число " + num + ", одновременно не кратно 7 и 23");