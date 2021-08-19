using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Del(Gamer gamer);
        void Update(Gamer gamer);
    }
}
