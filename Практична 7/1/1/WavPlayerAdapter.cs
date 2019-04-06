using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class AudioPlayerAdapter : IMediaPlayer
    {
        private readonly Lazy<SoundPlayer> _lazySoundPlayer = new Lazy<SoundPlayer>();
        public void Load(string file)
        {
            this._lazySoundPlayer.Value.SoundLocation = file;
            this._lazySoundPlayer.Value.Load();
        }

        public void Play()
        {
            _lazySoundPlayer.Value.Play();
        }
    }
}
