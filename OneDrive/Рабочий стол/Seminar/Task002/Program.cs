// Проверить, является ли первое число квадратом второго

Console.WriteLine ("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число 2");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b) Console.WriteLine("верно");
else Console.WriteLine("неверно");
