namespace Algorithm.BOJ.BOJ_24855
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_24855/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            Array.Sort(a);

            int maxValue = 0;
            for (int i = 1; i <= n / 2; i++) maxValue += a[^i];

            Console.WriteLine(maxValue);
        }
    }
}
