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
    }
}