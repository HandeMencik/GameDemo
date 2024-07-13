using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
    public class Gamer
    {
        public int Id { get; set; }
        public string GamerName { get; set; }
        public string GamerLastName { get; set; }
        public string TCKimlikNo { get; set; }
        public DateTime BirthYear { get; set; }
    }
}
