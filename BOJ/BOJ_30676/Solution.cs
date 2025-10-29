namespace Algorithm.BOJ.BOJ_30676
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30676/input1.txt",
            "BOJ/BOJ_30676/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int waveLength = int.Parse(Console.ReadLine()!);

            string color;
            if (waveLength >= 620)
                color = "Red";
            else if (waveLength >= 590)
                color = "Orange";
            else if (waveLength >= 570)
                color = "Yellow";
            else if (waveLength >= 495)
                color = "Green";
            else if (waveLength >= 450)
                color = "Blue";
            else if (waveLength >= 425)
                color = "Indigo";
            else
                color = "Violet";

            Console.WriteLine(color);
        }
    }
}
