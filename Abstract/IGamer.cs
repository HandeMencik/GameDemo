using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface IGamer
    {
        void Register(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
