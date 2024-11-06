namespace Algorithm.BOJ.BOJ_10998
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10998/input1.txt",
            "BOJ/BOJ_10998/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] integers = (Console.ReadLine() ?? "").Split();
            int answer = int.Parse(integers[0]) * int.Parse(integers[1]);
            Console.WriteLine(answer);
        }
    }
}
