// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void GetResult (int count)
{
    
    string valueFromConsole = Console.ReadLine();
    if (int.TryParse(valueFromConsole, out int number))
    {
        if (number > 0)
        {
        count ++;
        GetResult (count);
        }
        else GetResult(count);
    }
    else Console.WriteLine("Количество положительных чисел введеных пользователем: " + count);
}

Console.WriteLine ("Введите числа, програма посчитает количество положительных чисел введеных вами.");
Console.WriteLine ("Введение любых иных значений (кроме числа) прекращает ввод");
GetResult(0);