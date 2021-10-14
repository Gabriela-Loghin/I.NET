using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    internal class DailyWeather
    {
        private int dayIndex;
        private int maxTemp;
        private int minTemp;

        public DailyWeather()
        {
        }

        public DailyWeather(int dayIndex, int maxTemp, int minTemp)
        {
            this.dayIndex = dayIndex;
            this.maxTemp = maxTemp;
            this.minTemp = minTemp;
        }

        public int getDayIndex()
        {
            return dayIndex;
        }

        public int getMaxTemp()
        {
            return maxTemp;
        }

        public int getMinTemp()
        {
            return minTemp;
        }
    }
}