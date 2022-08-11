Console.WriteLine("Введите целое число, чтобы проверить делится ли оно на 2");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0)
{
    Console.WriteLine("Число делится на 2 без остатка");
}
else
{
    Console.WriteLine("Число делится на 2 с остатком");
}