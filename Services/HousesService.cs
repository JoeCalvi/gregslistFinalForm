using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregslistFinalForm.Services
{
    public class HousesService
    {
        private readonly HousesRepository _repo;

        public HousesService(HousesRepository repo)
        {
            _repo = repo;
        }
        internal List<House> FindAll()
        {
            List<House> houses = _repo.FindAll();
            return houses;
        }
    }
}