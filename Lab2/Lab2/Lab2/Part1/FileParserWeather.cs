using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab2
{
    internal static class FileParserWeather
    {
        public static void GetMinDifference(List<DailyWeather> dailyWeathers)
        {
            DailyWeather minSpreadDay = null;
            int minDifference = -1;
            foreach (DailyWeather dailyWeather in dailyWeathers)
            {
                int difference = dailyWeather.getMaxTemp() - dailyWeather.getMinTemp();
                if (difference < minDifference || minDifference == -1)
                {
                    minSpreadDay = dailyWeather;
                    minDifference = difference;
                }
            }
            Console.WriteLine(string.Format("Day {0} has the minimum temperaturer spread : {1}", minSpreadDay.getDayIndex(), minDifference));
        }

        public static List<DailyWeather> GetDailyWeathers()
        {
            List<DailyWeather> weathers = new List<DailyWeather>();
            string path = Directory.GetCurrentDirectory();
            using (var sr = new StreamReader("D:/facultate 2/SEM5C/Lab2/Lab2/weather.dat"))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    line.Replace('*', ' '); //remove *
                    string[] columns = line.Split(new char[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (columns.Length > 0)
                    {
                        int dayIndex, minTemp, maxTemp;
                        bool parseErrorIndex = int.TryParse(columns[0], out dayIndex);
                        bool parseErrorMaxTemp = int.TryParse(columns[1], out maxTemp);
                        bool parseErrorMinTemp = int.TryParse(columns[2], out minTemp);
                        if (parseErrorIndex && parseErrorMaxTemp && parseErrorMinTemp)
                        {
                            weathers.Add(new DailyWeather(dayIndex, maxTemp, minTemp));
                        }
                    }
                    line = sr.ReadLine();
                }
            }
            return weathers;
        }
    }
}