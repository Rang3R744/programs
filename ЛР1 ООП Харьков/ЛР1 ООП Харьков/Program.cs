using System;

class Tablet
{
    public string Brand;
    public string Model;
    public double ScreenSize; // дюйми
    public int Storage;       // гігабайти
    public bool HasCellular;  // наявність мобільної мережі
    public double Price;      // ціна в доларах
    public int BatteryLife;   // тривалість роботи батареї у годинах

    public double PricePerInch()
    {
        return Price / ScreenSize;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть бренд планшета: ");
        string brand = Console.ReadLine();

        Console.Write("Введіть модель планшета: ");
        string model = Console.ReadLine();

        Console.Write("Введіть розмір екрана (в дюймах): ");
        string screenSizeStr = Console.ReadLine();

        Console.Write("Введіть обсяг пам’яті (в ГБ): ");
        string storageStr = Console.ReadLine();

        Console.Write("Чи має планшет підтримку мобільної мережі? (y - так, n - ні): ");
        ConsoleKeyInfo keyHasCellular = Console.ReadKey();
        Console.WriteLine();

        Console.Write("Введіть ціну планшета (в $): ");
        string priceStr = Console.ReadLine();

        Console.Write("Введіть тривалість роботи батареї (годин): ");
        string batteryLifeStr = Console.ReadLine();

        Tablet myTablet = new Tablet();
        myTablet.Brand = brand;
        myTablet.Model = model;
        myTablet.ScreenSize = double.Parse(screenSizeStr);
        myTablet.Storage = int.Parse(storageStr);
        myTablet.HasCellular = keyHasCellular.Key == ConsoleKey.Y ? true : false;
        myTablet.Price = double.Parse(priceStr);
        myTablet.BatteryLife = int.Parse(batteryLifeStr);

        double pricePerInch = myTablet.PricePerInch();

        Console.WriteLine("\nІнформація про планшет:");
        Console.WriteLine("------------------------");
        Console.WriteLine("Бренд: " + myTablet.Brand);
        Console.WriteLine("Модель: " + myTablet.Model);
        Console.WriteLine("Розмір екрана: " + myTablet.ScreenSize + " дюймів");
        Console.WriteLine("Пам’ять: " + myTablet.Storage + " ГБ");
        Console.WriteLine("Підтримка мобільної мережі: " + (myTablet.HasCellular ? "Так" : "Ні"));
        Console.WriteLine("Ціна: $" + myTablet.Price.ToString("0.00"));
        Console.WriteLine("Час роботи: " + myTablet.BatteryLife + " годин");
        Console.WriteLine("Ціна за дюйм екрана: $" + pricePerInch.ToString("0.00"));

        Console.ReadKey();
    }
}
