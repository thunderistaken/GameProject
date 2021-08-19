using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface ISaleManager
    {
        void Sale(Game game, Gamer gamer, Campaign campaign);
    }
}
