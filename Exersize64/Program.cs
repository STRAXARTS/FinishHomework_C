// Задача 64: Задайте значение N. Напишите программу, которая выведет все
//  натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string NatNumRev (int N)
{       
    if (N == 1) return "1" ;
    else return $"{N} " + NatNumRev (N-1);
}

Console.Write("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 1) Console.WriteLine("На данном промежутке натуральных чисел нет.");
else Console.WriteLine(NatNumRev (N));