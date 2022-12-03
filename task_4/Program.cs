Console.Clear();

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int b = a - (a - 2);

while (b <= a)
{
    Console.WriteLine(b);
    b = b + 2;
}