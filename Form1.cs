﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tank_interface
{
    public partial class Form1 : Form
    {
        //System.IO.Ports.SerialPort ArduinoPort;
        public Form1()
        {
            InitializeComponent();
        }

        //control
        private void Button_a_Click(object sender, EventArgs e)
        {
            try
            {
                arduino_interface.WriteLine("$Go_1");
                button_a.BackColor = Color.DarkGray;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_d_Click(object sender, EventArgs e)
        {
            //hello!
            try
            {
                arduino_interface.WriteLine("$Go_2");
                button_d.BackColor = Color.DarkGray;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        //control_end

        //fire
        private void Fire_pen_Click(object sender, EventArgs e)
        {
            fire_pen.BackColor = Color.DarkGray;
            MessageBox.Show("FIRE!");
            label1.Text = "0";
            fire_pen.Enabled = false;
        }

        private void ReloadF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reloaded!");
            label1.Text = "1";
            fire_pen.Enabled = true;
        }
        //fire_end

        //modo noche
        private void Night_mode_Click(object sender, EventArgs e)
        {

        }

        //close form:
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (arduino_interface.IsOpen)
            {
                try
                {
                    arduino_interface.WriteLine("$Go_2");
                    arduino_interface.Close();
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openport.Enabled = true;
            closeport.Enabled = true;

            //all of buttons of controll and fire:
            fire_pen.Enabled = false;
            button_a.Enabled = false;
            button_d.Enabled = false;
            reloadF.Enabled = false;

            addconfiguration.Value = 0;

            baudrate.Text = "9600";

            string[] portList = SerialPort.GetPortNames();
            portname.Items.AddRange(portList);

        }

        private void Openport_Click(object sender, EventArgs e)
        {
            try
            {
                arduino_interface.PortName = portname.Text;
                arduino_interface.BaudRate = Convert.ToInt32(baudrate.Text);
                arduino_interface.Open();

                openport.Enabled = false;
                closeport.Enabled = true;
                addconfiguration.Value = 100;
                baudrate.Enabled = false;
                portname.Enabled = false;

                fire_pen.Enabled = true;
                button_a.Enabled = true;
                button_d.Enabled = true;
                reloadF.Enabled = true;

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Closeport_Click(object sender, EventArgs e)
        {
            if(arduino_interface.IsOpen)
            {
                try
                {
                    arduino_interface.WriteLine("$Go_2");
                    arduino_interface.Close();

                    closeport.Enabled = false;
                    openport.Enabled = true;
                    addconfiguration.Value = 0;
                    baudrate.Enabled = true;
                    portname.Enabled = true;

                    fire_pen.Enabled = false;
                    button_a.Enabled = false;
                    button_d.Enabled = false;
                    reloadF.Enabled = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //keyboard events
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                button_a.PerformClick();
            }
            if(e.KeyCode == Keys.D)
            {
                button_d.PerformClick();
            }
            if(e.KeyCode == Keys.F)
            {
                fire_pen.PerformClick();
            }
            if(e.KeyCode == Keys.R)
            {
                reloadF.PerformClick();
            }
        }
        //machine gun
        int milisegundos = 5;
        private void fire_2_Click(object sender, EventArgs e)
        {
            arduino_interface.WriteLine("$Fire_2"); //new command!
            show_seconds.Text = milisegundos.ToString();
            timer1.Start();

        }

        //temporizador
        private void timer1_Tick(object sender, EventArgs e)
        {
            milisegundos -= 1;
            if (show_seconds.Text == "0")
            {
                timer1.Stop();
            }
        }
    }
}
