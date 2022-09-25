Console.WriteLine("Введите число от 1 до 7");
Console.Write("Ваше число: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number > 7)
{
    Console.Write($"Введено некоректное число {number}");
}
if (number == 1)
{
    Console.Write($"Число {number} соответствует понедельнику");
}
if (number == 2)
{
    Console.Write($"Число {number} соответствует вторнику");
}
if (number == 3)
{
    Console.Write($"Число {number} соответствует среде");
}
if (number == 4)
{
    Console.Write($"Число {number} соответствует четвергу");
}
if (number == 5)
{
    Console.Write($"Число {number} соответствует пятнице");
}
if (number == 6)
{
    Console.Write($"Число {number} соответствует субботе");
}
if (number == 7)
{
    Console.Write($"Число {number} соответствует воскременью");
}
