using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);

    }
}
