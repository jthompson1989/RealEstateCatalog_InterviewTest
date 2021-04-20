using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateCatalog.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Addresss { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int SalesPrice { get; set; }
        public int SquareFoot { get; set; }
    }
}
