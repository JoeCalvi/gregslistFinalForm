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

        internal Car FindOne(int id)
        {
            string sql = @"
            SELECT
            *
            FROM cars
            WHERE id = @id;
            ";
            Car car = _db.Query<Car>(sql, new { id }).FirstOrDefault();
            return car;
        }

        internal Car Create(Car carData)
        {
            string sql = @"
            INSERT INTO cars
            (make, model, year, price, imgURL, color, description)
            VALUES
            (@make, @model, @year, @price, @imgURL, @color, @description);
            SELECT LAST_INSERT_ID();
            ";
            int id = _db.ExecuteScalar<int>(sql, carData);
            carData.Id = id;
            return carData;
        }

        internal int Update(Car original)
        {
            string sql = @"
            UPDATE cars
            SET 
            make = @make,
            model = @model,
            year = @year,
            price = @price,
            description = @description,
            imgURL = @imgURL,
            color = @color
            WHERE id = @id;
            ";
            int rows = _db.Execute(sql, original);
            return rows;
        }

        internal bool Remove(int id)
        {
            string sql = @"
            DELETE FROM cars WHERE id = @id;
            ";
            int rows = _db.Execute(sql, new { id });
            return rows == 1;
        }
    }
}