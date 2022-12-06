Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());
if (day > 5) Console.WriteLine("Это выходной");
else Console.WriteLine("Это рабочий день :(");