using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Player
    {
        public void Play(ISoundPlayer player, string file)
        {
            player.LoadSound(file);
            player.PlaySound();
        }

    }
}
