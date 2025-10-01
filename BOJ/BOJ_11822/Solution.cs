namespace Algorithm.BOJ.BOJ_11822
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11822/input1.txt",
            "BOJ/BOJ_11822/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            DayCounter dayCounter = new();

            for (int i = 0; i < N; i++)
            {
                bool[] isWorkingDay = Array.ConvertAll(Console.ReadLine()!.Split(), s => s == "1");

                while (!isWorkingDay[dayCounter.Day])
                    dayCounter.NextDay();

                if (i != N - 1)
                    dayCounter.NextDay();
            }

            Console.WriteLine(dayCounter.PassedDays);
        }

        private class DayCounter
        {
            private int currentDay = 0;
            private int passedDays = 1;

            public int Day => currentDay;
            public int PassedDays => passedDays;

            public void NextDay()
            {
                currentDay++;
                passedDays++;
                if (currentDay == 5)
                {
                    currentDay = 0;
                    passedDays += 2;
                }
            }
        }
    }
}
