Console.Write("Введите число: ");
int var = int.Parse(Console.ReadLine());
int second = var;

if (var < 100) Console.WriteLine("Третьей цифры нет");
else
{
    while (second > 999)
    {
        second = second / 10;
    }
    Console.Write($"Третьей цифрой числа {var} является цифра {second % 10}");
}