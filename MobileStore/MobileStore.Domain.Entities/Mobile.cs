using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.Domain.Entities
{
    public class Mobile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string CommonName { get; set; }
        public string UniqueName { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
    }
}
