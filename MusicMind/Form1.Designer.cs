namespace MusicMind
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.listCanciones = new System.Windows.Forms.ListBox();
            this.mtrackCancion = new XComponent.SliderBar.MACTrackBar();
            this.mtrackVolumen = new XComponent.SliderBar.MACTrackBar();
            this.lbCancion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnVolumen = new System.Windows.Forms.PictureBox();
            this.btnAdjuntar = new System.Windows.Forms.PictureBox();
            this.btnModo = new System.Windows.Forms.Button();
            this.btnConectado = new System.Windows.Forms.PictureBox();
            this.btnEmepzar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConectado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmepzar)).BeginInit();
            this.SuspendLayout();
            // 
            // Reproductor
            // 
            this.Reproductor.Enabled = true;
            this.Reproductor.Location = new System.Drawing.Point(15, 318);
            this.Reproductor.Name = "Reproductor";
            this.Reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Reproductor.OcxState")));
            this.Reproductor.Size = new System.Drawing.Size(213, 60);
            this.Reproductor.TabIndex = 0;
            this.Reproductor.Visible = false;
            this.Reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            // 
            // listCanciones
            // 
            this.listCanciones.FormattingEnabled = true;
            this.listCanciones.Location = new System.Drawing.Point(315, 49);
            this.listCanciones.Name = "listCanciones";
            this.listCanciones.Size = new System.Drawing.Size(169, 82);
            this.listCanciones.TabIndex = 1;
            this.listCanciones.SelectedIndexChanged += new System.EventHandler(this.listCanciones_SelectedIndexChanged);
            // 
            // mtrackCancion
            // 
            this.mtrackCancion.BackColor = System.Drawing.Color.Transparent;
            this.mtrackCancion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtrackCancion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrackCancion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtrackCancion.IndentHeight = 6;
            this.mtrackCancion.Location = new System.Drawing.Point(15, 290);
            this.mtrackCancion.Maximum = 10;
            this.mtrackCancion.Minimum = 0;
            this.mtrackCancion.Name = "mtrackCancion";
            this.mtrackCancion.Size = new System.Drawing.Size(636, 22);
            this.mtrackCancion.TabIndex = 3;
            this.mtrackCancion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackCancion.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mtrackCancion.TickHeight = 4;
            this.mtrackCancion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackCancion.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtrackCancion.TrackerSize = new System.Drawing.Size(10, 10);
            this.mtrackCancion.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackCancion.TrackLineHeight = 3;
            this.mtrackCancion.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackCancion.Value = 0;
            // 
            // mtrackVolumen
            // 
            this.mtrackVolumen.BackColor = System.Drawing.Color.Transparent;
            this.mtrackVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtrackVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrackVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtrackVolumen.IndentHeight = 6;
            this.mtrackVolumen.Location = new System.Drawing.Point(470, 262);
            this.mtrackVolumen.Maximum = 100;
            this.mtrackVolumen.Minimum = 0;
            this.mtrackVolumen.Name = "mtrackVolumen";
            this.mtrackVolumen.Size = new System.Drawing.Size(181, 22);
            this.mtrackVolumen.TabIndex = 4;
            this.mtrackVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mtrackVolumen.TickHeight = 4;
            this.mtrackVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackVolumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtrackVolumen.TrackerSize = new System.Drawing.Size(10, 10);
            this.mtrackVolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackVolumen.TrackLineHeight = 3;
            this.mtrackVolumen.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackVolumen.Value = 0;
            this.mtrackVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.mtrackVolumen_ValueChanged);
            // 
            // lbCancion
            // 
            this.lbCancion.AutoSize = true;
            this.lbCancion.Location = new System.Drawing.Point(12, 70);
            this.lbCancion.Name = "lbCancion";
            this.lbCancion.Size = new System.Drawing.Size(28, 13);
            this.lbCancion.TabIndex = 9;
            this.lbCancion.Text = "-------";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::MusicMind.Properties.Resources.Button_5_512;
            this.btnStop.Location = new System.Drawing.Point(315, 243);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(43, 41);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStop.TabIndex = 8;
            this.btnStop.TabStop = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::MusicMind.Properties.Resources.Button_3_512;
            this.btnPlay.Location = new System.Drawing.Point(266, 243);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(43, 41);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlay.TabIndex = 6;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnVolumen
            // 
            this.btnVolumen.Image = global::MusicMind.Properties.Resources.sound_button_icon_76357;
            this.btnVolumen.Location = new System.Drawing.Point(437, 262);
            this.btnVolumen.Name = "btnVolumen";
            this.btnVolumen.Size = new System.Drawing.Size(27, 22);
            this.btnVolumen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVolumen.TabIndex = 5;
            this.btnVolumen.TabStop = false;
            this.btnVolumen.Click += new System.EventHandler(this.btnVolumen_Click);
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Image = global::MusicMind.Properties.Resources.Button_11_512;
            this.btnAdjuntar.Location = new System.Drawing.Point(169, 12);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(43, 41);
            this.btnAdjuntar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdjuntar.TabIndex = 2;
            this.btnAdjuntar.TabStop = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnModo
            // 
            this.btnModo.Location = new System.Drawing.Point(12, 12);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(151, 41);
            this.btnModo.TabIndex = 10;
            this.btnModo.Text = "Modo Concentracion";
            this.btnModo.UseVisualStyleBackColor = true;
            // 
            // btnConectado
            // 
            this.btnConectado.Image = global::MusicMind.Properties.Resources.nosignal_v1;
            this.btnConectado.Location = new System.Drawing.Point(583, 12);
            this.btnConectado.Name = "btnConectado";
            this.btnConectado.Size = new System.Drawing.Size(68, 56);
            this.btnConectado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnConectado.TabIndex = 11;
            this.btnConectado.TabStop = false;
            // 
            // btnEmepzar
            // 
            this.btnEmepzar.Image = global::MusicMind.Properties.Resources.btnAceptar;
            this.btnEmepzar.Location = new System.Drawing.Point(92, 137);
            this.btnEmepzar.Name = "btnEmepzar";
            this.btnEmepzar.Size = new System.Drawing.Size(100, 76);
            this.btnEmepzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEmepzar.TabIndex = 12;
            this.btnEmepzar.TabStop = false;
            this.btnEmepzar.Click += new System.EventHandler(this.btnEmepzar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 317);
            this.Controls.Add(this.btnEmepzar);
            this.Controls.Add(this.btnConectado);
            this.Controls.Add(this.btnModo);
            this.Controls.Add(this.lbCancion);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnVolumen);
            this.Controls.Add(this.mtrackVolumen);
            this.Controls.Add(this.mtrackCancion);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.listCanciones);
            this.Controls.Add(this.Reproductor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MusicMind";
            ((System.ComponentModel.ISupportInitialize)(this.Reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdjuntar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConectado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmepzar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Reproductor;
        private System.Windows.Forms.ListBox listCanciones;
        private System.Windows.Forms.PictureBox btnAdjuntar;
        private XComponent.SliderBar.MACTrackBar mtrackCancion;
        private XComponent.SliderBar.MACTrackBar mtrackVolumen;
        private System.Windows.Forms.PictureBox btnVolumen;
        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.Label lbCancion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnModo;
        private System.Windows.Forms.PictureBox btnConectado;
        private System.Windows.Forms.PictureBox btnEmepzar;
    }
}

