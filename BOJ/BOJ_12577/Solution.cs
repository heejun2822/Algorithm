namespace Algorithm.BOJ.BOJ_12577
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12577/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder output = new();

            for (int x = 1; x <= T; x++)
            {
                string[] input = Console.ReadLine()!.Split();
                int N = int.Parse(input[0]);
                int M = int.Parse(input[1]);

                Directory rootDir = new();
                int y = 0;

                for (int _ = 0; _ < N; _++)
                {
                    string[] path = Console.ReadLine()!.Split('/');
                    Directory currDir = rootDir;
                    for (int i = 1; i < path.Length; i++)
                    {
                        if (currDir.TryGetDirectory(path[i], out Directory? dir))
                            currDir = dir!;
                        else
                            currDir = currDir.MakeDirectory(path[i]);
                    }
                }

                for (int _ = 0; _ < M; _++)
                {
                    string[] path = Console.ReadLine()!.Split('/');
                    Directory currDir = rootDir;
                    for (int i = 1; i < path.Length; i++)
                    {
                        if (currDir.TryGetDirectory(path[i], out Directory? dir))
                            currDir = dir!;
                        else
                        {
                            currDir = currDir.MakeDirectory(path[i]);
                            y++;
                        }
                    }
                }

                output.AppendLine($"Case #{x}: {y}");
            }

            Console.Write(output);
        }

        private class Directory
        {
            private Dictionary<string, Directory> children = new();

            public bool TryGetDirectory(string name, out Directory? dir)
            {
                if (children.TryGetValue(name, out Directory? child))
                {
                    dir = child;
                    return true;
                }
                dir = null;
                return false;
            }

            public Directory MakeDirectory(string name)
            {
                Directory dir = new();
                children.Add(name, dir);
                return dir;
            }
        }
    }
}
