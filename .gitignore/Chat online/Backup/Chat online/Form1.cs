using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.DirectX.AudioVideoPlayback;

namespace Chat_online
{
    public partial class mainform : Form
    {
        
        //CLICKS
        private void подключитьсяКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cont = new Connect(this);
            cont.Show();
        }
        private void создатьСерверToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2 = new Make_Server(this);
            frm2.ShowDialog();
        }
        private void mainform_SizeChanged(object sender, EventArgs e)
        {
            history.Size = new Size(history.Size.Width, this.Size.Height - 201);
            send.Location = new Point(12, this.Size.Height - 73);
            history.Size = new Size(history.Size.Width, history.Size.Height + 1);
            MoveHist();
        }

        private void отключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONNECTED = false;
            if (ISCLIENT)
            {
                try
                {
                    ClToSr.Close();
                }
                catch { }
                try
                {
                    ClToSr = null;
                }
                catch { }
                AddHist("Отключены успешно");
            }
            else
            {
                int nwU = 0;
                while (MxUsr > nwU)
                {
                    if (client[nwU] != null)
                    {
                        try { client[nwU].Close(); }
                        catch { }
                        try { client[nwU] = null; }
                        catch { }
                    }
                    nwU++;
                }
                try { newsock.Close(); }
                catch { }
                try { newsock = null; }
                catch { }
            }
            CONNECTED = false;
            StatusCHange();
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (ISCLIENT)
            {
                SendToSr(false);
            }
            else
            {
                SendOn(false);
            }
        }
        private void mess_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Shift)
                { return; }
                else
                {
                    if (CONNECTED)
                        if (ISCLIENT)
                        {
                            SendToSr(true);
                        }
                        else
                        {
                            SendOn(true);
                        }
                }
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ads = new About();
            ads.Show();
        }
        private void настройкиЧатаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings st = new Settings(this);
            st.Show();
        }
        private void списокПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usrFR = new USerLIst(this);
            usrFR.Show();
        }

        void StatusCHange()
        {
            if (CONNECTED)
            {
                списокПользователейToolStripMenuItem.Enabled = true;
                send.Enabled = true;
                mess.Enabled = true;
                подключитьсяКToolStripMenuItem.Enabled = false;
                создатьСерверToolStripMenuItem.Enabled = false;
                отключитьсяToolStripMenuItem.Enabled = true;
            }
            else
            {
                списокПользователейToolStripMenuItem.Enabled = false;
                mess.Enabled = false;
                send.Enabled = false;
                подключитьсяКToolStripMenuItem.Enabled = true;
                создатьСерверToolStripMenuItem.Enabled = true;
                отключитьсяToolStripMenuItem.Enabled = false;
            }
        }

        //VARS
        public string adminName, servName, IPsr, UserName;

        Make_Server frm2;
        Connect cont;
        USerLIst usrFR;

        public Socket[] client;
        Socket newsock;
        IPEndPoint iep;
        int NumCl;
        public int MxUsr, PORTsr;

        public bool CONNECTED, ISCLIENT,micON;

        public string AudioFile;

        public string[] userlist;
        public Thread receiverЫ;
       public Audio aud;
        //thynhr  
        #region Thinhronisation
        delegate void SetTextCallback(string text);
        delegate void MovTextCallback();
        public void AddHist(string text)
        {
            if (this.history.InvokeRequired)
            {

                SetTextCallback d = new SetTextCallback(AddHist);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                history.Text += text;
                history.SelectionStart = history.TextLength;
                history.ScrollToCaret();
            }
        }
        public void MoveHist()
        {
            if (this.history.InvokeRequired)
            {

                MovTextCallback d = new MovTextCallback(MoveHist);
                this.Invoke(d, new object[] { });
            }
            else
            {
                history.SelectionStart = history.TextLength;
                history.ScrollToCaret();
            }
        }
        #endregion
        
        public mainform()
        {
            micON = true;
            CONNECTED = false;
            NumCl = 0;
            InitializeComponent();
            StatusCHange();
            aud = new Audio(@"IncomingIM.mp3");
        }

        //SERVER
        public void MakeServerStart()
        {
            ISCLIENT = false;
            CONNECTED = true;
            StatusCHange();
            newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            iep = new IPEndPoint(IPAddress.Any, 9050);
            newsock.Bind(iep);
            newsock.Listen(5);
            newsock.BeginAccept(new AsyncCallback(AcceptConn), newsock);
        }
        void AcceptConn(IAsyncResult iar)
        {
            NumCl = 0;
            string usrName;
            if (CONNECTED)
            {
                Socket oldserver = (Socket)iar.AsyncState;
                while (client[NumCl] != null)
                {
                    NumCl++;
                    if (NumCl > MxUsr - 1)
                    { NumCl = -1; break; }
                }
                if (NumCl == -1)
                {
                    oldserver.Close();
                    MakeServerStart();
                }
                else
                {
                    try
                    {
                        client[NumCl] = oldserver.EndAccept(iar);
                    }
                    catch { }
                    oldserver.Close();


                    byte[] data = new byte[1024];
                    int recv;

                    try
                    {
                        recv = client[NumCl].Receive(data);
                    }
                    catch
                    {
                        AddHist("\nОшибка соединения с клиентом");
                        client[NumCl] = null;
                        MakeServerStart();
                        return;
                    }

                    usrName = Encoding.UTF8.GetString(data, 0, recv);

                    int nwUsr = 0;
                    if (adminName.Trim() != usrName.Trim())
                    {
                        while (MxUsr > nwUsr)
                        {
                            if (userlist[nwUsr] != null)
                            {
                                if (userlist[nwUsr].Trim() == usrName.Trim())
                                {
                                    byte[] message = Encoding.UTF8.GetBytes("Пользователь с таким ником уже существует");
                                    client[NumCl].BeginSend(message, 0, message.Length, 0, new AsyncCallback(SendDataEnd), client[NumCl]);
                                    client[NumCl].Close();
                                    client[NumCl] = null;
                                    MakeServerStart();
                                    return;
                                }
                            }
                            nwUsr++;
                        }
                    }
                    else
                    {
                        byte[] message = Encoding.UTF8.GetBytes("\nПользователь с таким ником уже существует");
                        client[NumCl].BeginSend(message, 0, message.Length, 0, new AsyncCallback(SendDataEnd), client[NumCl]);
                        client[NumCl].Close();
                        client[NumCl] = null;
                        MakeServerStart();
                        return;
                    }

                    userlist[NumCl] = usrName;

                    AddHist("\nПодключён: " + client[NumCl].RemoteEndPoint.ToString() + " : " + userlist[NumCl]);
                    SendToAll("\nПодключён: " + userlist[NumCl], NumCl);
                    Thread receiver = new Thread(ReceiveData);
                    receiver.IsBackground = true;
                    receiver.Start(NumCl);

                    MakeServerStart();
                }
            }
            else { AddHist("\nСервер отключён"); }
        }
        void SendOn(bool Ent)
        {
            string Redy="",priv=null;
            if (mess.Text.Trim().Length > 0)
            {
                int clNm = 0;

                if (Ent)
                    Redy = ("\n" + adminName + ": " + mess.Text.Substring(0, mess.Text.Length - 1));
                else
                    Redy = ("\n" + adminName + ": " + mess.Text);

                byte[] message = Encoding.UTF8.GetBytes(Redy);


                Thread Privat = new Thread(delegate() { PrivatMessage(Redy,true); });
                Privat.IsBackground = true;

                if (mess.Text.Length >= 4)
                {
                    if (mess.Text.Substring(0, 4) == "%пр%")
                    {
                        Privat.Start();
                        if (Ent)
                            priv = ("\n" + adminName + ": " + mess.Text.Substring(3, mess.Text.Length - 4));
                        else
                            priv = ("\n" + adminName + ": " + mess.Text.Substring(3));
                    }
                    else
                    {
                        while (MxUsr > clNm)
                        {
                            if (client[clNm] != null)
                            {
                                try
                                {
                                    client[clNm].BeginSend(message, 0, message.Length, 0, new AsyncCallback(SendData), client[clNm]);
                                }
                                catch { }
                            }
                            clNm++;
                        }
                    }
                }
                else
                {
                    while (MxUsr > clNm)
                    {
                        if (client[clNm] != null)
                        {
                            try
                            {
                                client[clNm].BeginSend(message, 0, message.Length, 0, new AsyncCallback(SendData), client[clNm]);
                            }
                            catch { }
                        }
                        clNm++;
                    }
                }
                if (priv != null)
                {
                    AddHist(priv);
                    MoveHist();

                    mess.Clear();
                    priv = null;
                }
                else
                {
                    AddHist(Redy);
                    MoveHist();

                    mess.Clear();
                }
                
            }
            else { mess.Clear(); }
        }
        void SendData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int sent = remote.EndSend(iar);
        }

        void ReceiveData(object nm)
        {
            byte[] data = new byte[1024];
            int Clnm = (int)nm;
            int recv = 0;
            string stringData="",stData="",userNM=userlist[Clnm];


            while (true)
            {
                try
                {
                    Thread sendall = new Thread(delegate() { SendToAll(stringData, Clnm); });
                    sendall.IsBackground = true;

                    Thread Privat = new Thread(delegate() { PrivatMessage(stData, false); });
                    Privat.IsBackground = true;

                    recv = client[Clnm].Receive(data);

                    if (Encoding.UTF8.GetString(data, 0, recv) == "*get_all_users_tocl*")
                    {
                        Thread getlist = new Thread(delegate() { GenUserList(Clnm); });
                        getlist.IsBackground = true;
                        getlist.Start();
                        stringData = "*get_all_users_tocl*";
                    }
                    else
                    {
                        string ttt = Encoding.UTF8.GetString(data, 0, recv);
                        if (ttt.Substring((userlist[Clnm].Length + 3)).Length >= 4)
                        {
                            if (ttt.Substring((userlist[Clnm].Length + 3), 4) == "%пр%")
                            {
                                stData = Encoding.UTF8.GetString(data, 0, recv);
                                Privat.Start();
                                stringData = "*get_all_users_tocl*";
                            }
                            else
                            {
                                stringData = Encoding.UTF8.GetString(data, 0, recv);
                                sendall.Start();
                            }
                        }
                        else
                        {
                            stringData = Encoding.UTF8.GetString(data, 0, recv);
                            sendall.Start();
                        }
                    }

                }
                catch
                {
                    AddHist("\nПользователь \"" + userNM + "\" отключился.");
                    SendToAll("\nПользователь \"" + userNM + "\" отключился.", Clnm);
                    break;
                }
                if (stringData != "*get_all_users_tocl*")
                {                    
                    AddHist(stringData);
                    if (micON)
                    {
                        aud.CurrentPosition = 0.0f;
                        aud.Play();
                    }
                    MoveHist();
                }
            } try
            {
                client[Clnm].Close();
            }
            catch { }
            client[Clnm] = null;
            userlist[Clnm] = null;
            return;
        }

        void PrivatMessage(string text,bool isadmin)
        {
            string[] txtC = text.Split('%');
            int mxI = txtC.Length, now = 0;

            string Tsend = "";
            string User = "";
            string UtS = "";
            try
            {
                UtS = txtC[2];
                User = txtC[0].Substring(1).Split(':')[0];
                Tsend = "\nПриват от \"" + User + "\": " + text.Substring(txtC[0].Length + txtC[1].Length + txtC[2].Length + 3);

                if (User != UtS)
                {
                    if (UtS == adminName)
                    {
                        AddHist(Tsend);
                    }
                    else
                    {
                        while (MxUsr > now)
                        {
                            if (userlist[now] == UtS)
                            {
                                try
                                {
                                    byte[] message = Encoding.UTF8.GetBytes(Tsend);
                                    client[now].BeginSend(message, 0, message.Length, 0, new AsyncCallback(SendData), client[now]);
                                }
                                catch { }
                                break;

                            }
                            now++;
                        }
                        if (now == MxUsr)
                        {
                            now = 0;

                            if (isadmin)
                            {
                                AddHist("\nПользователь \"" + UtS + "\" не найден.");
                            }
                            else
                            {
                                while (MxUsr > now)
                                {
                                    if (userlist[now] == User)
                                    {
                                        try
                                        {
                                            byte[] message = Encoding.UTF8.GetBytes("\nПользователь \"" + UtS + "\" не найден.");
                                            client[now].BeginSend(message, 0, message.Length, 0, new AsyncCallback(SendData), client[now]);
                                        }
                                        catch { }
                                        break;
                                    }
                                    now++;
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                try
                {
                    byte[] message = Encoding.UTF8.GetBytes("\nПользователь \"" + UtS + "\" не найден.");
                    client[now].BeginSend(message, 0, message.Length, 0, new AsyncCallback(SendData), client[now]);
                }
                catch { }
            }

        }

        void GenUserList(int usrID)
        {
            byte[] data = new byte[1024];
            int nowu = 0;
            byte[] message;
            string usLi = "";
            message = Encoding.UTF8.GetBytes("\nВывожу список пользователей");
            client[usrID].BeginSend(message, 0, message.Length, 0, new AsyncCallback(SendDataEnd), client[usrID]);

            usLi = adminName;

            while (nowu < MxUsr)
            {

                if (userlist[nowu] != null)
                {
                    usLi += "%" + userlist[nowu];
                    
                }
                nowu++;
            }
            message = Encoding.UTF8.GetBytes(usLi);
            client[usrID].BeginSend(message, 0, message.Length, 0, new AsyncCallback(SendDataEnd), client[usrID]);
        }
        void SendToAll(string mess, int clSNDD)
        {
            int i = 0;
            while (i < MxUsr)
            {
                if ((clSNDD != i) && (client[i] != null))
                {
                    byte[] message = Encoding.UTF8.GetBytes(mess);
                    client[i].BeginSend(message, 0, message.Length, 0, new AsyncCallback(SendData), client[i]);
                }
                i++;
            }
        }

        public void SendDataEnd(IAsyncResult iar)
        {
            try
            {
                Socket remote = (Socket)iar.AsyncState;
                int sent = remote.EndSend(iar);
            }
            catch { }
        }
        public void CickUser(string usrName)
        {
            int nw = 0;
            while (MxUsr > nw)
            {
                if (userlist[nw] != null)
                {
                    if (userlist[nw] == usrName.Substring(0,usrName.Length-1))
                    {
                        break;
                    }
                }
                nw++;
                if (nw == MxUsr) { MessageBox.Show("Ошибка выдачи кика"); return; }

            }
            try
            {
                byte[] message = Encoding.UTF8.GetBytes("\nВы были отключены от сервера.");
                client[nw].BeginSend(message, 0, message.Length, 0, new AsyncCallback(SendDataEnd), client[nw]);
            }
            catch { MessageBox.Show("Ошибка выдачи кика"); }
            client[nw].Close();
            client[nw] = null;
            userlist[nw] = null;
        }

        //CLIENT
        public Socket ClToSr;
        public void ConnectToServ()
        {
            ISCLIENT = true;
            CONNECTED = true;
            StatusCHange();
            AddHist("\nСоединение...");
            ClToSr = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IPsr), PORTsr);
            ClToSr.BeginConnect(iep, new AsyncCallback(ConnectedToSr), ClToSr);
        }
        void ConnectedToSr(IAsyncResult iar)
        {
            try
            {
                ClToSr.EndConnect(iar);
                AddHist("\nУспешно подключены к: " + ClToSr.RemoteEndPoint.ToString());

                byte[] message = Encoding.UTF8.GetBytes(UserName);
                ClToSr.BeginSend(message, 0, message.Length, 0, new AsyncCallback(SendDataSr), ClToSr);

                receiverЫ = new Thread(new ThreadStart(ReceiveDataToSr));
                receiverЫ.Name = "RforCL";
                receiverЫ.IsBackground = true;
                receiverЫ.Start();

            }
            catch (SocketException)
            {
                CONNECTED = false;
                AddHist("\nОшибка соединения! Возможно сервер переполнен либо нет связи.");
                StatusCHange();
            }
        }
        void SendToSr(bool Ent)
        {
            string RedY,priv=null;
            if (mess.Text.Trim().Length > 0)
            {
                if (Ent)
                    RedY = ("\n" + UserName + ": " + mess.Text.Substring(0, mess.Text.Length - 1));
                else
                    RedY = ("\n" + UserName + ": " + mess.Text);

                byte[] message = Encoding.UTF8.GetBytes(RedY);

                if (mess.Text.Length >= 4)
                {
                    if (mess.Text.Substring(0, 4) == "%пр%")
                    {
                        if (Ent)
                            priv = ("\n" + UserName + ": " + mess.Text.Substring(3, mess.Text.Length - 4));
                        else
                            priv = ("\n" + UserName + ": " + mess.Text.Substring(3));
                    }
                } 
                if (priv != null)
                {
                    AddHist(priv);
                    MoveHist();

                    mess.Clear();
                    priv = null;
                }
                else
                {
                    AddHist(RedY);
                    MoveHist();

                    mess.Clear();
                }

                ClToSr.BeginSend(message, 0, message.Length, 0, new AsyncCallback(SendDataSr), ClToSr);

            }
            else { mess.Clear(); }
        }
        void SendDataSr(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int sent = remote.EndSend(iar);
        }
        void ReceiveDataToSr()
        {
            byte[] data = new byte[1024];
            int recv;
            string stringData;
            while (true)
            {
                try
                {
                    recv = ClToSr.Receive(data);
                }
                catch { break; }
                stringData = Encoding.UTF8.GetString(data, 0, recv);
                AddHist(stringData);
                if (micON)
                {
                    aud.CurrentPosition = 0.0f;
                    aud.Play();
                }
                MoveHist();
            }
            ClToSr.Close();
            AddHist("\nСоединение c сервером было разорвано.");
            CONNECTED = false;
            StatusCHange();
            return;
        }
    }
}