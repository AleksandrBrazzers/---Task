Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
{
     Console.WriteLine("Число\tСтепень\tВывод");
    {
            Console.WriteLine($"{x}\t{y}\t{Math.Pow(x,y)}");
        }
}      