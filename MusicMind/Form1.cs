using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

using NeuroSky.ThinkGear;
using NeuroSky.ThinkGear.Algorithms;

namespace MusicMind
{
    public partial class Form1 : Form {
        bool Play = false;
        bool Sound = true;
        int Modo = 1;
        string[] ArchivosMP3;
        string[] rutasArchivosMP3;

        bool Conectado = false;

        static Connector connector;
        static byte poorSig;
        static byte Atencion;
        static byte Meditacion;

        public Form1() {
            InitializeComponent();

            poorSig = 100;
            Conectado = false;

            // Initialize a new Connector and add event handlers
            connector = new Connector();
            connector.DeviceConnected += new EventHandler(OnDeviceConnected);
            connector.DeviceConnectFail += new EventHandler(OnDeviceFail);
            connector.DeviceValidating += new EventHandler(OnDeviceValidating);

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog();
            CajaDeBusquedaDeArchivos.Multiselect = true;
            if (CajaDeBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArchivosMP3 = CajaDeBusquedaDeArchivos.SafeFileNames;
                rutasArchivosMP3 = CajaDeBusquedaDeArchivos.FileNames;
                listCanciones.Items.Clear();
                foreach (var ArchivoMP3 in ArchivosMP3)
                {
                    listCanciones.Items.Add(ArchivoMP3);
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
            int sig = 100 - poorSig;
            lbsignal.Text = " " + sig;
            lblAtencion.Text = "Atencion " + Atencion;
            lbRelajacion.Text = "Meditacion " + Meditacion;
            mtrackcolores(mtrackAtencion,Atencion);
            mtrackcolores(mtrackRelajacion,Meditacion);

            if (Conectado)
            {
                if (poorSig == 0 && Atencion!=0)
                {
                    btnConectado.Image = Properties.Resources.connected_v1;
                }
                else
                {
                    btnConectado.Image = Properties.Resources.connecting2_v1;
                }

            }

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

        public void mtrackcolores(XComponent.SliderBar.MACTrackBar mtrack, byte valor)
        {
            mtrack.Value = valor;
            if (valor < 25) {
                mtrack.TrackerColor = Color.Red;
            }
            else if(valor < 75) {
                mtrack.TrackerColor = Color.Gray;
            }
            else {
                mtrack.TrackerColor = Color.Green;
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

        // Called when a device is connected 
        static void OnDeviceConnected(object sender, EventArgs e)
        {
            Connector.DeviceEventArgs de = (Connector.DeviceEventArgs)e;

            Console.WriteLine("Device found on: " + de.Device.PortName);
            de.Device.DataReceived += new EventHandler(OnDataReceived);
        }

        // Called when scanning fails
        static void OnDeviceFail(object sender, EventArgs e)
        {
            Console.WriteLine("No devices found! :(");
            connector.Close();
            notConect();
        }

        // Called when each port is being validated
        static void OnDeviceValidating(object sender, EventArgs e)
        {
            Console.WriteLine("Validating: ");
        }

        // Called when data is received from a device
        static void OnDataReceived(object sender, EventArgs e)
        {
            //Device d = (Device)sender;

            Device.DataEventArgs de = (Device.DataEventArgs)e;
            NeuroSky.ThinkGear.DataRow[] tempDataRowArray = de.DataRowArray;

            TGParser tgParser = new TGParser();
            tgParser.Read(de.DataRowArray);

            /* Loops through the newly parsed data of the connected headset*/
            // The comments below indicate and can be used to print out the different data outputs. 

            for (int i = 0; i < tgParser.ParsedData.Length; i++)
            {
                if (tgParser.ParsedData[i].ContainsKey("Raw"))
                {
                    //Console.WriteLine("Raw Value:" + tgParser.ParsedData[i]["Raw"]);
                }
                if (tgParser.ParsedData[i].ContainsKey("PoorSignal"))
                {
                    //The following line prints the Time associated with the parsed data
                    //Console.WriteLine("Time:" + tgParser.ParsedData[i]["Time"]);

                    //A Poor Signal value of 0 indicates that your headset is fitting properly
                    Console.WriteLine("Poor Signal:" + tgParser.ParsedData[i]["PoorSignal"]);

                    poorSig = (byte)tgParser.ParsedData[i]["PoorSignal"];
                }
                if (tgParser.ParsedData[i].ContainsKey("Attention"))
                {
                    Console.WriteLine("Att Value:" + tgParser.ParsedData[i]["Attention"]);
                    Atencion = (byte)tgParser.ParsedData[i]["Attention"];
                }
                if (tgParser.ParsedData[i].ContainsKey("Meditation"))
                {
                    Console.WriteLine("Med Value:" + tgParser.ParsedData[i]["Meditation"]);
                    Meditacion = (byte)tgParser.ParsedData[i]["Meditation"];
                }
                if (tgParser.ParsedData[i].ContainsKey("EegPowerDelta"))
                {
                    //Console.WriteLine("Delta: " + tgParser.ParsedData[i]["EegPowerDelta"]);
                }

                if (tgParser.ParsedData[i].ContainsKey("BlinkStrength"))
                {
                    //Console.WriteLine("Eyeblink " + tgParser.ParsedData[i]["BlinkStrength"]);
                }

            }

        }

        private void btnEmepzar_Click(object sender, EventArgs e)
        {
            Thread mindwave = new Thread(escanear);
            switch (Conectado)
            {
                case false:
                    mindwave.Start();
                    Conectado = true;
                    btnEmepzar.Image = Properties.Resources.btnCancelar;
                    break;
                case true:
                    connector.Close();
                    mindwave.Abort();
                    Conectado = false;
                    btnConectado.Image = Properties.Resources.nosignal_v1;
                    btnEmepzar.Image = Properties.Resources.btnAceptar;
                    poorSig = 100;
                    Atencion = 0;
                    Meditacion = 0;
                    break;
            }
            
        }

        private void escanear()
        {
            // Scan for devices across COM ports
            // The COM port named will be the first COM port that is checked.
            connector.ConnectScan("COM40");

            // Blink detection needs to be manually turned on
            connector.setBlinkDetectionEnabled(true);
            while (Conectado) {
                Thread.Sleep(120000);
            };
            connector.Close();
            //Environment.Exit(0);
        }

        public static void notConect()
        {
            MessageBox.Show("Dispositivo no encontrado. Conecte el dispositivo.", "Dispositivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Question);
            connector.Close();
            Application.Exit();
            Environment.Exit(0);
            
        }

        private void btnModo_Click(object sender, EventArgs e)
        {
            switch (Modo)
            {
                case 1:
                    btnModo.Text = "Modo Concentracion";
                    lbCancion.Text = " ";
                    Modo = 2;
                    Reproductor.URL = @".\Music\Concentracion.m4a";
                    Reproductor.Ctlcontrols.play();
                    btnPlay.Image = Properties.Resources.Button_4_512; //boton pause
                    btnAdjuntar.Visible = false;
                    listCanciones.Visible = false;
                    Play = true;
                    break;
                case 2:
                    btnModo.Text = "Modo Relajacion";
                    lbCancion.Text = " ";
                    Modo = 3;
                    Reproductor.URL = @".\Music\Relajacion.m4a";
                    Reproductor.Ctlcontrols.play();
                    btnPlay.Image = Properties.Resources.Button_4_512; //boton pause
                    btnAdjuntar.Visible = false;
                    listCanciones.Visible = false;
                    Play = true;
                    break;
                case 3:
                    btnModo.Text = "Modo Reproduccion";
                    btnAdjuntar.Visible = true;
                    listCanciones.Visible = true;
                    lbCancion.Text = "Pulsa en examinar para selecionar la cancion que deses";
                    Reproductor.Ctlcontrols.stop();
                    Play = false;
                    Modo = 1;
                    break;
            }
        }
    }
}
