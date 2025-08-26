namespace Algorithm.PRO.PRO_CT186137_P3 // 250818 데브시스터즈 코딩테스트 프로그래밍3
{
    using System;

    public class Solution2 : SolutionPRO<Solution2>, ISolutionPRO
    {
        public static string[] InputPaths { get; set; } =
        [
            "PRO/PRO_CT186137_P3/input1.txt",
            "PRO/PRO_CT186137_P3/input2.txt",
        ];

        public override void Run(string[] args)
        {
            double[][] _objectBallPosList = System.Text.Json.JsonSerializer.Deserialize<double[][]>(Console.ReadLine()!)!;
            double[,] objectBallPosList = new double[_objectBallPosList.Length, _objectBallPosList[0].Length];

            for (int i = 0; i < objectBallPosList.GetLength(0); i++)
                for (int j = 0; j < objectBallPosList.GetLength(1); j++)
                    objectBallPosList[i, j] = _objectBallPosList[i][j];

            double[] hitVector = System.Text.Json.JsonSerializer.Deserialize<double[]>(Console.ReadLine()!)!;

            int answer = solution(objectBallPosList, hitVector);

            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(answer));
        }

        public const double BallDiameter = 2;

        public int solution(double[,] objectBallPosList, double[] hitVector)
        {
            Vector2 dir = new Vector2(hitVector[0], hitVector[1]);
            dir.Normalize();

            double minDistance = double.MaxValue;
            int ballIdx = -1;

            for (int i = 0; i < objectBallPosList.GetLength(0); i++)
            {
                Vector2 pos = new Vector2(objectBallPosList[i, 0], objectBallPosList[i, 1]);
                if (Simulate(dir, pos, out double distance) && distance < minDistance)
                {
                    minDistance = distance;
                    ballIdx = i;
                }
            }

            return ballIdx;
        }

        private bool Simulate(Vector2 dir, Vector2 pos, out double distance)
        {
            double dotProd = pos.Dot(dir);
            double sqrNormal = pos.sqrMagnitude - dotProd * dotProd;
            bool collision = dotProd >= 0 && sqrNormal < BallDiameter * BallDiameter;

            if (!collision)
            {
                distance = -1;
                return false;
            }

            distance = dotProd - Math.Sqrt(BallDiameter * BallDiameter - sqrNormal);

            return true;
        }

        class Vector2
        {
            public double x;
            public double y;

            public double magnitude => Math.Sqrt(x * x + y * y);
            public double sqrMagnitude => x * x + y * y;

            public Vector2(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public double Dot(Vector2 vec)
            {
                return x * vec.x + y * vec.y;
            }

            public void Normalize()
            {
                double mag = magnitude;
                x /= mag;
                y /= mag;
            }

            public static Vector2 operator -(Vector2 vec1, Vector2 vec2)
            {
                return new Vector2(vec1.x - vec2.x, vec1.y - vec2.y);
            }
        }
    }
}
