using System;
using System.Reflection.Metadata.Ecma335;


namespace Variables
{
    class Program{
        
        
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.Write("Enter a number: ");
            var result = solution.factorial(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("The factorial is: "+result);
        }
    }

    public class Solution
    {
        public int factorial(int x)
        {
            if (x==1) 
                return 1;
            else
            {
                return x * factorial(x - 1);
            }
                
        }
        
    }


}

