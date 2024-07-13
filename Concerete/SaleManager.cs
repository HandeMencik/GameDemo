using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concerete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.GamerName+" "+gamer.GamerLastName+ "  bought  " + game.GameName);
        }
    }
}
