using System;
using System.Threading.Channels;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            //AddCar();
            //AddBrand();
            //AddColor();

            CarTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " | " + car.BrandName + " | " + car.ColorName + " ");
            }
        }

        private static void AddColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color {ColorId = 1, ColorName = "Siyah"});
            colorManager.Add(new Color {ColorId = 2, ColorName = "Beyaz"});
            colorManager.Add(new Color {ColorId = 3, ColorName = "Mavi"});
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void AddBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand
            {
                BrandId = 1,
                BrandName = "Mazda"
            });
            brandManager.Add(new Brand
            {
                BrandId = 2,
                BrandName = "Honda"
            });
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void AddCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                Id = 1,
                Description = "Honda 2006",
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 2000,
                ModelYear = 2005
            });
        }

        private static void Test1()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("---------------------------------");

            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.Description);
            }

            Console.WriteLine("-----------------------------------");

            foreach (var car in carManager.GetByBrandId(3))
            {
                Console.WriteLine(car.Description + " : " + car.BrandId + "\n");
            }

            Console.WriteLine("--------------------------------------");
            foreach (var car in carManager.GetUnitPrice(20000, 25000))
            {
                Console.WriteLine(car.Description + " : " + car.BrandId + "\n");
            }
        }
    }
}
