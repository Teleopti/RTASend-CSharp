namespace SendRTA
{
    partial class SendRTA
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StateCode = new System.Windows.Forms.ListBox();
            this.AcdLogonId = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "SendRTASingleUser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.feedRTA_SendRTASingleuser);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "SendRTABatch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.feedRTA_SendRTABatch);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "SendRTASnapShot";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.feedRTA_SendRTASnapShot);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 24);
            this.button4.TabIndex = 3;
            this.button4.Text = "SendEmptySnapShot";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.feedRTA_SendEmptySnapShot);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StateCode);
            this.groupBox1.Controls.Add(this.AcdLogonId);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(237, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 178);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SetAgentToWeb";
            // 
            // StateCode
            // 
            this.StateCode.FormattingEnabled = true;
            this.StateCode.Items.AddRange(new object[] {
            "ACW",
            "ADMIN",
            "EMAIL",
            "IDLE",
            "InCall",
            "LOGGED ON",
            "Ready",
            "WEB",
            "OFF"});
            this.StateCode.Location = new System.Drawing.Point(17, 80);
            this.StateCode.Name = "StateCode";
            this.StateCode.Size = new System.Drawing.Size(134, 43);
            this.StateCode.TabIndex = 2;
            // 
            // AcdLogonId
            // 
            this.AcdLogonId.FormattingEnabled = true;
            this.AcdLogonId.Items.AddRange(new object[] {
            "0019\tJohn Smith",
            "0063\tPierre Baldi",
            "0068\tPrashant Arora",
            "0085\tAshley Andeen",
            "0202\tJuancho Banaag",
            "0238\tStephen Bay",
            "2000\tJohn King",
            "2001\tJon Kleinsmith",
            "2002\tRobert Klashner",
            "2003\tDmitry Pavlov"});
            this.AcdLogonId.Location = new System.Drawing.Point(17, 28);
            this.AcdLogonId.Name = "AcdLogonId";
            this.AcdLogonId.Size = new System.Drawing.Size(134, 30);
            this.AcdLogonId.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(17, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 22);
            this.button5.TabIndex = 0;
            this.button5.Text = "Send stateCode Web";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.feedRTA_SendOneAgentCustomStateCode);
            // 
            // SendRTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 225);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SendRTA";
            this.Text = "SendRTA";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox AcdLogonId;
        private System.Windows.Forms.ListBox StateCode;
    }
}

