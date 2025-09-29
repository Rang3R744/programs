using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2Lib;

namespace Lab2App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість планшетів: ");
            int cntTablets = int.Parse(Console.ReadLine());
            Tablet[] arrTablets = new Tablet[cntTablets];
            for (int i = 0; i < cntTablets; i++)
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

                Console.Write("Введіть частоту оновлення екрану планшету (в ГЦ): ");
                string refreshrateStr = Console.ReadLine();

                Tablet myTablet = new Tablet();
                myTablet.Brand = brand;
                myTablet.Model = model;
                myTablet.ScreenSize = double.Parse(screenSizeStr);
                myTablet.Storage = int.Parse(storageStr);
                myTablet.HasCellular = keyHasCellular.Key == ConsoleKey.Y ? true : false;
                myTablet.Price = double.Parse(priceStr);
                myTablet.BatteryLife = int.Parse(batteryLifeStr);
                myTablet.RefreshRate = double.Parse(refreshrateStr);
                arrTablets[i] = myTablet;

            }
            foreach (Tablet t in arrTablets)
            {

                Console.WriteLine("\nІнформація про планшет:");
                Console.WriteLine("------------------------");
                Console.WriteLine("Бренд: " + t.Brand);
                Console.WriteLine("Модель: " + t.Model);
                Console.WriteLine("Розмір екрана: " + t.ScreenSize + " дюймів");
                Console.WriteLine("Пам’ять: " + t.Storage + " ГБ");
                Console.WriteLine("Підтримка мобільної мережі: " + (t.HasCellular ? "Так" : "Ні"));
                Console.WriteLine("Ціна: $" + t.Price.ToString("0.00"));
                Console.WriteLine("Час роботи: " + t.BatteryLife + " годин");
                Console.WriteLine("Частота оновлення: " + t.RefreshRate + " ГЦ");
                Console.WriteLine("Ціна за дюйм екрану: " + t.PricePerInch);

                Console.ReadKey();
            }
        }
    }
}