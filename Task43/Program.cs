// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// k1*x + b1 = k2*x + b2

double[] IntersectionPoint(double k1, double b1, double k2, double b2)
{
    double[] coord = new double[2];
    var x = -(b1 - b2) / (k1 - k2);
    var y = k1 * x + b1;
    coord[0] = x;
    coord[1] = y;
    return coord;
}

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());


double[] position = IntersectionPoint(k1, b1, k2, b2);
Console.WriteLine($"Точка пересечения: {position[0]}, {position[1]}");