namespace Algorithm.BOJ.BOJ_11665
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11665/input1.txt",
            "BOJ/BOJ_11665/input2.txt",
            "BOJ/BOJ_11665/input3.txt",
            "BOJ/BOJ_11665/input4.txt",
            "BOJ/BOJ_11665/input5.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            (int x, int y, int z) min = (1, 1, 1);
            (int x, int y, int z) max = (1000, 1000, 1000);

            for (int _ = 0; _ < N; _++)
            {
                string[] coord = Console.ReadLine()!.Split();
                min.x = Math.Max(min.x, int.Parse(coord[0]));
                min.y = Math.Max(min.y, int.Parse(coord[1]));
                min.z = Math.Max(min.z, int.Parse(coord[2]));
                max.x = Math.Min(max.x, int.Parse(coord[3]));
                max.y = Math.Min(max.y, int.Parse(coord[4]));
                max.z = Math.Min(max.z, int.Parse(coord[5]));
            }

            int vol = Math.Max(max.x - min.x, 0) * Math.Max(max.y - min.y, 0) * Math.Max(max.z - min.z, 0);
            Console.WriteLine(vol);
        }
    }
}
