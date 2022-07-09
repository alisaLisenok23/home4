/*1. написать цикл, который принимает на вход два числа(А и Б) и возводит число А в натуральную степень Б
3, 5->243
2,4->16
решение*/
int a,b,val;
Console.WriteLine("введите число А:");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число Б:");
b=Convert.ToInt32(Console.ReadLine());
val=a;
for (; b > 1; b--)
{
    a*=val;
}
Console.WriteLine(a);

