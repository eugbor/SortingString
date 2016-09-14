using System;

namespace SortingString
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var str = s.Split(' ', ',', '.', '\t');
            //Array.Sort(str);
            Sort(str);
            DisplayValues(str);

            Console.ReadLine();
        }

        public static void Sort(string[] str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (IsSortStrings/*String.Compare*/(str[i], str[j]) > 0)
                    {
                        var temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                }
            }
        }

        public static int IsSortStrings(string s1, string s2)
        {
            int t = s1.Length > s2.Length ? s2.Length : s1.Length;
            for (int i = 0; i < t; i++)
            {
                if (s1[i] < s2[i]) return -1;
                if (s1[i] > s2[i]) return 1;
                if (s1[i] == s2[i] && s1.Length > s2.Length) return 1;
            }
            return -1;
        }
        
        public static void DisplayValues(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}
