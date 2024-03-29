﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fingerprint.Password;
using System.IO;

namespace FingerprintClient
{
    public delegate void SetTextCallback(string[] text);

    public partial class Main : Form
    {
        ThreadManager tm;
        

        public Main()
        {
            InitializeComponent();
            tm = new ThreadManager(new SetTextCallback(SetText));
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            this.textBoxSName.Text = "";
            this.textBoxSInfo.Text = "";
            string password = this.textBoxPassword.Text;
            password = Password.GenerateHashWithSalt(password);
            SocketManager sm = new SocketManager(this.textBoxName.Text + "[{sep}]" + password);
            string[] strings = sm.getResponse();
            this.textBoxSName.Text = strings[0];
            this.textBoxSInfo.Text = strings[1];
        }

        private void SetText(string[] text)
        {
            if (this.textBoxSName.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {                
                this.textBoxSName.Text = text[0];
                this.textBoxSInfo.Text = text[1];
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonFingerprint_Click(object sender, EventArgs e)
        {
            System.IO.Stream stream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "bmp files (*.bmp)|*.bmp";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Not working asynchronus client
                /*Bitmap bmp = new Bitmap(openFileDialog.FileName);
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] bmpBytes = ms.GetBuffer();
                bmp.Dispose();
                ms.Close();*/

                //bmpBytes  = bmpBytes.Concat(Encoding.ASCII.GetBytes("<EOF>")).ToArray();

                /*Console.WriteLine("N bytes {0}", bmpBytes.Count());
                string result = "";
                
                foreach(byte data in bmpBytes)
                {
                    result += bmpBytes.ToString();
                }

                Console.WriteLine("Data string",result);
                Console.WriteLine("done");*/
                /*SocketManager sm = new SocketManager(bmpBytes);*/

                //Failed Testing synchronus client
                //SynchronousSocketClient.StartClient(bmpBytes);

                //Testing TCP send from 3rd party user
                SocketManager.SendTCP(openFileDialog.FileName);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            tm.Stop(); 
        }

        private void textBoxSName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
