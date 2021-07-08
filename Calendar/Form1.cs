﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory($"Notes\\{this.textBoxTitle.Text}");
            File.WriteAllText($"Notes\\{this.textBoxTitle.Text}", $"{this.textBoxText.Text}.txt");
            File.WriteAllText($"Notes\\{this.textBoxTitle.Text}", $"{this.dateTimePicker1.Value}.txt");
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Directory.CreateDirectory($"Notes\\{this.textBoxTitle.Text}");
            File.WriteAllText($"Notes\\{this.textBoxTitle.Text}", $"{this.textBoxText.Text}.txt");
            File.WriteAllText($"Notes\\{this.textBoxTitle.Text}", $"{this.dateTimePicker1.Value}.txt");
        }
    }
}
