using System;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { BrandId = 4, ColorId = 1, DailyPrice = 570, Description = "Toyota Corolla", ModelYear = 2018 });
            //carManager.Delete(new Car { CarId = 17 });
            //carManager.Update(new Car { CarId = 5, ColorId = 4, ModelYear = 2016, BrandId = 2, DailyPrice = 430, Description = "Fiat Egea" });

            var result = carManager.GetCarDetails();

            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " / " + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


            Console.WriteLine("------------");

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.DailyPrice);
            }
            Console.WriteLine("------------");

            foreach (var car in carManager.GetCarsByColorId(1).Data)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
