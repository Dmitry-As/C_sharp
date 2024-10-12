using System;
public class Answer
{
    public static int SumRange(int M, int N)
    {
        if (M == N) {
            return M;
        }
        else {
            return M + SumRange(M + 1, N);
        }
    }
    static public void Main(string[] args)
    {
        int M = 1; // Можно поменять значение для проверки
        int N = 15; // Можно поменять значение для проверки
        int sum = SumRange(M, N);
        Console.WriteLine($"Сумма элементов в промежутке от {M} до {N}: {sum}");
    }
}