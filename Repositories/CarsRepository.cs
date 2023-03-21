using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregslistFinalForm.Repositories
{
    public class CarsRepository
    {
        private readonly IDbConnection _db;

        public CarsRepository(IDbConnection db)
        {
            _db = db;
        }
        internal List<Car> FindAll()
        {
            string sql = @"
            SELECT
            *
            FROM cars;
            ";
            List<Car> cars = _db.Query<Car>(sql).ToList();
            return cars;
        }
    }
}