using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Del(Game game);
        void Update(Game game);
            
    }
}
