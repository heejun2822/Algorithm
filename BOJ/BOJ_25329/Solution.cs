namespace Algorithm.BOJ.BOJ_25329
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25329/input1.txt",
            "BOJ/BOJ_25329/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(sr.ReadLine()!);

            Dictionary<string, int> callTimes = new();

            for (int _ = 0; _ < n; _++)
            {
                string[] input = sr.ReadLine()!.Split();
                string[] time = input[0].Split(':');

                callTimes.TryAdd(input[1], 0);
                callTimes[input[1]] += 60 * int.Parse(time[0]) + int.Parse(time[1]);
            }

            (string name, int charge)[] callCharges = callTimes.Select(ele=> {
                int charge = 10;
                if (ele.Value > 100) charge += (ele.Value - 100 + 49) / 50 * 3;
                return (ele.Key, charge);
            }).ToArray();

            Array.Sort(callCharges, (a, b) => a.charge != b.charge ? b.charge.CompareTo(a.charge) : a.name.CompareTo(b.name));

            foreach ((string name, int charge) in callCharges)
                sw.WriteLine($"{name} {charge}");

            sr.Close();
            sw.Close();
        }
    }
}
