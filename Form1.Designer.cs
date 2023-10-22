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
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.show_seconds = new System.Windows.Forms.Label();
            this.fire_2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.night_mode)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control
            // 
            resources.ApplyResources(this.Control, "Control");
            this.Control.Controls.Add(this.button_d);
            this.Control.Controls.Add(this.button_a);
            this.Control.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Control.Name = "Control";
            this.Control.TabStop = false;
            // 
            // button_d
            // 
            this.button_d.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.button_d, "button_d");
            this.button_d.Name = "button_d";
            this.button_d.UseVisualStyleBackColor = false;
            this.button_d.Click += new System.EventHandler(this.Button_d_Click);
            // 
            // button_a
            // 
            this.button_a.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.button_a, "button_a");
            this.button_a.Name = "button_a";
            this.button_a.UseVisualStyleBackColor = false;
            this.button_a.Click += new System.EventHandler(this.Button_a_Click);
            // 
            // night_mode
            // 
            this.night_mode.Image = global::tank_interface.Properties.Resources.night_mode;
            resources.ApplyResources(this.night_mode, "night_mode");
            this.night_mode.Name = "night_mode";
            this.night_mode.TabStop = false;
            this.night_mode.Click += new System.EventHandler(this.Night_mode_Click);
            // 
            // reloadF
            // 
            this.reloadF.BackColor = System.Drawing.Color.Gray;
            this.reloadF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.reloadF, "reloadF");
            this.reloadF.Name = "reloadF";
            this.reloadF.UseVisualStyleBackColor = false;
            this.reloadF.Click += new System.EventHandler(this.ReloadF_Click);
            // 
            // arduino_interface
            // 
            this.arduino_interface.PortName = "COM7";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.Control);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fire_pen);
            this.groupBox1.Controls.Add(this.reloadF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // fire_pen
            // 
            this.fire_pen.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.fire_pen, "fire_pen");
            this.fire_pen.Name = "fire_pen";
            this.fire_pen.UseCompatibleTextRendering = true;
            this.fire_pen.UseVisualStyleBackColor = false;
            this.fire_pen.Click += new System.EventHandler(this.Fire_pen_Click);
            // 
            // portname
            // 
            this.portname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            resources.ApplyResources(this.portname, "portname");
            this.portname.FormattingEnabled = true;
            this.portname.Items.AddRange(new object[] {
            resources.GetString("portname.Items"),
            resources.GetString("portname.Items1"),
            resources.GetString("portname.Items2"),
            resources.GetString("portname.Items3"),
            resources.GetString("portname.Items4"),
            resources.GetString("portname.Items5"),
            resources.GetString("portname.Items6")});
            this.portname.Name = "portname";
            // 
            // baudrate
            // 
            this.baudrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            resources.ApplyResources(this.baudrate, "baudrate");
            this.baudrate.FormattingEnabled = true;
            this.baudrate.Items.AddRange(new object[] {
            resources.GetString("baudrate.Items"),
            resources.GetString("baudrate.Items1"),
            resources.GetString("baudrate.Items2"),
            resources.GetString("baudrate.Items3")});
            this.baudrate.Name = "baudrate";
            // 
            // openport
            // 
            this.openport.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.openport, "openport");
            this.openport.Name = "openport";
            this.openport.UseVisualStyleBackColor = false;
            this.openport.Click += new System.EventHandler(this.Openport_Click);
            // 
            // closeport
            // 
            this.closeport.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.closeport, "closeport");
            this.closeport.Name = "closeport";
            this.closeport.UseVisualStyleBackColor = false;
            this.closeport.Click += new System.EventHandler(this.Closeport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.baudrate);
            this.groupBox2.Controls.Add(this.closeport);
            this.groupBox2.Controls.Add(this.portname);
            this.groupBox2.Controls.Add(this.openport);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.addconfiguration);
            this.panel3.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // addconfiguration
            // 
            this.addconfiguration.ForeColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.addconfiguration, "addconfiguration");
            this.addconfiguration.Name = "addconfiguration";
            this.addconfiguration.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.show_seconds);
            this.groupBox3.Controls.Add(this.fire_2);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // show_seconds
            // 
            resources.ApplyResources(this.show_seconds, "show_seconds");
            this.show_seconds.Name = "show_seconds";
            // 
            // fire_2
            // 
            this.fire_2.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.fire_2, "fire_2");
            this.fire_2.Name = "fire_2";
            this.fire_2.UseVisualStyleBackColor = false;
            this.fire_2.Click += new System.EventHandler(this.fire_2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.night_mode);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.night_mode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label show_seconds;
        private System.Windows.Forms.Button fire_2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

