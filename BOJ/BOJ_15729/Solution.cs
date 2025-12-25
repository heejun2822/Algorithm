namespace Algorithm.BOJ.BOJ_15729
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15729/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            bool[] btn = new bool[3];
            int cnt = 0;

            while (N-- > 0)
            {
                if ((Console.Read() == '1') ^ btn[0])
                {
                    btn[1] = !btn[1];
                    btn[2] = !btn[2];
                    cnt++;
                }
                (btn[0], btn[1], btn[2]) = (btn[1], btn[2], false);
                Console.Read();
            }

            Console.WriteLine(cnt);
        }
    }
}
