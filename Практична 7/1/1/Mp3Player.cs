using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using MP = MediaPlayer;

namespace _1
{
    class Mp3Player : IMp3Player
    {

        //private readonly Lazy<MediaPlayer> _lazyMediaPlayer = new Lazy<MediaPlayer>();
        MP.MediaPlayer mediaPlayer = new MP.MediaPlayer();

        public void LoadMp3(string file)
        {
            mediaPlayer.Open(file);
        }

        public void PlayMp3()
        {
            mediaPlayer.Play();
        }
    }
}
