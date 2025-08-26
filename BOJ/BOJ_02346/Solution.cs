namespace Algorithm.BOJ.BOJ_02346
{
    using System.Text;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02346/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            if (N == 1) { Console.WriteLine("1"); return; }
            else if (N == 2) { Console.WriteLine("1 2"); return; }

            Balloon firstBalloon = new(1);
            Balloon balloon = firstBalloon;
            for (int i = 2; i <= N; i++)
            {
                balloon.SetNext(new(i));
                balloon.Next!.SetPrev(balloon);
                balloon = balloon.Next!;
            }
            balloon.SetNext(firstBalloon);
            firstBalloon.SetPrev(balloon);

            StringBuilder answer = new();
            balloon = firstBalloon;
            for (int _ = 0; _ < N; _++)
            {
                answer.Append($"{balloon.Id} ");
                balloon.Prev!.SetNext(balloon.Next!);
                balloon.Next!.SetPrev(balloon.Prev!);
                int num = numbers[balloon.Id - 1];
                if (num > 0) for (int i = 0; i < num; i++) balloon = balloon.Next!;
                else for (int i = 0; i > num; i--) balloon = balloon.Prev!;
            }

            Console.WriteLine(answer);
        }

        private class Balloon
        {
            public int Id { get; private set; }
            public Balloon? Prev { get; private set; }
            public Balloon? Next { get; private set; }

            public Balloon(int id) { Id = id; }

            public void SetPrev(Balloon balloon) { Prev = balloon; }
            public void SetNext(Balloon balloon) { Next = balloon; }
        }
    }
}
