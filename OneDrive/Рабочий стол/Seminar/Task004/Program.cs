// Вход - целое N, выход - {-N...N}

Console.WriteLine("Введите любое целое положительное число");

int number = Convert.ToInt32(Console.ReadLine());
int count = number;
Console.Write(number.ToString() + " ");
while(count > -number)
{
    number = number - 1;
    Console.Write(number.ToString() + " ");
}