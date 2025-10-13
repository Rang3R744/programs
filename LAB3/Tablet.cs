using System;

namespace TabletApp
{
    public class Tablet
    {
        public string Brand;
        public string Model;
        public int ScreenSize;
        public int Storage;
        public int Price;
        public int RefreshRate;

        public override string ToString()
        {
            string info = $"Бренд: {Brand}\nМодель: {Model}\nРозмір екрану (дюйми): {ScreenSize}\nОбсяг пам'яті (ГБ): {Storage}\nЦіна (долари): {Price}\nЧастота оновлення (ГЦ): {RefreshRate}\n";

            return info;
        }
    }
}