using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool mediaPlayerIsPlaying = false;
        private bool userIsDraggingSlider = false;

        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if ((mePlayer.Source != null) && (mePlayer.NaturalDuration.HasTimeSpan) && (!userIsDraggingSlider))
            {
                sliProgress.Minimum = 0;
                sliProgress.Maximum = mePlayer.NaturalDuration.TimeSpan.TotalSeconds;
                sliProgress.Value = mePlayer.Position.TotalSeconds;
            }
        }

        private void Open_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Media files (*.mp3;*.mpg;*.mpeg)|*.mp3;*.mpg;*.mpeg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                mePlayer.Source = new Uri(openFileDialog.FileName);
        }

        private void Play_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (mePlayer != null) && (mePlayer.Source != null);
        }

        private void Play_Executed(object sender, ExecutedRoutedEventArgs e)
        {
                //txtNowPlaying.Text = mePlayer.Source.ToString();
                mePlayer.Play();
                mediaPlayerIsPlaying = true;
        }

        private void Pause_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying;
        }

        private void Pause_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mePlayer.Pause();
        }

        private void Stop_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying;
        }

        private void Stop_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mePlayer.Stop();
            mediaPlayerIsPlaying = false;
        }

        private void sliProgress_DragStarted(object sender, DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
        }

        private void sliProgress_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            mePlayer.Position = TimeSpan.FromSeconds(sliProgress.Value);
        }

        private void sliProgress_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblProgressStatus.Text = TimeSpan.FromSeconds(sliProgress.Value).ToString(@"hh\:mm\:ss");
        }

        private void Grid_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            mePlayer.Volume += (e.Delta > 0) ? 0.1 : -0.1;
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {
            ISoundPlayer player = new SoundPlayer();
            string wavFile = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Media files (*.wav;)|*.wav;|All files (*.*)|*.*";//*.mpg;*.mpeg;*.mp4;)|*.mp3;*.mpg;*.mpeg;*.mp4;|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                wavFile = openFileDialog.FileName;
                txtNowPlaying.Text = "Wav File";
                mePlayer.Source = new Uri(wavFile);
            }

            // play the audio file
            //if (!string.IsNullOrEmpty(wavFile))
            //{
            //    player.LoadSound(wavFile);
            //    player.PlaySound();
            //}
        }

        private void BtnTest1_Click(object sender, RoutedEventArgs e)
        {
            Mp3Player mp3player = new Mp3Player();
            ISoundPlayer mp3Player = new Mp3ToSoundPlayer(mp3player);
            Player player = new Player();

            string mp3File = string.Empty;


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Media files (*.mp3;)|*.mp3;|All files (*.*)|*.*";//*.mpg;*.mpeg;*.mp4;)|*.mp3;*.mpg;*.mpeg;*.mp4;|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                mp3File = openFileDialog.FileName;
                txtNowPlaying.Text = "Mp3 File";
                mePlayer.Source = new Uri(mp3File);
            }

            ////play the audio file
            //if (!string.IsNullOrEmpty(mp3File))
            //{
            //    player.Play(mp3Player, mp3File);

            //}
        }

        //private void btnOpenAudioFile_Click(object sender, RoutedEventArgs e)
        //{
        //    MediaPlayer mediaPlayer = new MediaPlayer();

        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
        //    if (openFileDialog.ShowDialog() == true)
        //    {
        //        mediaPlayer.Open(new Uri(openFileDialog.FileName));
        //        mediaPlayer.Play();
        //    }
        //}
    }
  

}
