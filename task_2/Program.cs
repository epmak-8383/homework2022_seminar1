Console.Clear();

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine(a);
}

else 
{   if (b > c)
    {
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine(c);
    }
}