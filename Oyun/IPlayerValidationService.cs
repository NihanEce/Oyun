using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    public interface IPlayerValidationService
    {
        bool Validate(Player player);
    }
}
