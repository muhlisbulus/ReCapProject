using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleU
{
    public class Program
    {

        static void Main(string[] args)
        {
            CarDtoTest();


            Console.WriteLine("");
        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.DailyPrice);
            //}
            
            }
        private static void CarDtoTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarName + " " +car.BrandName + " " +car.DailyPrice + " " +car.ColorName);
            //}
        }
    }
}
