using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    public class PlayerManager : IPlayerService
    {
        IPlayerValidationService _playerValidationService; // burası nedir??

        public PlayerManager(IPlayerValidationService playerValidationService)
        {
            _playerValidationService = playerValidationService;
        }
        
        public void Add(Player player)
        {
            if(_playerValidationService.Validate(player) == true)
            {
                Console.WriteLine("Kayıt İşlemi Başarılı.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
