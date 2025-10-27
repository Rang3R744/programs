namespace Lab04
{
    public class Tablet
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double ScreenSize { get; set; }
        public int Storage { get; set; }
        public bool HasMobileNetwork { get; set; }
        public double Price { get; set; }
        public double BatteryLife { get; set; }
        public int RefreshRate { get; set; }

        public Tablet() { }

        public Tablet(string brand, string model, double screenSize, int storage,
                      bool hasMobileNetwork, decimal price, double batteryLife, int refreshRate)
        {
            Brand = brand;
            Model = model;
            ScreenSize = screenSize;
            Storage = storage;
            HasMobileNetwork = hasMobileNetwork;
            Price = (double)price;
            BatteryLife = batteryLife;
            RefreshRate = refreshRate;
        }
    }
}