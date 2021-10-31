using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chat_online
{
    public partial class Settings : Form
    {
        mainform frm;
        public Settings(mainform f)
        {
            frm = f;
            InitializeComponent();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (openFileDialog1.FileName.Length > 0)
            {
                textBox1.Text = frm.AudioFile = openFileDialog1.FileName;
                frm.aud = new Microsoft.DirectX.AudioVideoPlayback.Audio(frm.AudioFile);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            frm.micON = checkBox1.Checked;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
