namespace Algorithm.BOJ.BOJ_18301
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_18301/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] inputs = Console.ReadLine()!.Split();
            int n1 = int.Parse(inputs[0]);
            int n2 = int.Parse(inputs[1]);
            int n12 = int.Parse(inputs[2]);
            int N = (n1 + 1) * (n2 + 1) / (n12 + 1) - 1;
            Console.WriteLine(N);
        }
    }
}
