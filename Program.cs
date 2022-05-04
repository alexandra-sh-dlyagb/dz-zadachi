// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N используя рекурсию.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30
int Summ(int N, int M, int sum)
{
    if (N>M) return sum;
    else {
        sum = sum+N;
        return Summ (N+1, M, sum);
        }
}
Console.WriteLine (Summ(3, 5, 0));
//task is done)