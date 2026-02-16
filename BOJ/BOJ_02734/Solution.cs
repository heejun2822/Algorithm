namespace Algorithm.BOJ.BOJ_02734
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02734/input.txt",
        ];

        public static void Run(string[] args)
        {
            double R = 1;

            int T = int.Parse(Console.ReadLine()!);

            while (T-- > 0)
            {
                string[] input = Console.ReadLine()!.Split();
                int N = int.Parse(input[0]);

                (double x, double y)[] positions = new (double, double)[N];

                for (int i = 0; i < N; i++)
                    positions[i] = (double.Parse(input[i + 1]), R);

                for (int cnt = N - 1; cnt > 0; cnt--)
                    for (int i = 0; i < cnt; i++)
                        positions[i] = CalcTopCylinderPos(positions[i], positions[i + 1]);

                Console.WriteLine($"{positions[0].x:F4} {positions[0].y:F4}");
            }

            (double x, double y) CalcTopCylinderPos((double x, double y) pos1, (double x, double y) pos2)
            {
                double dx = pos2.x - pos1.x;
                double dy = pos2.y - pos1.y;
                double dist = Math.Sqrt(dx * dx + dy * dy);

                double cos_A = dx / dist;
                double sin_A = dy / dist;
                double cos_B = (dist / 2) / (R * 2);
                double sin_B = Math.Sqrt(1 - cos_B * cos_B);

                double cos_AplusB = cos_A * cos_B - sin_A * sin_B;
                double sin_AplusB = sin_A * cos_B + cos_A * sin_B;

                return (pos1.x + 2 * R * cos_AplusB, pos1.y + 2 * R * sin_AplusB);
            }
        }
    }
}
