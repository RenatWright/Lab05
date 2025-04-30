using System;
using Lab05Lib;

class Program
{
    static void Main()
    {
        Console.Write("Введiть кiлькiсть фотоапаратiв: ");
        int count = int.Parse(Console.ReadLine());
        Camera[] cameras = new Camera[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\n--- Фотоапарат #{i + 1} ---");
            Camera cam = new Camera();

            Console.Write("Бренд: ");
            cam.Brand = Console.ReadLine();
            Console.Write("Модель: ");
            cam.Model = Console.ReadLine();
            Console.Write("Тип: ");
            cam.Type = Console.ReadLine();
            Console.Write("Мегапiкселiв: ");
            cam.Megapixels = double.Parse(Console.ReadLine());
            Console.Write("Цiна: ");
            cam.Price = double.Parse(Console.ReadLine());
            Console.Write("Вага (г): ");
            cam.Weight = double.Parse(Console.ReadLine());

            Console.Write("Має Wi-Fi? (y/n): ");
            cam.HasWiFi = Console.ReadKey().Key == ConsoleKey.Y;
            Console.WriteLine();
            Console.Write("Має 4K вiдео? (y/n): ");
            cam.Has4KVideo = Console.ReadKey().Key == ConsoleKey.Y;
            Console.WriteLine();

            cameras[i] = cam;
        }

        Console.WriteLine("\n--- Результати ---");
        foreach (Camera cam in cameras)
        {
            Console.WriteLine($"\nБренд: {cam.Brand}");
            Console.WriteLine($"Модель: {cam.Model}");
            Console.WriteLine($"Тип: {cam.Type}");
            Console.WriteLine($"Мегапiкселiв: {cam.Megapixels:0.0}");
            Console.WriteLine($"Цiна: {cam.Price:0.00} грн");
            Console.WriteLine($"Вага: {cam.Weight:0.0} г");
            Console.WriteLine(cam.HasWiFi ? "Має Wi-Fi" : "Не має Wi-Fi");
            Console.WriteLine(cam.Has4KVideo ? "Має 4K відео" : "Не має 4K відео");
            Console.WriteLine($"Цiна за 1 мегапiксель: {cam.PricePerMegapixel:0.00} грн");
            Console.WriteLine(cam.IsProfessional ? "Камера професiйна" : "Камера аматорська");
        }

        Console.ReadKey();
    }
}
