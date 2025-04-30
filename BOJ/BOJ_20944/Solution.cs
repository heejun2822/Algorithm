namespace Algorithm.BOJ.BOJ_20944
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_20944/input1.txt",
            "BOJ/BOJ_20944/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            Console.WriteLine(new string('a', N));
        }
    }
}
