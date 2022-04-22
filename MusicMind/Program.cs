using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

using NeuroSky.ThinkGear;
using NeuroSky.ThinkGear.Algorithms;


namespace MusicMind
{
    static class Program
    {
        static Connector connector;
        static byte poorSig;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Console.WriteLine("HelloEEG!");

            // Initialize a new Connector and add event handlers

            connector = new Connector();
            connector.DeviceConnected += new EventHandler(OnDeviceConnected);
            connector.DeviceConnectFail += new EventHandler(OnDeviceFail);
            connector.DeviceValidating += new EventHandler(OnDeviceValidating);

            // Scan for devices across COM ports
            // The COM port named will be the first COM port that is checked.
            connector.ConnectScan("COM40");

            // Blink detection needs to be manually turned on
            connector.setBlinkDetectionEnabled(true);
            Thread.Sleep(450000);

            System.Console.WriteLine("Goodbye.");
            connector.Close();
            Environment.Exit(0);
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
            DataRow[] tempDataRowArray = de.DataRowArray;

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
                }
                if (tgParser.ParsedData[i].ContainsKey("Meditation"))
                {
                    Console.WriteLine("Med Value:" + tgParser.ParsedData[i]["Meditation"]);
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
        }
    }
