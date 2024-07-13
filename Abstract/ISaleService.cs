using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface ISaleService
    {
        void Sale(Gamer gamer, Game game, Campaign campaign);
    }
}
