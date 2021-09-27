using System;

namespace Variables
{
    class Program{
        
        
        static void Main(string[] args)
        {
            int[] array = new int[3] { 1, 2, 3 };
            Solution solution = new Solution();
            var result = solution.sum(array,array.Length);
            Console.WriteLine("The sum is: " + result);

            
        }
    }

    public class Solution
    {
        public int sum(int[] array,int N)
        {
            if (N <= 0) 
                return 0;
            
            return (sum(array,N-1) + array[N - 1]);


        }
        
    }

}

