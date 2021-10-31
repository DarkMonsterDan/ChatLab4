namespace Chat_online
{
    partial class Make_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Make_Server));
            this.label2 = new System.Windows.Forms.Label();
            this.adminNAme = new System.Windows.Forms.TextBox();
            this.okey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mxUsr = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ваш ник:";
            // 
            // adminNAme
            // 
            this.adminNAme.Location = new System.Drawing.Point(67, 58);
            this.adminNAme.MaxLength = 20;
            this.adminNAme.Name = "adminNAme";
            this.adminNAme.Size = new System.Drawing.Size(168, 20);
            this.adminNAme.TabIndex = 1;
            // 
            // okey
            // 
            this.okey.Location = new System.Drawing.Point(12, 84);
            this.okey.Name = "okey";
            this.okey.Size = new System.Drawing.Size(223, 23);
            this.okey.TabIndex = 3;
            this.okey.Text = "Запустить сервер!";
            this.okey.UseVisualStyleBackColor = true;
            this.okey.Click += new System.EventHandler(this.okey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Макс. кол-во юзеров:";
            // 
            // mxUsr
            // 
            this.mxUsr.Location = new System.Drawing.Point(132, 6);
            this.mxUsr.MaxLength = 5;
            this.mxUsr.Name = "mxUsr";
            this.mxUsr.Size = new System.Drawing.Size(103, 20);
            this.mxUsr.TabIndex = 1;
            this.mxUsr.Text = "200";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(50, 32);
            this.port.MaxLength = 10;
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(185, 20);
            this.port.TabIndex = 1;
            this.port.Text = "9050";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Порт:";
            // 
            // Make_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 122);
            this.Controls.Add(this.okey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.port);
            this.Controls.Add(this.mxUsr);
            this.Controls.Add(this.adminNAme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(263, 161);
            this.MinimumSize = new System.Drawing.Size(263, 161);
            this.Name = "Make_Server";
            this.Text = "Создать сервер";
            this.Load += new System.EventHandler(this.Make_Server_Load);
            this.Shown += new System.EventHandler(this.Make_Server_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminNAme;
        private System.Windows.Forms.Button okey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mxUsr;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Label label3;
    }
}