/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("координаты 1 точки");
double[] A =  {Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};
Console.WriteLine("координаты 2 точки");
double[] B =  {Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};

double x = B[0] - A[0];
double y = B[1] - A[1];
double z = B[2] - A[2];

Console.WriteLine($"расстояние: {Math.Round(Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2) + Math.Pow(z,2)), 2),2}.");