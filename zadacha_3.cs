using System;

public class Answer
{
    public static int Ackermann(int m, int n)
    {
        if (m == 0) {
            return n + 1;
        }
        else if (n == 0) {
            return Ackermann(m - 1, 1);
        }
        else {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
    static public void Main(string[] args)
    {
        int m = 2; // Можно поменять значение для проверки
        int n = 4; // Можно поменять значение для проверки
        int result = Ackermann(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");
    }
}