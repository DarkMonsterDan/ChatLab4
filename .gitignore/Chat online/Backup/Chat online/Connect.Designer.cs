namespace Chat_online
{
    partial class Connect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect));
            this.label1 = new System.Windows.Forms.Label();
            this.ipnum = new System.Windows.Forms.TextBox();
            this.goooo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.porttoS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // ipnum
            // 
            this.ipnum.Location = new System.Drawing.Point(38, 6);
            this.ipnum.MaxLength = 20;
            this.ipnum.Name = "ipnum";
            this.ipnum.Size = new System.Drawing.Size(234, 20);
            this.ipnum.TabIndex = 1;
            // 
            // goooo
            // 
            this.goooo.Location = new System.Drawing.Point(12, 84);
            this.goooo.Name = "goooo";
            this.goooo.Size = new System.Drawing.Size(260, 23);
            this.goooo.TabIndex = 3;
            this.goooo.Text = "Connect!";
            this.goooo.UseVisualStyleBackColor = true;
            this.goooo.Click += new System.EventHandler(this.goooo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ник:";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(57, 58);
            this.login.MaxLength = 20;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(215, 20);
            this.login.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Порт:";
            // 
            // porttoS
            // 
            this.porttoS.Location = new System.Drawing.Point(53, 32);
            this.porttoS.MaxLength = 10;
            this.porttoS.Name = "porttoS";
            this.porttoS.Size = new System.Drawing.Size(219, 20);
            this.porttoS.TabIndex = 1;
            this.porttoS.Text = "9050";
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goooo);
            this.Controls.Add(this.login);
            this.Controls.Add(this.porttoS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipnum);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 154);
            this.MinimumSize = new System.Drawing.Size(300, 154);
            this.Name = "Connect";
            this.Text = "Connect to server";
            this.Shown += new System.EventHandler(this.Connect_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipnum;
        private System.Windows.Forms.Button goooo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox porttoS;
    }
}