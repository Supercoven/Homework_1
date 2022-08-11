Console.WriteLine("Введите целое число N");
int n = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i <= n; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine($"{i}");
    }
}