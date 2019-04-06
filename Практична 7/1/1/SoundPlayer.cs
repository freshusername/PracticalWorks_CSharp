using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class SoundPlayer : ISoundPlayer
    {
        private readonly Lazy<System.Media.SoundPlayer> _lazySoundPlayer = new Lazy<System.Media.SoundPlayer>();
        public void LoadSound(string file)
        {
            this._lazySoundPlayer.Value.SoundLocation = file;
            this._lazySoundPlayer.Value.Load();
        }

        public void PlaySound()
        {
            _lazySoundPlayer.Value.Play();
        }
    }
}
