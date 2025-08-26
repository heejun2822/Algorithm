namespace Algorithm.BOJ.BOJ_12852
{
    using System.Text;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12852/input1.txt",
            "BOJ/BOJ_12852/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            (int cnt, int prevNum)[] arr = new (int, int)[N + 1];

            for (int i = 2; i <= N; i++)
            {
                int cnt = arr[i - 1].cnt + 1;
                arr[i] = (cnt, i - 1);

                if (i % 2 == 0 && (cnt = arr[i / 2].cnt + 1) < arr[i].cnt)
                    arr[i] = (cnt, i / 2);

                if (i % 3 == 0 && (cnt = arr[i / 3].cnt + 1) < arr[i].cnt)
                    arr[i] = (cnt, i / 3);
            }

            StringBuilder path = new();
            int num = N;
            while (num >= 1)
            {
                path.Append(num);
                path.Append(' ');
                num = arr[num].prevNum;
            }

            Console.WriteLine(arr[N].cnt);
            Console.WriteLine(path);
        }
    }
}
