using System;

public class Answer
{
    public static void PrintRange(int M, int N)
    {
        if (M <= N) {
            for (int i = M; i <= N; i++) {
                Console.Write(i);
                if (i < N){
                    Console.Write(",");
                }
            }
        }
        else {
            Console.Write(M);
        }
    }
    static public void Main(string[] args)
    {
        int M = 1; // Можно поменять значение для проверки
        int N = 5; // Можно поменять значение для проверки
        Console.WriteLine("Числа в промежутке:");
        PrintRange(M, N);
    }
}