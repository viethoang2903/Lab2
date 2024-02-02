using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.BussinessObject;


namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {

        //public CarRepository GetCarByID(int carId)

        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarList();

        public void InsertCar(Car car) => CarDBContext.Instance.AddNew(car);

        public void UpdateCar(Car car) => CarDBContext.Instance.UpdateNew(car);
        public void DeleteCar(int carID) => CarDBContext.Instance.Remove(carID);

        Car ICarRepository.GetCarByID(int carId) => CarDBContext.Instance.GetCarByID(carId);

    }
}
