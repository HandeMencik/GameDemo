using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concerete
{
    public class GamerManager : IGamer
    {
        IUserCheckService _userCheckService;

        public GamerManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }



        //mernis gelicek
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı silindi.");
        }

        public void Register(Gamer gamer)
        {
            if (_userCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.GamerName+" "+gamer.GamerLastName+"  Kayıt oluşturuldu!");
            }
            else
            {
                Console.WriteLine("Kayıt Oluşturulamadı.");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Güncellendi.");
        }
    }
}
