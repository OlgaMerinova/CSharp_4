//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа. 
//(для получения цифр числа операцию приведения числа к строке не использовать)
//452 -> 6
//82 -> 2
//9012 -> 3
//23 -> 0


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int tmp = number;
int sum = 0;
while (tmp > 0 && tmp % 10 != 0)
{
    if (number % (tmp % 10) == 0)
    {
        sum = sum + tmp % 10;
    }
    tmp = tmp / 10;
}
Console.WriteLine($"{number} -> {sum}");

