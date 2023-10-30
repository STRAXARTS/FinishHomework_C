// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Accerman(int Z, int X)
{   
    int A = 0;
    if (Z < 0 | X < 0) return -1;
    else if (Z == 0) return A = X + 1;
    else if (Z > 0 & X == 0) return Accerman (Z-1, 1);
    else return Accerman (Z-1, Accerman(Z, X - 1));   
}
Console.Write("Введите положительное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Accerman (M, N));
