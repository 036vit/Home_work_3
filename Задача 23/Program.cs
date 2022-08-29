// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear ();
Console.Write ("Введите пятизначное число ");
int N = int.Parse (Console.ReadLine());
for (int number = 1; number <= N; number++)
{
    int cube = number*number*number;
    Console.WriteLine(cube);
}
