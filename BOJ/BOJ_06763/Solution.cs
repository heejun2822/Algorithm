namespace Algorithm.BOJ.BOJ_06763
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06763/input1.txt",
            "BOJ/BOJ_06763/input2.txt",
            "BOJ/BOJ_06763/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int limit = int.Parse(Console.ReadLine()!);
            int speed = int.Parse(Console.ReadLine()!);

            int over = speed - limit;
            int fine = over > 30 ? 500 : over > 20 ? 270 : over > 0 ? 100 : 0;

            if (fine == 0)
                Console.WriteLine("Congratulations, you are within the speed limit!");
            else
                Console.WriteLine($"You are speeding and your fine is ${fine}.");
        }
    }
}
