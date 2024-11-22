namespace Algorithm.BOJ.BOJ_02587
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02587/input.txt",
        ];

        public static void Run(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++) arr[i] = int.Parse(Console.ReadLine()!);
            Array.Sort(arr);
            Console.WriteLine(arr.Average());
            Console.WriteLine(arr[2]);
        }
    }
}
