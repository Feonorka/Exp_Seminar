Console.WriteLine("Введите число");
int MaxNum = Convert.ToInt32(Console.ReadLine());;

int MinNum = MaxNum * -1;
int Num = MinNum;
while (Num >= MinNum && Num <= MaxNum)
{
    Console.Write($"{Num} ");
    Num++;
}
