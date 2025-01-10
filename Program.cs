﻿using Algorithm.BOJ.BOJ_12015;

namespace Algorithm
{
    public class Program
    {
        public static StreamReader InputReader { get; private set; } = new(Console.OpenStandardInput());

        public static void Main(string[] args)
        {
            foreach (string inputPath in Solution.InputPaths)
            {
                /* Console.ReadLine() 사용할 경우 */
                Console.SetIn(new StringReader(File.ReadAllText(inputPath)));

                /* StreamReader.ReadLine() 사용할 경우 */
                InputReader = new(inputPath);

                Solution.Run(args);
            }
        }
    }
}
