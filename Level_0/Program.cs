// Программа, которая на входе принимает число
// и выдает его квадрат

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
// - 2 147 483 648 до 2 147 483 647
// double DoubleNumber = 4.454;
// string StringStr = "Любая строка";

int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");

// bool b = number == square;

