using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chat_online
{
    public partial class Connect : Form
    {
        private mainform frm;
        public Connect(mainform f)
        {
            InitializeComponent();
            frm = f;
        }
        private void goooo_Click(object sender, EventArgs e)
        {
            try
            {
                if (login.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Неверные значения");
                    return;
                }
                string[] lof = login.Text.Split('%');
                if (lof.Length > 1)
                {
                    MessageBox.Show("Ник не должен содержать символы");
                    return;
                }

                frm.UserName = login.Text;
                frm.IPsr = ipnum.Text;
                frm.PORTsr =Convert.ToInt32( porttoS.Text);
            }
            catch
            {
                MessageBox.Show("Неверные значения");
                return;
            }
            frm.ISCLIENT = true;
            frm.ConnectToServ();
            this.Close();
        }
        private void Connect_Shown(object sender, EventArgs e)
        {
            ipnum.Focus();
        }

        private void Connect_Load(object sender, EventArgs e)
        {

        }
    }
}
