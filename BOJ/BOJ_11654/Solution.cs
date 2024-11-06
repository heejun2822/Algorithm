namespace Algorithm.BOJ.BOJ_11654
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11654/input1.txt",
            "BOJ/BOJ_11654/input2.txt",
            "BOJ/BOJ_11654/input3.txt",
            "BOJ/BOJ_11654/input4.txt",
            "BOJ/BOJ_11654/input5.txt",
            "BOJ/BOJ_11654/input6.txt",
        ];

        public static void Run(string[] args)
        {
            char chr = char.Parse(Console.ReadLine()!);
            Console.WriteLine((int)chr);
        }
    }
}
