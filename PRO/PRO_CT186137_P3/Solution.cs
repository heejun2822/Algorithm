namespace Algorithm.PRO.PRO_CT186137_P3 // 250818 데브시스터즈 코딩테스트 프로그래밍3
{
    using System;

    class Solution
    {
        private static Solution Instance { get; } = new();

        public static string[] InputPaths { get; private set; } =
        [
            "PRO/PRO_CT186137_P3/input1.txt",
            "PRO/PRO_CT186137_P3/input2.txt",
        ];

        // 당구공들의 위치(x, y)와 hitVector가 주어짐
        // (0, 0) 위치에 있는 당구공을 쳐서 hitVector 방향으로 굴러갈 때
        // 가장 먼저 맞는 당구공의 인덱스를 찾아라 (아무도 맞지 않으면 -1)
        // 당구대의 크기는 무한하고 모든 당구공의 반지름은 1, hitVector는 정규화되어있지 않음
        // 정확성 46.0 / 88.0
        // 효율성 8.0 / 12.0
        // 합계   54.0 / 100.0
        public static void Run(string[] args)
        {
            double[][] _objectBallPosList = System.Text.Json.JsonSerializer.Deserialize<double[][]>(Console.ReadLine()!)!;
            double[,] objectBallPosList = new double[_objectBallPosList.Length, _objectBallPosList[0].Length];

            for (int i = 0; i < objectBallPosList.GetLength(0); i++)
                for (int j = 0; j < objectBallPosList.GetLength(1); j++)
                    objectBallPosList[i, j] = _objectBallPosList[i][j];

            double[] hitVector = System.Text.Json.JsonSerializer.Deserialize<double[]>(Console.ReadLine()!)!;

            Console.WriteLine(Instance.solution(objectBallPosList, hitVector));
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
                x /= magnitude;
                y /= magnitude;
            }

            public static Vector2 operator -(Vector2 vec1, Vector2 vec2)
            {
                return new Vector2(vec1.x - vec2.x, vec1.y - vec2.y);
            }
        }
    }
}
