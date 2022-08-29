// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear ();
Console.Write ("Введите координаты точки А по оси x ");
int Ax = int.Parse (Console.ReadLine());
Console.Write ("Введите координаты точки А по оси y ");
int Ay = int.Parse (Console.ReadLine());
Console.Write ("Введите координаты точки А по оси z ");
int Az = int.Parse (Console.ReadLine());
Console.Write ("Введите координаты точки B по оси x ");
int Bx = int.Parse (Console.ReadLine());
Console.Write ("Введите координаты точки B по оси y ");
int By = int.Parse (Console.ReadLine());
Console.Write ("Введите координаты точки B по оси z ");
int Bz = int.Parse (Console.ReadLine());
int AB = ((Bx-Ax)*(Bx-Ax)+(By-Ay)*(By-Ay)+(Bz-Az)*(Bz-Az));
double lenght = Math.Sqrt(AB);
Console.WriteLine(lenght);