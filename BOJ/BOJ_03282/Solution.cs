namespace Algorithm.BOJ.BOJ_03282
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_03282/input1.txt",
            "BOJ/BOJ_03282/input2.txt",
            "BOJ/BOJ_03282/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] ng = Console.ReadLine()!.Split();
            int N = int.Parse(ng[0]);
            int G = int.Parse(ng[1]);
            int[] rooms = new int[N];

            int roomIdx = 0;
            for (int _ = 0; _ < G; _++)
            {
                int guest = int.Parse(Console.ReadLine()!);
                while (guest > 0)
                {
                    if (rooms[roomIdx] < 2)
                    {
                        int cnt = (rooms[roomIdx] == 0 && guest >= 2) ? 2 : 1;
                        guest -= cnt;
                        rooms[roomIdx] += cnt;
                    }
                    roomIdx = (roomIdx + 1) % N;
                }
            }

            foreach (int cnt in rooms) Console.WriteLine(cnt);
        }
    }
}
