using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Chat_online
{
    public partial class USerLIst : Form
    {
        mainform frm;
        public USerLIst(mainform f)
        {
            InitializeComponent();
            frm = f;
            if (frm.ISCLIENT)
            {
                кикToolStripMenuItem.Enabled = false;
            }
            else { кикToolStripMenuItem.Enabled = true; }
            UpdateUserList();
        }

        private void написатьВПриватToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userLtxt.SelectedItem != null)
            {
                if (frm.ISCLIENT) 
                {
                    frm.mess.Text += "%пр%" + userLtxt.SelectedItem.ToString() + "%";
                    frm.mess.Focus();
                    frm.mess.SelectionStart = frm.mess.Text.Length;
                    frm.mess.ScrollToCaret();
                }
                else
                {
                    string[] username = userLtxt.SelectedItem.ToString().Split(':');
                    frm.mess.Text += "%пр%" + username[0].Substring(0,username[0].Length-1) + "%";
                    frm.mess.Focus();
                    frm.mess.SelectionStart = frm.mess.Text.Length;
                    frm.mess.ScrollToCaret();
                }
            }
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUserList();
        }
        private void кикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((userLtxt.SelectedItem != null)&&(userLtxt.SelectedItem.ToString()!=("[ "+frm.adminName + " ]")))
            {
                if (frm.ISCLIENT) { }
                else
                {
                    string[] username = userLtxt.SelectedItem.ToString().Split(':');
                    frm.CickUser(username[0]);
                }
            }
            Thread.Sleep(100);
            UpdateUserList();
        }

        void UpdateUserList()
        {
            userLtxt.Items.Clear();
            if (frm.ISCLIENT)
            {
                string USERS = "";
                try
                {

                    byte[] data = new byte[1024];
                    int recv = 0;
                    byte[] message = Encoding.UTF8.GetBytes("*get_all_users_tocl*");
                    frm.ClToSr.BeginSend(message, 0, message.Length, 0, new AsyncCallback(frm.SendDataEnd), frm.ClToSr);

                    recv = frm.ClToSr.Receive(data);

                    USERS = Encoding.UTF8.GetString(data, 0, recv);

                    string[] users = USERS.Split('%');

                    int mxvl = users.Length, nowl = 0;
                    while (mxvl > nowl)
                    {
                        if (users[nowl] == frm.UserName)
                        {
                            users[nowl] = "[ " + users[nowl] + " ]";
                        }
                        userLtxt.Items.Add(users[nowl]);
                        nowl++;
                    }

                }
                catch { }
            }
            else
            {
                userLtxt.Items.Add("[ "+frm.adminName+" ]");
                int curusr = 0;
                while (frm.MxUsr > curusr)
                {
                    if (frm.userlist[curusr] != null)
                    {
                        userLtxt.Items.Add(frm.userlist[curusr] + " : " + frm.client[curusr].RemoteEndPoint.ToString());
                    }
                    curusr++;
                }
            }
        }
    }
}
