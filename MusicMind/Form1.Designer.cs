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
            this.mtrackAtencion = new XComponent.SliderBar.MACTrackBar();
            this.mtrackRelajacion = new XComponent.SliderBar.MACTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRelajacion = new System.Windows.Forms.Label();
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
            this.listCanciones.Location = new System.Drawing.Point(84, 202);
            this.listCanciones.Name = "listCanciones";
            this.listCanciones.Size = new System.Drawing.Size(109, 82);
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
            this.btnAdjuntar.Location = new System.Drawing.Point(15, 12);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(43, 41);
            this.btnAdjuntar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAdjuntar.TabIndex = 2;
            this.btnAdjuntar.TabStop = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnModo
            // 
            this.btnModo.Location = new System.Drawing.Point(64, 12);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(151, 41);
            this.btnModo.TabIndex = 10;
            this.btnModo.Text = "Modo Reproduccion";
            this.btnModo.UseVisualStyleBackColor = true;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
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
            this.btnEmepzar.Location = new System.Drawing.Point(30, 125);
            this.btnEmepzar.Name = "btnEmepzar";
            this.btnEmepzar.Size = new System.Drawing.Size(100, 76);
            this.btnEmepzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEmepzar.TabIndex = 12;
            this.btnEmepzar.TabStop = false;
            this.btnEmepzar.Click += new System.EventHandler(this.btnEmepzar_Click);
            // 
            // mtrackAtencion
            // 
            this.mtrackAtencion.BackColor = System.Drawing.Color.Transparent;
            this.mtrackAtencion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtrackAtencion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrackAtencion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtrackAtencion.IndentHeight = 6;
            this.mtrackAtencion.Location = new System.Drawing.Point(339, 112);
            this.mtrackAtencion.Maximum = 100;
            this.mtrackAtencion.Minimum = 0;
            this.mtrackAtencion.Name = "mtrackAtencion";
            this.mtrackAtencion.Size = new System.Drawing.Size(312, 22);
            this.mtrackAtencion.TabIndex = 13;
            this.mtrackAtencion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackAtencion.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mtrackAtencion.TickHeight = 4;
            this.mtrackAtencion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackAtencion.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtrackAtencion.TrackerSize = new System.Drawing.Size(10, 10);
            this.mtrackAtencion.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackAtencion.TrackLineHeight = 3;
            this.mtrackAtencion.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackAtencion.Value = 0;
            // 
            // mtrackRelajacion
            // 
            this.mtrackRelajacion.BackColor = System.Drawing.Color.Transparent;
            this.mtrackRelajacion.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtrackRelajacion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtrackRelajacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtrackRelajacion.IndentHeight = 6;
            this.mtrackRelajacion.Location = new System.Drawing.Point(339, 150);
            this.mtrackRelajacion.Maximum = 100;
            this.mtrackRelajacion.Minimum = 0;
            this.mtrackRelajacion.Name = "mtrackRelajacion";
            this.mtrackRelajacion.Size = new System.Drawing.Size(312, 22);
            this.mtrackRelajacion.TabIndex = 14;
            this.mtrackRelajacion.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackRelajacion.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mtrackRelajacion.TickHeight = 4;
            this.mtrackRelajacion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtrackRelajacion.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mtrackRelajacion.TrackerSize = new System.Drawing.Size(10, 10);
            this.mtrackRelajacion.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackRelajacion.TrackLineHeight = 3;
            this.mtrackRelajacion.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtrackRelajacion.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Atencion";
            // 
            // lbRelajacion
            // 
            this.lbRelajacion.AutoSize = true;
            this.lbRelajacion.Location = new System.Drawing.Point(276, 150);
            this.lbRelajacion.Name = "lbRelajacion";
            this.lbRelajacion.Size = new System.Drawing.Size(57, 13);
            this.lbRelajacion.TabIndex = 16;
            this.lbRelajacion.Text = "Relajacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 317);
            this.Controls.Add(this.lbRelajacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtrackRelajacion);
            this.Controls.Add(this.mtrackAtencion);
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
        private XComponent.SliderBar.MACTrackBar mtrackAtencion;
        private XComponent.SliderBar.MACTrackBar mtrackRelajacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRelajacion;
    }
}

