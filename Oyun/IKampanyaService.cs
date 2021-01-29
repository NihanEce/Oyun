using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    public interface IKampanyaService
    {
        void KampanyaIleSatinAl(Game game, Kampanya kampanya, Player player);
    }
}
