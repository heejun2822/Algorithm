namespace Algorithm.BOJ.BOJ_01001
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01001/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] integers = (Console.ReadLine() ?? "").Split();
            int answer = int.Parse(integers[0]) - int.Parse(integers[1]);
            Console.WriteLine(answer);
        }
    }
}
