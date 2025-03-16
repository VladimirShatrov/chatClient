namespace RSClient
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(12, 12);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(150, 20);
            this.txtServerIP.TabIndex = 0;
            this.txtServerIP.Text = "127.0.0.1";

            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 40);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "User";

            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(12, 70);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(560, 150);
            this.txtChat.TabIndex = 2;
            this.txtChat.ReadOnly = true;

            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 230);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(400, 20);
            this.txtMessage.TabIndex = 3;

            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(480, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Подключиться";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);

            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(480, 230);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 270);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "Чат-клиент";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
