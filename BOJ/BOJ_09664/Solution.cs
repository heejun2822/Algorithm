namespace Algorithm.BOJ.BOJ_09664
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09664/input1.txt",
            "BOJ/BOJ_09664/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int O = int.Parse(Console.ReadLine()!);

            int initial = O + O / (N - 1);

            if (O % (N - 1) == 0)
                Console.WriteLine($"{initial - 1} {initial}");
            else
                Console.WriteLine($"{initial} {initial}");
        }
    }
}
