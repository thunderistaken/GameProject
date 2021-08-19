using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun sisteme eklendi " + game.GameName + ". Fiyatı " + game.GamePrice );
        }

        public void Del(Game game)
        {
            Console.WriteLine("Oyun sistemden silindi " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi " + game.GameName);
        }
    }
}
