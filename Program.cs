/*1. написать цикл, который принимает на вход два числа(А и Б) и возводит число А в натуральную степень Б
3, 5->243
2,4->16
решение*/
int sum(int A)
{
    int val=0;
    if(A>10)
        {
            while(A!=0)
            {
                val+=A%10;
                A=A/10;
            }
        }
    else val=A;
    return val;

}
int a,b,val;
int[] array=new int[8];
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

/*написать программу, которая принимает на вход число и выдает сумму цифр в числе
452->11
9012-12*/
Console.WriteLine("программа принимает на вход число и выдает сумму цифр.");
Console.WriteLine("введите число: ");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" сумма ="+sum(a));

/*программа сщздает массив из 8 случайных элементов*/
Console.WriteLine("массив: ");
Random arr = new Random();
for (int i=0;i<array.Length;i++)
    array[i]= arr.Next(0,100);
for (int i=0;i<array.Length;i++)
    Console.WriteLine(array[i]);