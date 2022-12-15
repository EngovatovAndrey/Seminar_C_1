using static System.Console;

WriteLine("Введите два числа");
int number1 = int.Parse(ReadLine()!);
int number2 = int.Parse(ReadLine()!);

if (number1 == number2*number2)
{
    WriteLine($"Число {number1} является квадратом числа {number2}");
} 
else 
{
    WriteLine($"Число {number1} не является квадратом числа {number2}");
} 
