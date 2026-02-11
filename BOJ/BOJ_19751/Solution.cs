namespace Algorithm.BOJ.BOJ_19751
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_19751/input1.txt",
            "BOJ/BOJ_19751/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int[] integers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            Array.Sort(integers);
            (integers[1], integers[2]) = (integers[2], integers[1]);

            Console.WriteLine(string.Join(' ', integers));
        }
    }
}
