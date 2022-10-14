Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье целое число");
int c = Convert.ToInt32(Console.ReadLine());


if (b > a && c < a)
{
    Console.WriteLine($"{b} - максимальное число из трёх");
}
else if (a > c && a > b)
{
    Console.WriteLine($"{a} - максимальное число из трёх");
}
else
{
    Console.WriteLine($"{c} - максимальное число из трёх");
}