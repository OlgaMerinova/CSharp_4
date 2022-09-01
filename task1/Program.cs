//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
//Не использовать функцию Math.Pow()
//3, 5 -> 243
//2, 4 -> 16

Console.Write("введите число:   ");
int A = Int32.Parse(Console.ReadLine());
Console.Write("введите степень числа:   ");
int B = Int32.Parse(Console.ReadLine());

int num = 1;

 for(int i = 0; i < B; i++)
{
    num *= A;
}
Console.WriteLine("{0} ^ {1} = {2}", A, B, num);
Console.ReadKey();
return 0;



