using static System.Console;

WriteLine("Введи цифру дня недели - ");
int day_nomber = int.Parse(ReadLine()!);

if (day_nomber == 1) WriteLine("Понедельник");
if (day_nomber == 2) WriteLine("Вторник");
if (day_nomber == 3) WriteLine("Среда");
if (day_nomber == 4) WriteLine("Четверг");
if (day_nomber == 5) WriteLine("Пятница");
if (day_nomber == 6) WriteLine("Суббота");
if (day_nomber == 7) WriteLine("Воскресение");