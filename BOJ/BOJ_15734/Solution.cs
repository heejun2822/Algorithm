namespace Algorithm.BOJ.BOJ_15734
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_15734/input1.txt",
            "BOJ/BOJ_15734/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] lra = Console.ReadLine()!.Split();
            int L = int.Parse(lra[0]);
            int R = int.Parse(lra[1]);
            int A = int.Parse(lra[2]);

            int cnt = Math.Min(L, R);
            int sup = Math.Min(Math.Abs(L - R), A);
            cnt += sup;
            cnt += (A - sup) / 2;
            cnt *= 2;

            Console.WriteLine(cnt);
        }
    }
}
