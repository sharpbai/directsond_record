using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using libDxRec;

namespace FormRec
{
    public partial class RecForm : Form
    {
        Recoder recoder;

        public RecForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recoder = new Recoder();
            recoder.SetFileName("D://rec.wav");
            recoder.RecStart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recoder.RecStop();
        }

        private void RecForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
