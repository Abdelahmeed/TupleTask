using System;
using System.Collections.Generic;

namespace TubleTasks
{
    class Program
    {

        public static Tuple<int, int> FindTwoSum(List<int> list, int sum)
        {
            if(list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = i+1; i < list.Count; i++)
                    {
                        if(list[i] + list[j] == sum )
                        {
                           
                            return Tuple.Create(i, j);

                        }
                    }
                }
            }

            return null;
           
        }
        public static void Main(string[] args)
        {
            Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
            if (indices != null)
            {
                Console.WriteLine(indices.Item1 + " " + indices.Item2);
            }
            Console.ReadLine();
        }



    }
}
