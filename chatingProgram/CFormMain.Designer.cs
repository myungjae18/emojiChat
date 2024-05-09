namespace ChatClient
{
    partial class CFormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CFormMain));
            this.grpConnect = new System.Windows.Forms.GroupBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIpAddr = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.timerReceive = new System.Windows.Forms.Timer(this.components);
            this.btnEmoji = new System.Windows.Forms.Button();
            this.grpConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnect
            // 
            this.grpConnect.Controls.Add(this.btConnect);
            this.grpConnect.Controls.Add(this.lblPort);
            this.grpConnect.Controls.Add(this.lblIpAddr);
            this.grpConnect.Controls.Add(this.txtPort);
            this.grpConnect.Controls.Add(this.txtIpAddress);
            this.grpConnect.Location = new System.Drawing.Point(-2, 2);
            this.grpConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConnect.Name = "grpConnect";
            this.grpConnect.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConnect.Size = new System.Drawing.Size(862, 114);
            this.grpConnect.TabIndex = 0;
            this.grpConnect.TabStop = false;
            // 
            // btConnect
            // 
            this.btConnect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btConnect.Font = new System.Drawing.Font("Verdana", 40F, System.Drawing.FontStyle.Bold);
            this.btConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btConnect.Location = new System.Drawing.Point(448, 29);
            this.btConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(409, 77);
            this.btConnect.TabIndex = 4;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = false;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblPort.Location = new System.Drawing.Point(17, 77);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(44, 14);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port :";
            // 
            // lblIpAddr
            // 
            this.lblIpAddr.AutoSize = true;
            this.lblIpAddr.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblIpAddr.Location = new System.Drawing.Point(17, 48);
            this.lblIpAddr.Name = "lblIpAddr";
            this.lblIpAddr.Size = new System.Drawing.Size(88, 14);
            this.lblIpAddr.TabIndex = 2;
            this.lblIpAddr.Text = "IP Address :";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(119, 76);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(88, 21);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "10050";
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(119, 47);
            this.txtIpAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(316, 21);
            this.txtIpAddress.TabIndex = 0;
            this.txtIpAddress.Text = "220.67.174.71";
            // 
            // txtReceive
            // 
            this.txtReceive.Font = new System.Drawing.Font("Verdana", 13F);
            this.txtReceive.Location = new System.Drawing.Point(-2, 121);
            this.txtReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReceive.Size = new System.Drawing.Size(862, 474);
            this.txtReceive.TabIndex = 1;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(-2, 599);
            this.txtSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.ReadOnly = true;
            this.txtSend.Size = new System.Drawing.Size(490, 58);
            this.txtSend.TabIndex = 2;
            // 
            // btSend
            // 
            this.btSend.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btSend.Font = new System.Drawing.Font("Verdana", 20F);
            this.btSend.Location = new System.Drawing.Point(695, 599);
            this.btSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(165, 58);
            this.btSend.TabIndex = 3;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = false;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // timerReceive
            // 
            this.timerReceive.Tick += new System.EventHandler(this.timerReceive_Tick);
            // 
            // btnEmoji
            // 
            this.btnEmoji.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEmoji.Font = new System.Drawing.Font("Verdana", 20F);
            this.btnEmoji.Location = new System.Drawing.Point(513, 599);
            this.btnEmoji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmoji.Name = "btnEmoji";
            this.btnEmoji.Size = new System.Drawing.Size(165, 58);
            this.btnEmoji.TabIndex = 4;
            this.btnEmoji.Text = "Emoji";
            this.btnEmoji.UseVisualStyleBackColor = false;
            this.btnEmoji.Click += new System.EventHandler(this.btnEmoji_Click);
            // 
            // CFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(867, 665);
            this.Controls.Add(this.btnEmoji);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.grpConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CFormMain";
            this.Text = "Chat Client";
            this.grpConnect.ResumeLayout(false);
            this.grpConnect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnect;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIpAddr;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Timer timerReceive;
        private System.Windows.Forms.Button btnEmoji;
    }
}

