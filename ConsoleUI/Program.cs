using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //JoinIslemi();
            //CarDetailTest();
            RentalAddedTest();
            //UserAddedTest();
            //CustomerAddedTest();


        }

        //private static void CustomerAddedTest()
        //{
        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        //    customerManager.Add(new Customer { UserId = 2, CompanyName = "i30" });
        //    Console.WriteLine(customerManager.GetAll().Messages);
        //}

        //private static void UserAddedTest()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    userManager.Add(new User { FirstName = "Ece Nur", LastName = "DOĞAN", Email = "ecenr502@gmail.com", Password = "123" });
        //    Console.WriteLine(userManager.GetAll().Success);
        //}

        private static void RentalAddedTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = DateTime.Now,
                ReturnDate = new DateTime(2021, 02, 22)
            });
            
        }

        //private static void CarDetailTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    var result = carManager.GetCarDetails();
        //    if (result.Success == true)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            Console.WriteLine(car.CarName + "/" + car.DailyPrice);
        //        }

        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Messages);
        //    }
        //}

        //private static void JoinIslemi()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetCarDetails())
        //    {
        //        Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
        //    }


        //}

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    foreach (var Brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(Brand.BrandName);
        //    }
        //}

        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());


        //    Console.WriteLine("Id     Model      Günlük Ücreti     Açıklama");
        //    Console.WriteLine("__________________________________________________");
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.CarId + "      " + car.ModelYear + "           " + car.DailyPrice + "         " + car.Description);
        //    }

        //    Console.WriteLine("\n\nBrandId'si 1 Olan Araçların Listelenmesi");
        //    Console.WriteLine("__________________________________________________");
        //    foreach (var car in carManager.GetCarsByBrandId(1))
        //    {
        //        Console.WriteLine(car.Description);
        //    }

        //    Console.WriteLine("\n\nColorId'si 2 Olan Araçların Listelenmesi");
        //    Console.WriteLine("__________________________________________________");
        //    foreach (var car in carManager.GetCarsByColorId(2))
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //    Console.WriteLine("\n\nYeni Araç Ekleme Ve Tüm Listenin Tekrar Listelenmesi");
        //    Console.WriteLine("__________________________________________________");
        //    carManager.Add(new Car { CarId = 7, BrandId = 4, ColorId = 1, DailyPrice = 500, Description = "Tesla Model 3", ModelYear = 2015 });
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.CarId + "      " + car.ModelYear + "           " + car.DailyPrice + "         " + car.Description);
        //    }
        //}
    }
}
