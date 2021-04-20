using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealEstateCatalog.Models;

namespace RealEstateCatalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HouseController
    {
        private static readonly House[] HouseList = new[]
        {
            new House { Id = 1, Addresss  = "8815 Penn Glen Pl", City = "Bloomington", State = "MN", SalesPrice = 380000, SquareFoot = 2985 },
            new House { Id = 2, Addresss  = "88 Rickon Rd", City = "Hopkin", State = "MN", SalesPrice = 350000, SquareFoot = 1985 },
            new House { Id = 3, Addresss  = "703 Granite St", City = "Cloquet", State = "MN", SalesPrice = 280000, SquareFoot = 1855 }
        };

        private readonly ILogger<HouseController> _logger;

        public HouseController(ILogger<HouseController> logger)
        {
            //_logger = logger;
        }

        [HttpGet]
        [Route("{id:int}", Name = nameof(GetHouse))]
        public House GetHouse(int id)
        {
            var result = HouseList.Where(hl => hl.Id == id).Single();

            return result;
        }

        [HttpGet]
        [Route("GetHouses")]
        public List<House> GetHouses()
        {
            var result = HouseList.ToList();

            return result;
        }

        //Insert House Method Goes Here
    }
}
