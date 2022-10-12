using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Strona_Restauracja.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool HasDelivery { get; set; }
        public string ContactEmali { get; set; }
        public string ContactNumer { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public virtual List<Dish> Dishes{ get; set; }
    }
}
