Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (Num >= i)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
        i++;
    }
    i++;
}
