Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int third = Convert.ToInt32(Console.ReadLine());

if (first > second)
{
    if (first > third)
    {
         Console.WriteLine("{0} - наибольшее число", first);
    }
else
    {
        Console.WriteLine("{0} - наибольшее число", third);
    }
}
else
{
    if (second > third)
    {
        Console.WriteLine("{0} - наибольшее число", second);
    }
else
    {
        Console.WriteLine("{0} - наибольшее число", third);
    }
}
