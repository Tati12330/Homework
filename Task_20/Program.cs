// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату X первой точки: ");
double X1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Y первой точки: ");
double Y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Z первой точки: ");
double Z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки: ");
double X2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Y второй точки: ");
double Y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату Z второй точки: ");
double Z2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt((X1-X2)*(X1-X2)+(Y1-Y2)*(Y1-Y2)+(Z1-Z2)*(Z1-Z2));

Console.WriteLine( "Расстояние между двумя данными точками равно " + distance);