using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    public class GameOwnerManager : IGameOwnerService
    {
        public void ownGame(Game game, Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " , " + game.GameName + " " + "oyununu satın aldı.");
        }
    }
}
