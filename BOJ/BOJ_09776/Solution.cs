namespace Algorithm.BOJ.BOJ_09776
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09776/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            const float PI = 3.14159f;
            float maxVolume = 0;

            for (int _ = 0; _ < n; _++)
            {
                string[] input = Console.ReadLine()!.Split();
                char figure = char.Parse(input[0]);
                float volume = 0;

                if (figure == 'C')
                {
                    float r = float.Parse(input[1]), h = float.Parse(input[2]);
                    volume = (1 / 3f) * PI * r * r * h;
                }
                else if (figure == 'L')
                {
                    float r = float.Parse(input[1]), h = float.Parse(input[2]);
                    volume = PI * r * r * h;
                }
                else if (figure == 'S')
                {
                    float r = float.Parse(input[1]);
                    volume = (4 / 3f) * PI * r * r * r;
                }

                maxVolume = Math.Max(maxVolume, volume);
            }

            Console.WriteLine(maxVolume.ToString("F3"));
        }
    }
}
