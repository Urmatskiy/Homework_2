Console.Write("Введите трехзначное число: ");
int var = int.Parse(Console.ReadLine());
int second = var / 10;
int result = second % 10;
Console.Write($"{result} является второй цифрой числа {var}");