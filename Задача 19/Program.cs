// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212->нет
// 12821->да
// 23432->да

Console.Clear ();
Console.Write ("Введите пятизначное число ");
int num = int.Parse (Console.ReadLine());
string str = Convert.ToString (num);
char[] arr = str.ToCharArray();
if (arr[0] == arr[4] && arr[1] == arr[3]) 
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}