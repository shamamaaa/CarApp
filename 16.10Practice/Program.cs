using _16._10Practice.Models;

namespace _16._10Practice;
class Program
{
    static void Main(string[] args)
    {
        double fuel, tankcapacity, fuelconsumption;

        while (true)
        {
            Colored.Write("Bakda qalan benzin miqdarini daxil edin : ", ConsoleColor.Magenta);
            if ((double.TryParse(Console.ReadLine(), out fuel)) && fuel>=0)
                break;
            else
                Colored.WriteLine("Sehv daxil etdiniz. Zehmet olmasa yeniden daxil edin.",ConsoleColor.Red);
        }

        while (true)
        {
            Colored.Write("Bakin tutumunu daxil edin : ", ConsoleColor.Magenta);
            if ((double.TryParse(Console.ReadLine(), out tankcapacity)) && tankcapacity>0)
                break;
            else
                Colored.WriteLine("Sehv daxil etdiniz. Zehmet olmasa yeniden daxil edin.", ConsoleColor.Red);
        }

        while (true)
        {
            Colored.Write("100 km-e ne qeder benzin sərf edir? : ", ConsoleColor.Magenta);
            if ((double.TryParse(Console.ReadLine(), out fuelconsumption)) && fuelconsumption>0)
                break;
            else
                Colored.WriteLine("Sehv daxil etdiniz. Zehmet olmasa yeniden daxil edin.", ConsoleColor.Red);
        }

        Car car = new Car(fuel, tankcapacity, fuelconsumption);


        while (true)
        {
            Colored.WriteLine("\nMenyu:",ConsoleColor.DarkMagenta);
            Colored.WriteLine("1. Sur", ConsoleColor.DarkMagenta);
            Colored.WriteLine("2. Zapravkaya gir", ConsoleColor.DarkMagenta);
            Colored.WriteLine("3. Benzini goster", ConsoleColor.DarkMagenta);
            Colored.WriteLine("4. Getdiyimiz yolu goster", ConsoleColor.DarkMagenta);

            Colored.Write("Secim edin: ",ConsoleColor.Magenta);
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    while (true)
                    {
                        Console.Write("Nece km yol gedeceksiniz: ", ConsoleColor.Magenta);
                        if (double.TryParse(Console.ReadLine(), out double distance))
                        {
                            if (car.Drive(distance))
                                Colored.WriteLine($"Qalan benzin: {car.Fuel} litr\nGedilen yol: {distance} km");
                            else
                                Colored.WriteLine("Bu yolu getmek mumkun deyil",ConsoleColor.Red);
                            break;
                        }
                        else
                            Colored.WriteLine("Sehv daxil etdiniz. Zehmet olmasa yeniden daxil edin.",ConsoleColor.Red);
                    }
                    break;

                case "2":
                    while (true)
                    {
                        Colored.WriteLine("AB104.Socar.APK Xos Geldiniz",ConsoleColor.Blue);
                        Colored.Write("Neçə litr benzin dolduracaqsınız: ", ConsoleColor.Magenta);
                        if (double.TryParse(Console.ReadLine(), out double amount))
                        {
                            car.Refuel(amount);
                            Colored.WriteLine($"Benzin doldu, bakda olan benzin: {car.Fuel} litr");
                            break;
                        }
                        else
                            Colored.WriteLine("Sehv daxil etdiniz. Zehmet olmasa yeniden daxil edin.",ConsoleColor.Red);
                    }
                    break;

                case "3":
                    Colored.WriteLine($"Bakda qalan benzin: {car.Fuel} litr", ConsoleColor.Magenta);
                    break;

                case "4":
                    Colored.WriteLine($"Getdiyimiz yol: {car.MileAge} km", ConsoleColor.Magenta);
                    break;

                default:
                    Colored.WriteLine("Yanlis secim. Zehmet olmasa duzgun secim et.",ConsoleColor.Red);
                    break;

            }



            }
        }
}

