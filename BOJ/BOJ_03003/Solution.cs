namespace Algorithm.BOJ.BOJ_03003
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_03003/input1.txt",
            "BOJ/BOJ_03003/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int[] s_pieces = new int[] {1, 1, 2, 2, 2, 8};
            string[] pieces = Console.ReadLine()!.Split();
            string answer = "";
            for (int i = 0; i < 6; i++)
            {
                answer += $"{s_pieces[i] - int.Parse(pieces[i])} ";
            }
            Console.WriteLine(answer);
        }
    }
}
