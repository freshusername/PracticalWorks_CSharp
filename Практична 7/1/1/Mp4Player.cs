using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using MP = MediaPlayer;

namespace _1
{
    class Mp4Player : IMp4Player
    {
        WMPLib.WindowsMediaPlayer Player;
        public void LoadMp4(string file)
        {
            MP.MediaPlayer mediaPlayer = new MP.MediaPlayer();

            

        }
       

        //private void Player.MediaError(object pMediaObject)
        //{
        //    MessageBox.Show("Cannot play media file.");
        //}

        public void PlayMp4()
        {
            
        }
    }
}
