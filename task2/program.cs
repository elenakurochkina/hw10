//Напишите программу вычисления функции Аккермана с помощью 
//рекурсии. Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29

int CalcAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return CalcAkkerman(m - 1, 1);
    if (m > 0 && n > 0) return CalcAkkerman(m - 1, CalcAkkerman(m, n - 1));
    return CalcAkkerman(m, n);
}
System.Console.WriteLine(CalcAkkerman(3, 2));