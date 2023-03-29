//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*

Console.WriteLine("Enter number:   ");
int n = int.Parse(Console.ReadLine()!);

void Rec (int n)
{
    if (n < 0) Console.WriteLine($"{n}  не натуральное число ");
    if (n == 0) return;
    Console.WriteLine("{0,2}", n);
    Rec (n - 1);
}
Rec(n);

*/

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.



/*
using System;


namespace Rec
{
    class Summ 
    {
        static int SumNumbers(int M, int N)
        {
            if (M == 0) return (N * (N + 1)) / 2;          
            else if (N == 0) return (M * (M + 1)) / 2;       
            else if (M == N) return M;                       
            else if (M < N) return N + SumNumbers(M, N - 1); 
            else return N + SumNumbers(M, N + 1);            
        }
        static void Main(string[] args)
        {
            Console.Write("M = ");
            int M = int.Parse(Console.ReadLine()!);
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Result, S = {SumNumbers(M, N)}");
            Console.ReadLine();
        }
    }
}


*/
/*

///Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

*/