namespace Algorithm.BOJ.BOJ_01978
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01978/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string[] numbers = Console.ReadLine()!.Split();
            int cnt = N;
            foreach (string number in numbers)
            {
                int num = int.Parse(number);
                if (num == 1)
                {
                    cnt--;
                    continue;
                }
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i != 0) continue;
                    cnt--;
                    break;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
