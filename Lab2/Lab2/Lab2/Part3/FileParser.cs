using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab2.Part3
{
    internal class FileParser
    {
        private static string path;

        public static void SetFilePath(string filePath)
        {
            path = filePath;
        }

        public static void GetMinDifference(int index1, int index2, int index3)
        {
            int minDifference = -1;
            string output = string.Empty;
            using (var sr = new StreamReader(path))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    line.Replace('*', ' '); //remove *
                    string[] columns = line.Split(new char[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (columns.Length > 0)
                    {
                        int value2, value3;

                        var value1 = columns[index1];

                        bool parseErrorValue2 = int.TryParse(columns[index2], out value2);
                        bool parseErrorValue3 = int.TryParse(columns[index3], out value3);
                        if (parseErrorValue2 && parseErrorValue3)
                        {
                            int difference = Math.Abs(value2 - value3);
                            if (difference < minDifference || minDifference == -1)
                            {
                                output = value1;
                                minDifference = difference;
                            }
                        }
                    }
                    line = sr.ReadLine();
                }
            }

            if (index1 == 0)
                Console.WriteLine(string.Format("Day {0} has the minimum temperaturer spread : {1}", output, minDifference));
            else
                Console.WriteLine(string.Format("Team {0} has the minimum difference in goals : {1}", output, minDifference));
        }
    }
}