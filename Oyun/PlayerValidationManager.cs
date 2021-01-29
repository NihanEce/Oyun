using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    public class PlayerValidationManager : IPlayerValidationService
    {
        public PlayerValidationManager()
        {

        }
        public bool Validate(Player player)
        {
            if (player.DateOfBirth == "13.06.1986" && player.Id == 1 && player.FirstName == "Nihan Ece" && player.LastName == "Algül" && player.NationalityId=="12345678910")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
