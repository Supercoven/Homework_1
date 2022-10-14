Console.WriteLine("Введите целое число, чтобы проверить чётное оно или нет");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}