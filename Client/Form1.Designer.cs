namespace Client
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PortTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IpTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Info = new System.Windows.Forms.RichTextBox();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.FilesTree = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PortTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IpTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ConnectBtn);
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 87);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Information";
            // 
            // PortTb
            // 
            this.PortTb.Location = new System.Drawing.Point(275, 25);
            this.PortTb.Name = "PortTb";
            this.PortTb.Size = new System.Drawing.Size(157, 20);
            this.PortTb.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port No";
            // 
            // IpTb
            // 
            this.IpTb.Location = new System.Drawing.Point(63, 25);
            this.IpTb.Name = "IpTb";
            this.IpTb.Size = new System.Drawing.Size(157, 20);
            this.IpTb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server IP";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(9, 51);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(423, 23);
            this.ConnectBtn.TabIndex = 6;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Info);
            this.groupBox2.Controls.Add(this.DownloadBtn);
            this.groupBox2.Controls.Add(this.FilesTree);
            this.groupBox2.Location = new System.Drawing.Point(18, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 288);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remote Directory";
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(229, 19);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(203, 225);
            this.Info.TabIndex = 10;
            this.Info.Text = "";
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Location = new System.Drawing.Point(229, 250);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(203, 23);
            this.DownloadBtn.TabIndex = 8;
            this.DownloadBtn.Text = "Download";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // FilesTree
            // 
            this.FilesTree.Location = new System.Drawing.Point(12, 19);
            this.FilesTree.Name = "FilesTree";
            this.FilesTree.Size = new System.Drawing.Size(208, 254);
            this.FilesTree.TabIndex = 7;
            this.FilesTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FilesTree_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(482, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "File Transfer - Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PortTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IpTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.TreeView FilesTree;
        private System.Windows.Forms.RichTextBox Info;
    }
}

