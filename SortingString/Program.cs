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
                char ch = '\0';
                char ch2 = '\0';
                for (int j = 0; j < str[i].Length; j++)
                {
                    ch = str[i][j];

                    for (int k = j; k < str[i].Length - k - 1; k++)
                    {
                        ch2 = str[i + 1][k];
                        if (ch > ch2)
                        {
                            var tmp = str[i];
                            str[i] = str[i + 1];
                            str[i + 1] = tmp;

                        }
                    }
                }

            }

            //for (int i2 = 0; i2 < str.Length; i2++)
            //{
            //    for (int i = i2 + 1; i < str.Length; i++)
            //    {
            //        for (int k = 0; k < str[i2].Length; k++)
            //        {
            //            char ch = '\0';
            //            char ch2 = '\0';
            //            for (int j = k; j < str[i2].Length - 1 + k; j++)
            //            {
            //                ch = str[i2][j];
            //            }

            //            for (int j = k; j < str[i].Length - 1 + k; j++)
            //            {
            //                ch2 = str[i][j];
            //            }


            //            if (ch > ch2)
            //            {
            //                var tmp = str[i2];
            //                str[i2] = str[i2 + 1];
            //                str[i2 + 1] = tmp;
            //            }
            //        }
            //    }
            
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
