namespace Algorithm.BOJ.BOJ_17177
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17177/input1.txt",
            "BOJ/BOJ_17177/input2.txt",
            "BOJ/BOJ_17177/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] abc = Console.ReadLine()!.Split();
            int a = int.Parse(abc[0]);
            int b = int.Parse(abc[1]);
            int c = int.Parse(abc[2]);

            float d_b = MathF.Sqrt(a * a - b * b);
            float d_c = MathF.Sqrt(a * a - c * c);

            if (d_b > c)
                Console.WriteLine((MathF.Round(d_b * d_c) - b * c) / a);
            else
                Console.WriteLine("-1");
        }
    }
}
