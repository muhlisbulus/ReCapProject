using Businesss.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.Entity_Framework;
using System;

namespace ConsoleUı
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var Car in carManager.GetAll())
            {
                Console.WriteLine(Car.ModelYear);
            }

            Console.Read();
        }
    }
}
