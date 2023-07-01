// Задача 43.
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями.
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Input your b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your data is: b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}");

// y = k1 * x + b1, y = k2 * x + b2
// k1* x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// x * (k1 - k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1


void FindIntersectionPoint(double pointB1, double pointK1, double pointB2, double pointK2)
{
    double x = (pointB2 - pointB1) / (pointK1 - pointK2);
    double y = (pointK1 * x + pointB1);
    Console.WriteLine($"Your result is ({x}, {y})");
}

FindIntersectionPoint(b1, k1, b2, k2);