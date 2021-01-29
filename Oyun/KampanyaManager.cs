using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    public class KampanyaManager : IKampanyaService
    {
        public void KampanyaIleSatinAl(Game game, Kampanya kampanya, Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName +  " adlı kullanıcı"  + " , " + game.GameName + " " + "oyununu %"  + kampanya.KampanyaIndirimMiktar + " " + "indirim ile" + " " + kampanya.KampanyaName + " " + "kampanyasından faydalanarak satın aldı");
        }
    }
}
