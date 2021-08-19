using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public  class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Oyuncu eklendi. Hoşgeldin " + gamer.FirstName);
        }
        public void Del(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi. Görüşmek Üzere " + gamer.FirstName);

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi.  " + gamer.FirstName);

        }

    
    }
}
