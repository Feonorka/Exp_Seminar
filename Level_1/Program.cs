Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int squareNum = number2 * number2;

if (squareNum == number1)
{
    Console.Write($"Да. Число {number1} это квадрат числа {number2}");
}
else
{
    Console.Write($"Нет. Число {number1} не является квадратом числа {number2}");
}