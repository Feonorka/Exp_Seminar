Console.WriteLine("Введите трехзначное число");
int Num = Convert.ToInt32(Console.ReadLine());
int res = Num % 10;
Console.Write($"Последняя цифра числа {Num} это {res}");