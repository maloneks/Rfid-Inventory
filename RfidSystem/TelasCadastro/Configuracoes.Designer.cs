namespace RfidSystem.Telas
{
    partial class Configuracoes
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
            this.grbCommType = new System.Windows.Forms.GroupBox();
            this.cmbCommType = new System.Windows.Forms.ComboBox();
            this.grbPortName = new System.Windows.Forms.GroupBox();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.grbRemotePort = new System.Windows.Forms.GroupBox();
            this.txtRemotePort = new System.Windows.Forms.TextBox();
            this.grbBaudRate = new System.Windows.Forms.GroupBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.grbRemoteIP = new System.Windows.Forms.GroupBox();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.pnlConnect = new System.Windows.Forms.Panel();
            this.btnDisConnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbCommType.SuspendLayout();
            this.grbPortName.SuspendLayout();
            this.grbRemotePort.SuspendLayout();
            this.grbBaudRate.SuspendLayout();
            this.grbRemoteIP.SuspendLayout();
            this.pnlConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlConnect);
            this.groupBox1.Controls.Add(this.grbRemotePort);
            this.groupBox1.Controls.Add(this.grbBaudRate);
            this.groupBox1.Controls.Add(this.grbRemoteIP);
            this.groupBox1.Controls.Add(this.grbPortName);
            this.groupBox1.Controls.Add(this.grbCommType);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // grbCommType
            // 
            this.grbCommType.AutoSize = true;
            this.grbCommType.Controls.Add(this.cmbCommType);
            this.grbCommType.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbCommType.Location = new System.Drawing.Point(3, 16);
            this.grbCommType.MinimumSize = new System.Drawing.Size(120, 48);
            this.grbCommType.Name = "grbCommType";
            this.grbCommType.Padding = new System.Windows.Forms.Padding(5);
            this.grbCommType.Size = new System.Drawing.Size(142, 48);
            this.grbCommType.TabIndex = 8;
            this.grbCommType.TabStop = false;
            this.grbCommType.Text = "Communication";
            // 
            // cmbCommType
            // 
            this.cmbCommType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbCommType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCommType.FormattingEnabled = true;
            this.cmbCommType.Items.AddRange(new object[] {
            "0-RS232",
            "1-TCPIP",
            "2-USB"});
            this.cmbCommType.Location = new System.Drawing.Point(5, 18);
            this.cmbCommType.Name = "cmbCommType";
            this.cmbCommType.Size = new System.Drawing.Size(132, 21);
            this.cmbCommType.TabIndex = 2;
            this.cmbCommType.TabStop = false;
            this.cmbCommType.SelectedIndexChanged += new System.EventHandler(this.cmbCommType_SelectedIndexChanged);
            // 
            // grbPortName
            // 
            this.grbPortName.AutoSize = true;
            this.grbPortName.Controls.Add(this.cmbPortName);
            this.grbPortName.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbPortName.Location = new System.Drawing.Point(3, 64);
            this.grbPortName.MinimumSize = new System.Drawing.Size(120, 48);
            this.grbPortName.Name = "grbPortName";
            this.grbPortName.Padding = new System.Windows.Forms.Padding(5);
            this.grbPortName.Size = new System.Drawing.Size(142, 48);
            this.grbPortName.TabIndex = 9;
            this.grbPortName.TabStop = false;
            this.grbPortName.Text = "PortName";
            // 
            // cmbPortName
            // 
            this.cmbPortName.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(5, 18);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(132, 21);
            this.cmbPortName.TabIndex = 2;
            this.cmbPortName.TabStop = false;
            // 
            // grbRemotePort
            // 
            this.grbRemotePort.AutoSize = true;
            this.grbRemotePort.Controls.Add(this.txtRemotePort);
            this.grbRemotePort.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbRemotePort.Location = new System.Drawing.Point(3, 208);
            this.grbRemotePort.MinimumSize = new System.Drawing.Size(120, 48);
            this.grbRemotePort.Name = "grbRemotePort";
            this.grbRemotePort.Padding = new System.Windows.Forms.Padding(5);
            this.grbRemotePort.Size = new System.Drawing.Size(142, 48);
            this.grbRemotePort.TabIndex = 12;
            this.grbRemotePort.TabStop = false;
            this.grbRemotePort.Text = "Remote Port";
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRemotePort.Location = new System.Drawing.Point(5, 18);
            this.txtRemotePort.MaxLength = 5;
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(132, 20);
            this.txtRemotePort.TabIndex = 5;
            this.txtRemotePort.TabStop = false;
            this.txtRemotePort.Text = "49152";
            this.txtRemotePort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbBaudRate
            // 
            this.grbBaudRate.AutoSize = true;
            this.grbBaudRate.Controls.Add(this.cmbBaudRate);
            this.grbBaudRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbBaudRate.Location = new System.Drawing.Point(3, 160);
            this.grbBaudRate.MinimumSize = new System.Drawing.Size(120, 48);
            this.grbBaudRate.Name = "grbBaudRate";
            this.grbBaudRate.Padding = new System.Windows.Forms.Padding(5);
            this.grbBaudRate.Size = new System.Drawing.Size(142, 48);
            this.grbBaudRate.TabIndex = 10;
            this.grbBaudRate.TabStop = false;
            this.grbBaudRate.Text = "BaudRate";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "1200",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.cmbBaudRate.Location = new System.Drawing.Point(5, 18);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(132, 21);
            this.cmbBaudRate.TabIndex = 2;
            this.cmbBaudRate.TabStop = false;
            // 
            // grbRemoteIP
            // 
            this.grbRemoteIP.AutoSize = true;
            this.grbRemoteIP.Controls.Add(this.txtRemoteIP);
            this.grbRemoteIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbRemoteIP.Location = new System.Drawing.Point(3, 112);
            this.grbRemoteIP.MinimumSize = new System.Drawing.Size(120, 48);
            this.grbRemoteIP.Name = "grbRemoteIP";
            this.grbRemoteIP.Padding = new System.Windows.Forms.Padding(5);
            this.grbRemoteIP.Size = new System.Drawing.Size(142, 48);
            this.grbRemoteIP.TabIndex = 11;
            this.grbRemoteIP.TabStop = false;
            this.grbRemoteIP.Text = "Remote IP";
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtRemoteIP.Location = new System.Drawing.Point(5, 18);
            this.txtRemoteIP.MaxLength = 18;
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(132, 20);
            this.txtRemoteIP.TabIndex = 5;
            this.txtRemoteIP.TabStop = false;
            this.txtRemoteIP.Text = "192.168.1.115";
            this.txtRemoteIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlConnect
            // 
            this.pnlConnect.AutoSize = true;
            this.pnlConnect.Controls.Add(this.btnDisConnect);
            this.pnlConnect.Controls.Add(this.btnConnect);
            this.pnlConnect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConnect.Location = new System.Drawing.Point(3, 367);
            this.pnlConnect.Name = "pnlConnect";
            this.pnlConnect.Padding = new System.Windows.Forms.Padding(5);
            this.pnlConnect.Size = new System.Drawing.Size(142, 80);
            this.pnlConnect.TabIndex = 13;
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDisConnect.Enabled = false;
            this.btnDisConnect.Location = new System.Drawing.Point(5, 40);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(132, 35);
            this.btnDisConnect.TabIndex = 8;
            this.btnDisConnect.TabStop = false;
            this.btnDisConnect.Text = "DisConnect";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConnect.Location = new System.Drawing.Point(5, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(132, 35);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.TabStop = false;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Configuracoes";
            this.Text = "Configuracoes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbCommType.ResumeLayout(false);
            this.grbPortName.ResumeLayout(false);
            this.grbRemotePort.ResumeLayout(false);
            this.grbRemotePort.PerformLayout();
            this.grbBaudRate.ResumeLayout(false);
            this.grbRemoteIP.ResumeLayout(false);
            this.grbRemoteIP.PerformLayout();
            this.pnlConnect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbCommType;
        private System.Windows.Forms.ComboBox cmbCommType;
        private System.Windows.Forms.Panel pnlConnect;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grbRemotePort;
        private System.Windows.Forms.TextBox txtRemotePort;
        private System.Windows.Forms.GroupBox grbBaudRate;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.GroupBox grbRemoteIP;
        private System.Windows.Forms.TextBox txtRemoteIP;
        private System.Windows.Forms.GroupBox grbPortName;
        private System.Windows.Forms.ComboBox cmbPortName;
    }
}