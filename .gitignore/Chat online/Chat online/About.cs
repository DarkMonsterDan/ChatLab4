using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chat_online
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        private void About_Shown(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
