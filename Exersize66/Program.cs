// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите целое число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M>0 | N>0)
{
    int Z = M;
    int K = N;
    int SNN = 0; //SNN - Sum Natural Numbers
    if (M>N)
    {
        {
            while (K<=0) K++;
        }
        for (int i=K; i<=M; i++)
        {
            SNN += i;
        }
        Console.WriteLine($"Сумма натуральных чисел в промежутке от N до M = {SNN}");
    }
    else if (M<N)
    {
        {
            while (Z<=0) Z++;
        }
        for (int i=Z; i<=N; i++)
        {
            SNN += i;
        }
        Console.WriteLine($"Сумма натуральных чисел в промежутке от M до N = {SNN}");
    }
    else Console.WriteLine($"Сумма натуральных чисел в промежутке от M до N = {M}"); 
}
if (M<=0 & N<=0) Console.WriteLine("В указанном промежутке натуральных чисел нет."); 
