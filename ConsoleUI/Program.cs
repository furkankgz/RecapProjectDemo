using System;
using System.Collections.Generic;
using System.Threading.Channels;
using Business.Concrete;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddCar();
            //AddBrand();
            //AddColor();
            //CarTest();
            //CarGetAll();
            //AddCustomer();
            //AddRental();
        }

        private static void AddRental()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental
            {
                RentalId = 1, CarId = 1, CustomerId = 1, RentDate = new DateTime(2021, 9, 18),
                ReturnDate = new DateTime(2021, 9, 20)
            });
            rentalManager.Add(new Rental
            {
                RentalId = 2,
                CarId = 2,
                CustomerId = 2,
                RentDate = new DateTime(2021, 9, 15),
                ReturnDate = new DateTime(2021, 9, 19)
            });
            rentalManager.Add(new Rental
            {
                RentalId = 3,
                CarId = 3,
                CustomerId = 3,
                RentDate = new DateTime(2021, 9, 16),
                ReturnDate = new DateTime(2021, 9, 18)
            });
            var result = rentalManager.GetAll();
            if (result.Success == true)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.ReturnDate + " " + rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

       

        private static void AddCustomer()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer {CustomerId = 1, UserId = 1, CompanyName = "ETS"});
            customerManager.Add(new Customer {CustomerId = 2, UserId = 2, CompanyName = "DTO"});
            customerManager.Add(new Customer {CustomerId = 3, UserId = 3, CompanyName = "YKS"});
            customerManager.Add(new Customer {CustomerId = 4, UserId = 4, CompanyName = "TYT"});
            var result = customerManager.GetAll();
            if (result.Success == true)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description + " " + car.DailyPrice + " tl");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " | " + car.BrandName + " | " + car.ColorName + " ");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void AddColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color {ColorId = 1, ColorName = "Siyah"});
            colorManager.Add(new Color {ColorId = 2, ColorName = "Beyaz"});
            colorManager.Add(new Color {ColorId = 3, ColorName = "Mavi"});

            var result = colorManager.GetAll();

            if (result.Success == true)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
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
            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void AddCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                Id = 1,
                Description = "Mazda 2006",
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 2000,
                ModelYear = 2006
            });
            carManager.Add(new Car
            {
                Id = 2,
                Description = "Honda 2005",
                BrandId = 2,
                ColorId = 2,
                DailyPrice = 1500,
                ModelYear = 2005
            });
            carManager.Add(new Car
            {
                Id = 3,
                Description = "Honda 2010",
                BrandId = 2,
                ColorId = 2,
                DailyPrice = 5000,
                ModelYear = 2010
            });
            carManager.Add(new Car
            {
                Id = 4,
                Description = "Mazda 2012",
                BrandId = 1,
                ColorId = 2,
                DailyPrice = 7000,
                ModelYear = 2012
            });
            carManager.Add(new Car
            {
                Id = 5,
                Description = "Mazda 2009",
                BrandId = 1,
                ColorId = 2,
                DailyPrice = 3000,
                ModelYear = 2009
            });
            carManager.Add(new Car
            {
                Id = 6,
                Description = "Mazda 2007",
                BrandId = 1,
                ColorId = 1,
                DailyPrice = 4500,
                ModelYear = 2007
            });
            carManager.Add(new Car
            {
                Id = 7,
                Description = "Honda 2008",
                BrandId = 2,
                ColorId = 1,
                DailyPrice = 4500,
                ModelYear = 2008
            });
            carManager.Add(new Car
            {
                Id = 8,
                Description = "Honda 2006",
                BrandId = 2,
                ColorId = 1,
                DailyPrice = 2200,
                ModelYear = 2006
            });
            carManager.Add(new Car
            {
                Id = 9,
                Description = "Honda 2005",
                BrandId = 2,
                ColorId = 1,
                DailyPrice = 1500,
                ModelYear = 2005
            });
        }

    }
}
