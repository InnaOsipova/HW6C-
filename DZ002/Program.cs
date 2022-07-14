//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double SolutionEquationFirst (double argumentB1, double argumentK1, double argumentB2, double argumentK2)
{
    return ((argumentB2-argumentB1) / (argumentK1-argumentK2));

}

double SolutionEquationSecond (double firsrArgument, double argumentB, double argumentK)
{
    return argumentK * firsrArgument + argumentB;
}

Console.WriteLine("Введите переменные для уравнений y = k1 * x + b1, y = k2 * x + b2;");
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = SolutionEquationFirst(b1, k1, b2, k2);
double y = SolutionEquationSecond(x, b1, k1);

Console.WriteLine($"Точка пересечения двух прямых с заданными коэффициентами ( {x} ; {y} )");