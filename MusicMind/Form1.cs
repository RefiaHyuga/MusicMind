using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicMind
{
    public partial class Form1 : Form {
        bool Play = false;
        bool Sound = true;
        string[] ArchivosMP3;
        string[] rutasArchivosMP3;

        public Form1() {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog();
            CajaDeBusquedaDeArchivos.Multiselect = true;
            if (CajaDeBusquedaDeArchivos.ShowDialog()==System.Windows.Forms.DialogResult.OK) {
                ArchivosMP3 = CajaDeBusquedaDeArchivos.SafeFileNames;
                rutasArchivosMP3 = CajaDeBusquedaDeArchivos.FileNames;
                foreach(var ArchivoMP3 in ArchivosMP3) {
                    listCanciones.Items.Add(ArchivosMP3);
                }
                Reproductor.URL = rutasArchivosMP3[0];
                listCanciones.SelectedIndex = 0;
                btnPlay.Image = Properties.Resources.Button_4_512; //boton pause
            }
        }

        private void listCanciones_SelectedIndexChanged(object sender, EventArgs e) {
            Reproductor.URL = rutasArchivosMP3[listCanciones.SelectedIndex];
            lbCancion.Text = ArchivosMP3[listCanciones.SelectedIndex];
        }

        private void btnPlay_Click(object sender, EventArgs e) {
            switch (Play) {
                case true:
                    Reproductor.Ctlcontrols.pause();
                    btnPlay.Image = Properties.Resources.Button_3_512; //boton play
                    Play = false;
                    break;
                case false:
                    Reproductor.Ctlcontrols.play();
                    btnPlay.Image = Properties.Resources.Button_4_512; //boton pause
                    Play = true;
                    break;
            }
        }

        private void btnStop_Click(object sender, EventArgs e) {
            Reproductor.Ctlcontrols.stop();
            btnPlay.Image = Properties.Resources.Button_3_512; //boton play
            Play = false;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            ActualizarDatosTrack();
            mtrackCancion.Value = (int)Reproductor.Ctlcontrols.currentPosition;
            mtrackVolumen.Value = Reproductor.settings.volume;
        }
        public void ActualizarDatosTrack() {
            if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying) {
                //Control del tiempo maximo del mp3 actual
                mtrackCancion.Maximum = (int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused) {
                timer1.Stop();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsStopped) {
                timer1.Stop();
                mtrackCancion.Value = 0;
            }
        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarDatosTrack();
        }

        private void mtrackVolumen_ValueChanged(object sender, decimal value)
        {
            Reproductor.settings.volume = mtrackVolumen.Value;
            if(Reproductor.settings.volume == 0)
            {
                btnVolumen.Image = Properties.Resources.sound_button_icon_sin; //boton sinsonido
                Sound = false;
            }
            else {
                btnVolumen.Image = Properties.Resources.sound_button_icon_76357; //boton sonido
                Sound = true;
            }
        }

        private void btnVolumen_Click(object sender, EventArgs e)
        {
            switch (Sound)
            {
                case true:
                    btnVolumen.Image = Properties.Resources.sound_button_icon_sin; //boton sinsonido
                    Reproductor.settings.volume = 0;
                    Sound = false;
                    break;
                case false:
                    btnVolumen.Image = Properties.Resources.sound_button_icon_76357; //boton sonido
                    Reproductor.settings.volume = 50;
                    Sound = true;
                    break;
            }
        }
    }
}
