namespace tank_interface
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
            this.Control = new System.Windows.Forms.GroupBox();
            this.button_d = new System.Windows.Forms.Button();
            this.button_a = new System.Windows.Forms.Button();
            this.night_mode = new System.Windows.Forms.PictureBox();
            this.reloadF = new System.Windows.Forms.Button();
            this.arduino_interface = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fire_pen = new System.Windows.Forms.Button();
            this.portname = new System.Windows.Forms.ComboBox();
            this.baudrate = new System.Windows.Forms.ComboBox();
            this.openport = new System.Windows.Forms.Button();
            this.closeport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addconfiguration = new System.Windows.Forms.ProgressBar();
            this.Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.night_mode)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control
            // 
            this.Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Control.Controls.Add(this.button_d);
            this.Control.Controls.Add(this.button_a);
            this.Control.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control.Location = new System.Drawing.Point(12, 12);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(193, 102);
            this.Control.TabIndex = 4;
            this.Control.TabStop = false;
            this.Control.Text = "Control";
            // 
            // button_d
            // 
            this.button_d.BackColor = System.Drawing.Color.Gray;
            this.button_d.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_d.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_d.Location = new System.Drawing.Point(112, 22);
            this.button_d.Name = "button_d";
            this.button_d.Size = new System.Drawing.Size(75, 74);
            this.button_d.TabIndex = 1;
<<<<<<< HEAD
            this.button_d.Text = "B";
=======
            this.button_d.Text = "D";
>>>>>>> add keyboard controlsnew change
            this.button_d.UseVisualStyleBackColor = false;
            this.button_d.Click += new System.EventHandler(this.Button_d_Click);
            // 
            // button_a
            // 
            this.button_a.BackColor = System.Drawing.Color.Gray;
            this.button_a.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_a.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_a.Location = new System.Drawing.Point(7, 22);
            this.button_a.Name = "button_a";
            this.button_a.Size = new System.Drawing.Size(75, 74);
            this.button_a.TabIndex = 0;
            this.button_a.Text = "A";
            this.button_a.UseVisualStyleBackColor = false;
            this.button_a.Click += new System.EventHandler(this.Button_a_Click);
            // 
            // night_mode
            // 
            this.night_mode.Image = global::tank_interface.Properties.Resources.night_mode;
            this.night_mode.Location = new System.Drawing.Point(895, 12);
            this.night_mode.Name = "night_mode";
            this.night_mode.Size = new System.Drawing.Size(52, 53);
            this.night_mode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.night_mode.TabIndex = 1;
            this.night_mode.TabStop = false;
            this.night_mode.Click += new System.EventHandler(this.Night_mode_Click);
            // 
            // reloadF
            // 
            this.reloadF.BackColor = System.Drawing.Color.Gray;
            this.reloadF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reloadF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reloadF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.reloadF.Location = new System.Drawing.Point(6, 135);
            this.reloadF.Name = "reloadF";
            this.reloadF.Size = new System.Drawing.Size(110, 35);
            this.reloadF.TabIndex = 6;
            this.reloadF.Text = "Reload Amno";
            this.reloadF.UseVisualStyleBackColor = false;
            this.reloadF.Click += new System.EventHandler(this.ReloadF_Click);
            // 
            // arduino_interface
            // 
            this.arduino_interface.PortName = "COM7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Munitions";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Control);
            this.panel1.Location = new System.Drawing.Point(12, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 134);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(12, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 210);
            this.panel2.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fire_pen);
            this.groupBox1.Controls.Add(this.reloadF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 184);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fire";
            // 
            // fire_pen
            // 
            this.fire_pen.BackColor = System.Drawing.Color.Gray;
            this.fire_pen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fire_pen.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fire_pen.Location = new System.Drawing.Point(7, 20);
            this.fire_pen.Name = "fire_pen";
            this.fire_pen.Size = new System.Drawing.Size(109, 109);
            this.fire_pen.TabIndex = 9;
            this.fire_pen.Text = "F";
            this.fire_pen.UseCompatibleTextRendering = true;
            this.fire_pen.UseVisualStyleBackColor = false;
            this.fire_pen.Click += new System.EventHandler(this.Fire_pen_Click);
            // 
            // portname
            // 
            this.portname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.portname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.portname.FormattingEnabled = true;
            this.portname.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.portname.Location = new System.Drawing.Point(142, 19);
            this.portname.Name = "portname";
            this.portname.Size = new System.Drawing.Size(121, 21);
            this.portname.TabIndex = 11;
            this.portname.Text = "Com Port";
            // 
            // baudrate
            // 
            this.baudrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.baudrate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.baudrate.FormattingEnabled = true;
            this.baudrate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.baudrate.Location = new System.Drawing.Point(6, 19);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(121, 21);
            this.baudrate.TabIndex = 12;
            this.baudrate.Text = "Baud Rate";
            // 
            // openport
            // 
            this.openport.BackColor = System.Drawing.Color.Gray;
            this.openport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openport.Location = new System.Drawing.Point(41, 50);
            this.openport.Name = "openport";
            this.openport.Size = new System.Drawing.Size(75, 23);
            this.openport.TabIndex = 13;
            this.openport.Text = "Open";
            this.openport.UseVisualStyleBackColor = false;
            this.openport.Click += new System.EventHandler(this.Openport_Click);
            // 
            // closeport
            // 
            this.closeport.BackColor = System.Drawing.Color.Gray;
            this.closeport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeport.Location = new System.Drawing.Point(157, 50);
            this.closeport.Name = "closeport";
            this.closeport.Size = new System.Drawing.Size(75, 23);
            this.closeport.TabIndex = 14;
            this.closeport.Text = "Close";
            this.closeport.UseVisualStyleBackColor = false;
            this.closeport.Click += new System.EventHandler(this.Closeport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.baudrate);
            this.groupBox2.Controls.Add(this.closeport);
            this.groupBox2.Controls.Add(this.portname);
            this.groupBox2.Controls.Add(this.openport);
            this.groupBox2.Location = new System.Drawing.Point(13, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 85);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.addconfiguration);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(649, 478);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 122);
            this.panel3.TabIndex = 16;
            // 
            // addconfiguration
            // 
            this.addconfiguration.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.addconfiguration.Location = new System.Drawing.Point(13, 96);
            this.addconfiguration.Name = "addconfiguration";
            this.addconfiguration.Size = new System.Drawing.Size(271, 23);
            this.addconfiguration.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.addconfiguration.TabIndex = 16;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(959, 612);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.night_mode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tank Interface";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
<<<<<<< HEAD
=======
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
>>>>>>> add keyboard controlsnew change
            this.Control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.night_mode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox night_mode;
        private System.Windows.Forms.GroupBox Control;
        private System.Windows.Forms.Button reloadF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_d;
        private System.Windows.Forms.Button button_a;
        private System.Windows.Forms.Button fire_pen;
        private System.Windows.Forms.ComboBox portname;
        private System.Windows.Forms.ComboBox baudrate;
        private System.Windows.Forms.Button openport;
        private System.Windows.Forms.Button closeport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar addconfiguration;
        private System.IO.Ports.SerialPort arduino_interface;
    }
}

