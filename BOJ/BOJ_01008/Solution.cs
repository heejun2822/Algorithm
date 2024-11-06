namespace Algorithm.BOJ.BOJ_01008
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01008/input1.txt",
            "BOJ/BOJ_01008/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] integers = (Console.ReadLine() ?? "").Split();
            double answer = double.Parse(integers[0]) / double.Parse(integers[1]);
            Console.WriteLine(answer);
        }
    }
}
