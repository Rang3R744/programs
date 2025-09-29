using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Lib
{
    public class Tablet
    {
        public string Brand;
        public string Model;
        public double ScreenSize; // дюйми
        public int Storage;       // гігабайти
        public bool HasCellular;  // наявність мобільної мережі
        public double Price;      // ціна в доларах
        public int BatteryLife;   // тривалість роботи батареї у годинах
        public double RefreshRate; // частота оновлення екрану у ГЦ

        public double PricePerInch
        {
            get
            {
                return PPI();
            }
        }

        public double PPI()
        {
            return (double)((Price) / ScreenSize);
        }
    }
}