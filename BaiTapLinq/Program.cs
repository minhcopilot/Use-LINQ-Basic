using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Car> cars = new List<Car>()
            {
                new Car("Toyota", "Camry", 1970, 220000, 5),
                new Car("Honda", "Accord", 2022, 200000, 5),
                new Car("Ford", "Taurus", 1988, 180000, 5),
                new Car("Nissan", "Altima", 2020, 150000, 5),
                new Car("Hyundai", "Sonata", 2019, 90000, 5),
            };
            List<Truck> trucks = new List<Truck>()
            {
                new Truck("Ford", "F-150", 2023, 300000, 10000,"Ford Group"),
                new Truck("Chevrolet", "Silverado", 1980, 280000, 9000,"Chevrolet Group"),
                new Truck("Hyndai", "1500", 2021, 260000, 8000,"Hyndai Group"),
                new Truck("Toyota", "Tundra", 2020, 240000, 7000,"Toyota Group"),
                new Truck("Nissan", "Titan", 1989, 220000, 6000,"Nissan Group"),
            };
            while (true)
            {
                Console.WriteLine("----- Menu chức năng -----");
                Console.WriteLine("1. Hiển thị xe có giá từ 100.000 đến 250.000");
                Console.WriteLine("2. Hiển thị xe có năm sản xuất sau 1990");
                Console.WriteLine("3. Gom xe theo hãng, tính tổng giá trị");
                Console.WriteLine("4. Hiển thị danh sách Truck theo năm sản xuất mới nhất");
                Console.WriteLine("5. Hiển thị tên công ty chủ quản của Truck");
                Console.WriteLine("0. Thoát");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Hiển thị xe có giá từ 100.000 đến 250.000
                        var filteredCars = cars.Where(c => c.Price >= 100000 && c.Price <= 250000);
                        foreach (var car in filteredCars)
                        {
                            Console.WriteLine(car);
                        }
                        break;
                    case 2:
                        // Hiển thị xe có năm sản xuất sau 1990
                        var filteredCars1 = cars.Where(c => c.Year > 1990);
                        foreach (var car in filteredCars1)
                        {
                            Console.WriteLine(car);
                        }
                        break;
                    case 3:
                        // Gom xe theo hãng, tính tổng giá trị
                        var groupedCars = cars.GroupBy(c => c.Make);
                        foreach (var group in groupedCars)
                        {
                            Console.WriteLine($"Hãng: {group.Key}");
                            Console.WriteLine($"Tổng giá trị: {group.Sum(c => c.Price)}");
                        }
                        break;
                    case 4:
                        var sortedTrucks = trucks.OrderByDescending(truck => truck.Year);
                        Console.WriteLine("\nDanh sách các Truck theo thứ tự năm sản xuất mới nhất:");
                        foreach (var truck in sortedTrucks)
                        {
                            Console.WriteLine($"Name: {truck.Make}, Year: {truck.Year}, Price: {truck.Price}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("\nTên công ty chủ quản của các Truck:");
                        foreach (var truck in trucks)
                        {
                            Console.WriteLine($"Name: {truck.Make}, Company: {truck.Company}");
                        }
                        break;
                    case 0:
                        break;
                }
            }
        }
    }
}
