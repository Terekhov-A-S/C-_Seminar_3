// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
// Console.WriteLine("Привет! Я искусственный интеллект Core 2.0");
// Console.WriteLine("Введите координату x первой точки ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y первой точки ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z первой точки ");
// int za = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату x второй точки ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y второй точки ");
// int yb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z второй точки ");
// int zb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Расстояние между указанными точками равно {Convert.ToInt32(Math.Sqrt ((xa-xb)*(xa-xb)+(ya-yb)*(ya-yb)+(za-zb)*(za-zb)))} ");

Console.WriteLine("Привет! Я искусственный интеллект Core 2.0");
Console.WriteLine("Введите координату x первой точки ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки ");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки ");
double zb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Расстояние между указанными точками равно {Math.Round(Convert.ToDouble(Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb))), 2)} ");

