using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Mp3ToSoundPlayer : ISoundPlayer
    {
        Mp3Player Mp3player;

        public Mp3ToSoundPlayer(Mp3Player mp3Player)
        {
            this.Mp3player = mp3Player;
        }
        public void LoadSound(string file)
        {
            Mp3player.LoadMp3(file);
        }

        public void PlaySound()
        {
            Mp3player.PlayMp3();
        }
    }
}
