using System;

namespace NPL.Practice.T01.Problem01
{
    class Program
    {
        private static decimal[] DrawCircleChart(int[] chartInput)
        {
            int sum = 0;
            foreach(var item in chartInput)
            {
                sum += item;
            }
            decimal[] arr = new decimal[chartInput.Length];
            for(int i = 0; i < chartInput.Length - 1; i++)
            {
                arr[i] = Math.Round((decimal)chartInput[i] / sum * 100, 2);
            }
            for( int j =0; j<arr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }
            return arr;
        }
        static void Main(string[] args)
        {
            DrawCircleChart(new int[] { 1, 2, 2, 3 });           
            Console.ReadKey();
        }
    }
}
