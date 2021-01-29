using System;

namespace Oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            //player ekleme kısmı

            Player player1 = new Player
            {
                Id = 1,
                FirstName = "Nihan Ece",
                LastName = "Algül",
                DateOfBirth = "13.06.1986",
                NationalityId = "12345678910"
            };

            PlayerManager playerManager = new PlayerManager(new PlayerValidationManager());
            playerManager.Add(player1);

            //oyun ekleme kısmı

            Game game1 = new Game
            {
                GameName = "Age Of Empires",
                GameCost = 20,
                GameData = 10,
                GameRating = 8,
                GameType = "Free World"
            };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            //oyun satın alma kısmı
            GameOwnerManager gameOwnerManager = new GameOwnerManager();
            gameOwnerManager.ownGame(game1, player1);

            // oyunu kampanya ile satın alma kısmı

            Kampanya kampanya1 = new Kampanya
            {
                KampanyaName = "Efsane Cuma",
                KampanyaIndirimMiktar = "70"
            };

            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.KampanyaIleSatinAl(game1, kampanya1, player1);
        }
    }
}
