# Algorithm

각각의 플랫폼의 일반적인 제출 형식에 맞춰 구조를 잡았습니다.

1. Baekjoon Online Judge (BOJ)
     ```C#
     // BOJ Solution 구조
     namespace Algorithm.BOJ.BOJ_00000
     {
         public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
         {
             public static string[] InputPaths { get; set; } =
             [
                 "BOJ/BOJ_00000/input.txt",
             ];

             public static void Run(string[] args)
             {

             }
         }
     }

     // BOJ 제출 형식
     public class Solution
     {
         public static void Main(string[] args)
         {
             
         }
     }
     ```
2. Programmers (PRO)
   ```C#
   // PRO Solution 구조
   namespace Algorithm.PRO.PRO_00000 // 문제 제목
   {
       public class Solution : SolutionPRO<Solution>, ISolutionPRO
       {
           public static string[] InputPaths { get; set; } =
           [
               "PRO/PRO_00000/input.txt",
           ];

           public override void Run(string[] args)
           {

           }

           public var solution(var input)
           {

           }
       }
   }

   // PRO 제출 형식
   public class Solution
   {
       public var solution(var input)
       {
           
       }
   }
   ```

---

[solved.ac 프로필](https://solved.ac/profile/heejun2822)
