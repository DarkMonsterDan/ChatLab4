using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Chat_online
{

    public partial class Make_Server : Form
    {
        private mainform frm;
        public Make_Server(mainform f)
        {
            InitializeComponent();
            frm = f;
        }
        private void okey_Click(object sender, EventArgs e)
        {
             try
            {
                frm.MxUsr = Convert.ToInt32(mxUsr.Text);
                frm.client = new Socket[Convert.ToInt32(mxUsr.Text)];
                frm.userlist = new string[Convert.ToInt32(mxUsr.Text)];

                if (adminNAme.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Неверные значения");
                    return;
                }

                string[] lof = adminNAme.Text.Split('%');
                if (lof.Length > 1)
                {
                    MessageBox.Show("Ник не должен содержать символы");
                    return;
                }

                frm.adminName = adminNAme.Text;
                frm.MakeServerStart();
            }
             catch
              {
                  MessageBox.Show("Неверные значения");
                 return;
              }
            frm.AddHist("\n" + "Сервер запущен.");
            this.Close();
        }
        private void Make_Server_Shown(object sender, EventArgs e)
        {
            adminNAme.Focus();
        }

        private void Make_Server_Load(object sender, EventArgs e)
        {

        }
    }
}
