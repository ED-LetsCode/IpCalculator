namespace IpCalculatorWinForms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.CalculateIP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SubnetMask = new System.Windows.Forms.TextBox();
            this.HostParts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NetworkAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BroadcastAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstHost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LastHost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(157, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Example => 192.168.0.1/24";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(97, 125);
            this.UserInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(350, 31);
            this.UserInput.TabIndex = 1;
            this.UserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserInput.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // CalculateIP
            // 
            this.CalculateIP.BackColor = System.Drawing.Color.White;
            this.CalculateIP.Location = new System.Drawing.Point(181, 198);
            this.CalculateIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CalculateIP.Name = "CalculateIP";
            this.CalculateIP.Size = new System.Drawing.Size(181, 38);
            this.CalculateIP.TabIndex = 2;
            this.CalculateIP.Text = "Calculate";
            this.CalculateIP.UseVisualStyleBackColor = false;
            this.CalculateIP.Click += new System.EventHandler(this.CalculateIP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(226, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subnet Mask";
            // 
            // SubnetMask
            // 
            this.SubnetMask.Enabled = false;
            this.SubnetMask.Location = new System.Drawing.Point(97, 302);
            this.SubnetMask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubnetMask.Name = "SubnetMask";
            this.SubnetMask.Size = new System.Drawing.Size(350, 31);
            this.SubnetMask.TabIndex = 4;
            this.SubnetMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HostParts
            // 
            this.HostParts.Enabled = false;
            this.HostParts.Location = new System.Drawing.Point(97, 478);
            this.HostParts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HostParts.Name = "HostParts";
            this.HostParts.Size = new System.Drawing.Size(350, 31);
            this.HostParts.TabIndex = 6;
            this.HostParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(240, 448);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Host parts";
            // 
            // NetworkAdress
            // 
            this.NetworkAdress.Enabled = false;
            this.NetworkAdress.Location = new System.Drawing.Point(97, 395);
            this.NetworkAdress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NetworkAdress.Name = "NetworkAdress";
            this.NetworkAdress.Size = new System.Drawing.Size(350, 31);
            this.NetworkAdress.TabIndex = 8;
            this.NetworkAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(221, 365);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Network adress";
            // 
            // BroadcastAdress
            // 
            this.BroadcastAdress.Enabled = false;
            this.BroadcastAdress.Location = new System.Drawing.Point(97, 560);
            this.BroadcastAdress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BroadcastAdress.Name = "BroadcastAdress";
            this.BroadcastAdress.Size = new System.Drawing.Size(350, 31);
            this.BroadcastAdress.TabIndex = 10;
            this.BroadcastAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(210, 530);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Broadcast adress";
            // 
            // FirstHost
            // 
            this.FirstHost.Enabled = false;
            this.FirstHost.Location = new System.Drawing.Point(97, 642);
            this.FirstHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstHost.Name = "FirstHost";
            this.FirstHost.Size = new System.Drawing.Size(350, 31);
            this.FirstHost.TabIndex = 12;
            this.FirstHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(240, 612);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "First host";
            // 
            // LastHost
            // 
            this.LastHost.Enabled = false;
            this.LastHost.Location = new System.Drawing.Point(97, 730);
            this.LastHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastHost.Name = "LastHost";
            this.LastHost.Size = new System.Drawing.Size(350, 31);
            this.LastHost.TabIndex = 14;
            this.LastHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(241, 700);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Last host";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(199, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 35);
            this.label8.TabIndex = 15;
            this.label8.Text = "IP CALCULATOR";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveFile
            // 
            this.SaveFile.BackColor = System.Drawing.Color.White;
            this.SaveFile.Location = new System.Drawing.Point(181, 805);
            this.SaveFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(181, 38);
            this.SaveFile.TabIndex = 16;
            this.SaveFile.Text = "Save file";
            this.SaveFile.UseVisualStyleBackColor = false;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 878);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LastHost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FirstHost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BroadcastAdress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NetworkAdress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HostParts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubnetMask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalculateIP);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Ip calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox UserInput;
        private Button CalculateIP;
        private Label label2;
        private TextBox SubnetMask;
        private TextBox HostParts;
        private Label label3;
        private TextBox NetworkAdress;
        private Label label4;
        private TextBox BroadcastAdress;
        private Label label5;
        private TextBox FirstHost;
        private Label label6;
        private TextBox LastHost;
        private Label label7;
        private Label label8;
        private Button SaveFile;
    }
}