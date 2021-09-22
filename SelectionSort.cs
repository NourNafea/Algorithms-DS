using System;


namespace Variables
{
    class Program{
        
        
        static void Main(string[] args)
        {
            int[] arr = { 15,-41,-5,-9,0,156,-63,-85,66,95,35,14,1616 };
            Solution solution = new Solution();
            solution.sort(arr);
            Console.WriteLine("Sorted array is : ");
            solution.printArray(arr);
        }
    }

    public class Solution
    {
        public Array sort(int[] arr)
        {
            for (var i = 0; i < arr.Length-1; i++)
            {
                var SmallestIdex = i;
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[SmallestIdex])
                        SmallestIdex = j;
                }
                var temp = arr[SmallestIdex];
                arr[SmallestIdex] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }

        public Array printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
            return arr;
        }

    }
        
    
}
