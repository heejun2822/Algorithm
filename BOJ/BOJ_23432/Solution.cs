namespace Algorithm.BOJ.BOJ_23432
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_23432/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            System.Text.StringBuilder output = new();
            int prevNum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = a[i] * (prevNum / a[i] + 1);
                output.Append(num).Append(' ');
                prevNum = num;
            }

            Console.WriteLine(output);
        }
    }
}
