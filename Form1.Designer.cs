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
            this.label6 = new System.Windows.Forms.Label();
            this.button_d = new System.Windows.Forms.Button();
            this.button_a = new System.Windows.Forms.Button();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.show_seconds = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fire_2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackbar = new System.Windows.Forms.TrackBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.led_red = new System.Windows.Forms.CheckBox();
            this.led_green = new System.Windows.Forms.CheckBox();
            this.led_blue = new System.Windows.Forms.CheckBox();
            this.Control.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control
            // 
            resources.ApplyResources(this.Control, "Control");
            this.Control.Controls.Add(this.label6);
            this.Control.Controls.Add(this.button_d);
            this.Control.Controls.Add(this.button_a);
            this.Control.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Control.Name = "Control";
            this.Control.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
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
            this.addconfiguration.Cursor = System.Windows.Forms.Cursors.AppStarting;
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
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.fire_2);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.show_seconds);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // show_seconds
            // 
            resources.ApplyResources(this.show_seconds, "show_seconds");
            this.show_seconds.Name = "show_seconds";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fire_2
            // 
            this.fire_2.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.fire_2, "fire_2");
            this.fire_2.Name = "fire_2";
            this.fire_2.UseVisualStyleBackColor = false;
            this.fire_2.Click += new System.EventHandler(this.fire_2_Click);
            // 
            // trackbar
            // 
            this.trackbar.LargeChange = 1;
            resources.ApplyResources(this.trackbar, "trackbar");
            this.trackbar.Maximum = 18;
            this.trackbar.Name = "trackbar";
            this.trackbar.Scroll += new System.EventHandler(this.trackbar_Scroll);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.groupBox5);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelInfo);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.trackbar);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // labelInfo
            // 
            resources.ApplyResources(this.labelInfo, "labelInfo");
            this.labelInfo.Name = "labelInfo";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.led_blue);
            this.panel6.Controls.Add(this.led_green);
            this.panel6.Controls.Add(this.led_red);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // led_red
            // 
            resources.ApplyResources(this.led_red, "led_red");
            this.led_red.Name = "led_red";
            this.led_red.UseVisualStyleBackColor = true;
            this.led_red.CheckedChanged += new System.EventHandler(this.led_red_CheckedChanged);
            // 
            // led_green
            // 
            resources.ApplyResources(this.led_green, "led_green");
            this.led_green.Name = "led_green";
            this.led_green.UseVisualStyleBackColor = true;
            this.led_green.CheckedChanged += new System.EventHandler(this.led_green_CheckedChanged);
            // 
            // led_blue
            // 
            resources.ApplyResources(this.led_blue, "led_blue");
            this.led_blue.Name = "led_blue";
            this.led_blue.UseVisualStyleBackColor = true;
            this.led_blue.CheckedChanged += new System.EventHandler(this.led_blue_CheckedChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Control.ResumeLayout(false);
            this.Control.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar)).EndInit();
            this.panel5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackbar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox led_green;
        private System.Windows.Forms.CheckBox led_red;
        private System.Windows.Forms.CheckBox led_blue;
    }
}

