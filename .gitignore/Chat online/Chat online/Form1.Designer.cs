namespace Chat_online
{
    partial class mainform
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.send = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отключитьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключитьсяКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьСерверToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиЧатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mess = new System.Windows.Forms.RichTextBox();
            this.history = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(12, 327);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(152, 23);
            this.send.TabIndex = 0;
            this.send.Text = "Отправить";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.управлениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отключитьсяToolStripMenuItem,
            this.подключитьсяКToolStripMenuItem,
            this.создатьСерверToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // отключитьсяToolStripMenuItem
            // 
            this.отключитьсяToolStripMenuItem.Name = "отключитьсяToolStripMenuItem";
            this.отключитьсяToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.отключитьсяToolStripMenuItem.Text = "Отключиться";
            this.отключитьсяToolStripMenuItem.Click += new System.EventHandler(this.отключитьсяToolStripMenuItem_Click);
            // 
            // подключитьсяКToolStripMenuItem
            // 
            this.подключитьсяКToolStripMenuItem.Name = "подключитьсяКToolStripMenuItem";
            this.подключитьсяКToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.подключитьсяКToolStripMenuItem.Text = "Подключиться к  серверу";
            this.подключитьсяКToolStripMenuItem.Click += new System.EventHandler(this.подключитьсяКToolStripMenuItem_Click);
            // 
            // создатьСерверToolStripMenuItem
            // 
            this.создатьСерверToolStripMenuItem.Name = "создатьСерверToolStripMenuItem";
            this.создатьСерверToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.создатьСерверToolStripMenuItem.Text = "Создать сервер";
            this.создатьСерверToolStripMenuItem.Click += new System.EventHandler(this.создатьСерверToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокПользователейToolStripMenuItem,
            this.настройкиЧатаToolStripMenuItem});
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.управлениеToolStripMenuItem.Text = "Управление";
            // 
            // списокПользователейToolStripMenuItem
            // 
            this.списокПользователейToolStripMenuItem.Name = "списокПользователейToolStripMenuItem";
            this.списокПользователейToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.списокПользователейToolStripMenuItem.Text = "Список пользователей";
            this.списокПользователейToolStripMenuItem.Click += new System.EventHandler(this.списокПользователейToolStripMenuItem_Click);
            // 
            // настройкиЧатаToolStripMenuItem
            // 
            this.настройкиЧатаToolStripMenuItem.Name = "настройкиЧатаToolStripMenuItem";
            this.настройкиЧатаToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.настройкиЧатаToolStripMenuItem.Text = "Настройки чата";
            this.настройкиЧатаToolStripMenuItem.Click += new System.EventHandler(this.настройкиЧатаToolStripMenuItem_Click);
            // 
            // mess
            // 
            this.mess.Dock = System.Windows.Forms.DockStyle.Top;
            this.mess.Location = new System.Drawing.Point(0, 224);
            this.mess.Name = "mess";
            this.mess.Size = new System.Drawing.Size(484, 90);
            this.mess.TabIndex = 3;
            this.mess.Text = "";
            this.mess.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mess_KeyUp);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.SystemColors.Window;
            this.history.Dock = System.Windows.Forms.DockStyle.Top;
            this.history.Location = new System.Drawing.Point(0, 24);
            this.history.Name = "history";
            this.history.ReadOnly = true;
            this.history.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.history.Size = new System.Drawing.Size(484, 200);
            this.history.TabIndex = 2;
            this.history.Text = "";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.mess);
            this.Controls.Add(this.history);
            this.Controls.Add(this.send);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(250, 400);
            this.Name = "mainform";
            this.Text = "Chat online";
            this.Load += new System.EventHandler(this.mainform_Load);
            this.SizeChanged += new System.EventHandler(this.mainform_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключитьсяКToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьСерверToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.RichTextBox history;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиЧатаToolStripMenuItem;
        public System.Windows.Forms.RichTextBox mess;
        private System.Windows.Forms.ToolStripMenuItem отключитьсяToolStripMenuItem;
    }
}

