using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_20._02._2025
{
    internal class Program
    {
        public static int Search_max(int[] nums)
        {
            int m = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > m) m = nums[i];
            }
            return m;

        }
        public static int Search_min(int[] nums)
        {
            int m = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < m) m = nums[i];
            }
            return m;
        }
        public static void Change_max(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == Search_max(nums)) nums[i] = 100; 
            }
        }
        public static void Change_min(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == Search_min(nums)) nums[i] = 0;
            }
        }
        public static int[] Create_Arr(int n)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n;i++) arr[i] = Convert.ToInt32(Console.ReadLine());
            return arr;
        }
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32 (Console.ReadLine());
            int[] arr = new int[] {n};
            arr = Create_Arr(n);
            Change_max(arr);
            Change_min(arr);   
            var str = string.Join(",", arr);
            Console.WriteLine(str);
            Console.WriteLine("the end");
            

         }
       
    }

}
