Console.WriteLine("Введите первое целое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int b = Convert.ToInt32(Console.ReadLine());

if(b > a) 
{
    Console.WriteLine("Второе число больше");
}
else if(a > b)
{
    Console.WriteLine("Первое число больше");
}
else
{
    Console.WriteLine("Оба числа равны");
}

