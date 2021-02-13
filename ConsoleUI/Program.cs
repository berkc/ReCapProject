using DataAccess.Concrete.InMemory;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //ColorTest();

            //BrandTest();

            //UserTest();

            //CustomerTest();

            //RentalTest();

            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetail();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
            }

        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAll();
            foreach (var rental in result.Data)
            {
                Console.WriteLine(rental.RentDate);
            }
            rentalManager.Add(new Rental { Id = 1, CarId = 1, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = null });
            rentalManager.Update(new Rental { Id = 1, CarId = 1, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = null });
            rentalManager.Delete(new Rental { Id = 1 });
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetAll();
            foreach (var customer in result.Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
            customerManager.Add(new Customer { CustomerId = 4, UserId = 1, CompanyName = "şirket1" });
            customerManager.Update(new Customer { CustomerId = 4, UserId = 1, CompanyName = "Berk Şirket" });
            customerManager.Delete(new Customer { CustomerId = 4 });
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();
            foreach (var user in result.Data)
            {
                Console.WriteLine(user.FirstName);
            }
            userManager.Add(new User { Id = 4, FirstName = "Berk", LastName = "Çolak", Email = "berk@mail.com", Password = "13245" });
            userManager.Update(new User { Id = 5, FirstName = "Berk", LastName = "Çolak", Email = "berk@gmail.com", Password = "123" });
            userManager.Delete(new User { Id = 4 });
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine(brandManager.GetById(1));

            brandManager.Add(new Brand { BrandId = 4, BrandName = "Mercedes" });

            brandManager.Update(new Brand { BrandId = 4, BrandName = "Tofaş" });

            brandManager.Delete(new Brand { BrandId = 4 });
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            foreach (var color in result.Data)
            {
                Console.WriteLine(color.ColorName);
            }

            Console.WriteLine(colorManager.GetById(1));

            colorManager.Add(new Color { ColorId = 4, ColorName = "Gri" });

            colorManager.Update(new Color { ColorId = 4, ColorName = "Bordo" });

            colorManager.Delete(new Color { ColorId = 4 });
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName);
            }

            Console.WriteLine(carManager.GetById(1));

            carManager.Add(new Car { Id = 4, BrandId = 4, ColorId = 4, DailyPrice = 400, Description = "Dizel", ModelYear = 20201 });

            carManager.Update(new Car { Id = 4, BrandId = 2, ColorId = 3, DailyPrice = 250, Description = "Dizel", ModelYear = 2019 });

            carManager.Delete(new Car { Id = 4 });
        }
    }
}
