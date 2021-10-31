namespace Chat_online
{
    partial class USerLIst
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USerLIst));
            this.userLtxt = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.написатьВПриватToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userLtxt
            // 
            this.userLtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userLtxt.ContextMenuStrip = this.contextMenuStrip1;
            this.userLtxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLtxt.FormattingEnabled = true;
            this.userLtxt.Location = new System.Drawing.Point(0, 0);
            this.userLtxt.Name = "userLtxt";
            this.userLtxt.Size = new System.Drawing.Size(294, 416);
            this.userLtxt.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.написатьВПриватToolStripMenuItem,
            this.обновитьToolStripMenuItem,
            this.кикToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 70);
            // 
            // написатьВПриватToolStripMenuItem
            // 
            this.написатьВПриватToolStripMenuItem.Name = "написатьВПриватToolStripMenuItem";
            this.написатьВПриватToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.написатьВПриватToolStripMenuItem.Text = "Написать в приват";
            this.написатьВПриватToolStripMenuItem.Click += new System.EventHandler(this.написатьВПриватToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // кикToolStripMenuItem
            // 
            this.кикToolStripMenuItem.Name = "кикToolStripMenuItem";
            this.кикToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.кикToolStripMenuItem.Text = "Кик";
            this.кикToolStripMenuItem.Click += new System.EventHandler(this.кикToolStripMenuItem_Click);
            // 
            // USerLIst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 420);
            this.Controls.Add(this.userLtxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(310, 458);
            this.MinimumSize = new System.Drawing.Size(310, 458);
            this.Name = "USerLIst";
            this.Text = "Список пользователей";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox userLtxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem написатьВПриватToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
    }
}