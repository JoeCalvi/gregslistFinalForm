using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregslistFinalForm.Services
{
    public class CarsService
    {
        private readonly CarsRepository _repo;

        public CarsService(CarsRepository repo)
        {
            _repo = repo;
        }
        internal List<Car> FindAll()
        {
            List<Car> cars = _repo.FindAll();
            return cars;
        }

        internal Car FindOne(int id)
        {
            Car car = _repo.FindOne(id);
            if(car == null) throw new Exception("Car does not exist.");
            return car;
        }

        internal Car Create(Car carData)
        {
            Car car = _repo.Create(carData);
            return car;
        }

        internal Car Update(Car updateData)
        {
            Car original = this.FindOne(updateData.Id);
            original.Make = updateData.Make != null ? updateData.Make : original.Make;
            original.Model = updateData.Model != null ? updateData.Model : original.Model;
            original.Year = updateData.Year != 0 ? updateData.Year : original.Year;
            original.Price = updateData.Price != null ? updateData.Price : original.Price;
            original.Description = updateData.Description != null ? updateData.Description : original.Description;
            original.ImgUrl = updateData.ImgUrl != null ? updateData.ImgUrl : original.ImgUrl;
            original.Color = updateData.Color != null ? updateData.Color : original.Color;
            int rowsAffected =  _repo.Update(original);
            if(rowsAffected == 0) throw new Exception("Nothing was altered for some reason.");
            if(rowsAffected > 1) throw new Exception("You changed more than 1 object...check db.");
            return original;
        }

        internal string Remove(int id)
        {
            Car car = this.FindOne(id);
            bool result = _repo.Remove(id);
            if(!result) throw new Exception("Car does not exist.");
            return "Car deleted.";
        }
    }
}