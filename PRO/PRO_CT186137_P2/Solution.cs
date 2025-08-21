namespace Algorithm.PRO.PRO_CT186137_P2 // 250818 데브시스터즈 코딩테스트 프로그래밍2
{
    using System;

    class Solution
    {
        private static Solution Instance { get; } = new();

        public static string[] InputPaths { get; private set; } =
        [
            "PRO/PRO_CT186137_P2/input1.txt",
            "PRO/PRO_CT186137_P2/input2.txt",
        ];

        // 2차원 field 정보(0: 땅, 1: 바위, 2: 독버섯)와 farmSize 정보가 주어짐
        // field 내에 가로세로 farmSize 크기의 정사각형 농장을 만드려는데
        // 범위 내에 독버섯이 있으면 만들 수 없고 바위가 있으면 바위를 치워야 함
        // 농장을 만들기 위해 치워야 되는 바위의 최소 개수를 찾아라 (농장을 만들 수 있는 방법이 없으면 -1)
        // 정확성 100.0 / 100.0
        // 합계   100.0 / 100.0
        public static void Run(string[] args)
        {
            int[][] _field = System.Text.Json.JsonSerializer.Deserialize<int[][]>(Console.ReadLine()!)!;
            int[,] field = new int[_field.Length, _field[0].Length];

            for (int i = 0; i < field.GetLength(0); i++)
                for (int j = 0; j < field.GetLength(1); j++)
                    field[i, j] = _field[i][j];

            int farmSize = int.Parse(Console.ReadLine()!);

            Console.WriteLine(Instance.solution(field, farmSize));
        }

        public int solution(int[,] field, int farmSize)
        {
            int height = field.GetLength(0);
            int width = field.GetLength(1);
            bool isFound = false;
            int minCnt = height * width;

            for (int i = 0; i < height - farmSize + 1; i++)
            {
                for (int j = 0; j < width - farmSize + 1; j++)
                {
                    int cnt = 0;
                    bool skip = false;

                    for (int r = 0; r < farmSize; r++)
                    {
                        if (skip) break;

                        for (int c = 0; c < farmSize; c++)
                        {
                            if (field[i + r, j + c] == 2 || (field[i + r, j + c] == 1 && ++cnt >= minCnt))
                            {
                                skip = true;
                                break;
                            }
                        }
                    }

                    if (!skip)
                    {
                        isFound = true;
                        minCnt = cnt;
                    }
                }
            }

            return isFound ? minCnt : -1;
        }
    }
}
