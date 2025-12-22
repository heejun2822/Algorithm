namespace Algorithm.BOJ.BOJ_26176
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_26176/input1.txt",
            "BOJ/BOJ_26176/input2.txt",
        ];

        public static void Run(string[] args)
        {
            // 이분탐색으로 내부의 정사각형 개수가 s를 초과하도록 하는 원의 최소 반지름 R을 찾으면 된다.
            // 정답이 되는 최소 원은 가장 바깥쪽 정사각형의 꼭지점을 지날 것이므로
            // R에 대하여 R^2 = x^2 + y^2 (x, y는 자연수) 을 만족함을 알 수 있다.
            // 그러나 이를 위해 (x^2 + y^2)의 set을 준비할 필요는 없다.
            // 이의 superset인 (범위 내의) 자연수 전체에서 이분탐색을 해도 된다.

            int s = int.Parse(Console.ReadLine()!);

            int l = 0, r = (int)1e9;

            while (l < r)
            {
                int m = (l + r) / 2;

                int cnt = 0;
                int x = 1;
                int sqrY;

                while ((sqrY = m - x * x) > 0 && cnt <= s)
                {
                    cnt += (int)Math.Sqrt(sqrY) * 4;
                    x++;
                }

                if (cnt > s)
                    r = m;
                else
                    l = m + 1;
            }

            Console.WriteLine(Math.Sqrt(r));
        }
    }
}
