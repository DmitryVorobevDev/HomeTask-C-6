// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

void GetResult (double b1, double k1, double b2, double k2)
{
    double x = - (b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Пересечение двух прямых будет в точке {x}:{y}");
}

double GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (double.TryParse(valueFromConsole, out double number)) return number;
        else Console.WriteLine("Вы ввели не число. Нужно ввести число.");
    }
}

string Messageb1 = "Введите значение b1 : ";
string Messagek1 = "Введите значение k1 : ";
string Messageb2 = "Введите значение b2 : ";
string Messagek2 = "Введите значение k2 : ";

double b1 = GetNumber(Messageb1);
double k1 = GetNumber(Messagek1);
double b2 = GetNumber(Messageb2);
double k2 = GetNumber(Messagek2);

GetResult (b1, k1, b2, k2);