namespace Algorithm.BOJ.BOJ_14215
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_14215/input1.txt",
            "BOJ/BOJ_14215/input2.txt",
            "BOJ/BOJ_14215/input3.txt",
            "BOJ/BOJ_14215/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int[] lengths = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            Array.Sort(lengths);
            int answer = lengths[0] + lengths[1];
            answer += lengths[2] < answer ? lengths[2] : answer - 1;
            Console.WriteLine(answer);
        }
    }
}
