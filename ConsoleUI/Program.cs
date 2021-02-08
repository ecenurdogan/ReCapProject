using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("Id     Model      Günlük Ücreti     Açıklama");
            Console.WriteLine("__________________________________________________");
            foreach (var car in carManager.GetAll())
            {               
                Console.WriteLine(car.Id +"      "+ car.ModelYear+ "           " + car.DailyPrice+ "         " + car.Description);
            }
        }
    }
}
