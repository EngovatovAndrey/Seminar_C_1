// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

using static System.Console;

WriteLine("Введите число -");
int n = int.Parse(ReadLine()!);
int count = -n;

while (count != n+1){
    WriteLine(count); 
    count++;
}


