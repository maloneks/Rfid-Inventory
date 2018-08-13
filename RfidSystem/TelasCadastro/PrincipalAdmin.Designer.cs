namespace RfidSystem
{
    partial class PrincipalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.devolutivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_data = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnsobre = new System.Windows.Forms.Button();
            this.btnimportar = new System.Windows.Forms.Button();
            this.btnrelatorios = new System.Windows.Forms.Button();
            this.btnconfiguracao = new System.Windows.Forms.Button();
            this.btnconsultar01 = new System.Windows.Forms.Button();
            this.btncadastrar01 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem,
            this.btnFuncionarios,
            this.devolutivoToolStripMenuItem,
            this.localidadeToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastrar";
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.livrosToolStripMenuItem.Text = "Novo Inventário";
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(159, 22);
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // devolutivoToolStripMenuItem
            // 
            this.devolutivoToolStripMenuItem.Name = "devolutivoToolStripMenuItem";
            this.devolutivoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.devolutivoToolStripMenuItem.Text = "Equipamentos";
            // 
            // localidadeToolStripMenuItem
            // 
            this.localidadeToolStripMenuItem.Name = "localidadeToolStripMenuItem";
            this.localidadeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.localidadeToolStripMenuItem.Text = "Localidade";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem1.Text = "Consultar";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem2.Text = "Inventários";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem3.Text = "Funcionários";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem4.Text = "Equipamentos";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem5.Text = "Localidade";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LabelData,
            this.lb_data,
            this.lb_hora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(816, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(127, 17);
            this.toolStripStatusLabel1.Text = "Bem-Vindo ao Sistema";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // LabelData
            // 
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(0, 17);
            this.LabelData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_data
            // 
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(0, 17);
            // 
            // lb_hora
            // 
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(0, 17);
            this.lb_hora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 72);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.btnsair);
            this.panel1.Controls.Add(this.btnsobre);
            this.panel1.Controls.Add(this.btnimportar);
            this.panel1.Controls.Add(this.btnrelatorios);
            this.panel1.Controls.Add(this.btnconfiguracao);
            this.panel1.Controls.Add(this.btnconsultar01);
            this.panel1.Controls.Add(this.btncadastrar01);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 359);
            this.panel1.TabIndex = 4;
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.Maroon;
            this.btnsair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsair.FlatAppearance.BorderSize = 0;
            this.btnsair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.ForeColor = System.Drawing.Color.White;
            this.btnsair.Location = new System.Drawing.Point(0, 301);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(187, 43);
            this.btnsair.TabIndex = 13;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click_1);
            // 
            // btnsobre
            // 
            this.btnsobre.BackColor = System.Drawing.Color.Maroon;
            this.btnsobre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsobre.FlatAppearance.BorderSize = 0;
            this.btnsobre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnsobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsobre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsobre.ForeColor = System.Drawing.Color.White;
            this.btnsobre.Location = new System.Drawing.Point(0, 258);
            this.btnsobre.Name = "btnsobre";
            this.btnsobre.Size = new System.Drawing.Size(187, 43);
            this.btnsobre.TabIndex = 12;
            this.btnsobre.Text = "Sobre";
            this.btnsobre.UseVisualStyleBackColor = false;
            this.btnsobre.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnimportar
            // 
            this.btnimportar.BackColor = System.Drawing.Color.Maroon;
            this.btnimportar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnimportar.FlatAppearance.BorderSize = 0;
            this.btnimportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnimportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnimportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimportar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimportar.ForeColor = System.Drawing.Color.White;
            this.btnimportar.Location = new System.Drawing.Point(0, 215);
            this.btnimportar.Name = "btnimportar";
            this.btnimportar.Size = new System.Drawing.Size(187, 43);
            this.btnimportar.TabIndex = 11;
            this.btnimportar.Text = "Importar/Exportar";
            this.btnimportar.UseVisualStyleBackColor = false;
            // 
            // btnrelatorios
            // 
            this.btnrelatorios.BackColor = System.Drawing.Color.Maroon;
            this.btnrelatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnrelatorios.FlatAppearance.BorderSize = 0;
            this.btnrelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnrelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnrelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrelatorios.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrelatorios.ForeColor = System.Drawing.Color.White;
            this.btnrelatorios.Location = new System.Drawing.Point(0, 172);
            this.btnrelatorios.Name = "btnrelatorios";
            this.btnrelatorios.Size = new System.Drawing.Size(187, 43);
            this.btnrelatorios.TabIndex = 10;
            this.btnrelatorios.Text = "Relatórios";
            this.btnrelatorios.UseVisualStyleBackColor = false;
            this.btnrelatorios.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnconfiguracao
            // 
            this.btnconfiguracao.BackColor = System.Drawing.Color.Maroon;
            this.btnconfiguracao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnconfiguracao.FlatAppearance.BorderSize = 0;
            this.btnconfiguracao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnconfiguracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnconfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfiguracao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfiguracao.ForeColor = System.Drawing.Color.White;
            this.btnconfiguracao.Location = new System.Drawing.Point(0, 129);
            this.btnconfiguracao.Name = "btnconfiguracao";
            this.btnconfiguracao.Size = new System.Drawing.Size(187, 43);
            this.btnconfiguracao.TabIndex = 9;
            this.btnconfiguracao.Text = "Configurações";
            this.btnconfiguracao.UseVisualStyleBackColor = false;
            // 
            // btnconsultar01
            // 
            this.btnconsultar01.BackColor = System.Drawing.Color.Maroon;
            this.btnconsultar01.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnconsultar01.FlatAppearance.BorderSize = 0;
            this.btnconsultar01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnconsultar01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnconsultar01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultar01.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultar01.ForeColor = System.Drawing.Color.White;
            this.btnconsultar01.Location = new System.Drawing.Point(0, 86);
            this.btnconsultar01.Name = "btnconsultar01";
            this.btnconsultar01.Size = new System.Drawing.Size(187, 43);
            this.btnconsultar01.TabIndex = 8;
            this.btnconsultar01.Text = "Consultar";
            this.btnconsultar01.UseVisualStyleBackColor = false;
            // 
            // btncadastrar01
            // 
            this.btncadastrar01.BackColor = System.Drawing.Color.Maroon;
            this.btncadastrar01.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncadastrar01.FlatAppearance.BorderSize = 0;
            this.btncadastrar01.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncadastrar01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncadastrar01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncadastrar01.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar01.ForeColor = System.Drawing.Color.White;
            this.btncadastrar01.Location = new System.Drawing.Point(0, 43);
            this.btncadastrar01.Name = "btncadastrar01";
            this.btncadastrar01.Size = new System.Drawing.Size(187, 43);
            this.btncadastrar01.TabIndex = 7;
            this.btncadastrar01.Text = "Cadastrar";
            this.btncadastrar01.UseVisualStyleBackColor = false;
            this.btncadastrar01.Click += new System.EventHandler(this.btncadastrar01_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Navegação";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "PrincipalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rfid System Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrincipalAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem devolutivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LabelData;
        private System.Windows.Forms.ToolStripStatusLabel lb_data;
        private System.Windows.Forms.ToolStripStatusLabel lb_hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnconsultar01;
        private System.Windows.Forms.Button btncadastrar01;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem localidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Button btnrelatorios;
        private System.Windows.Forms.Button btnconfiguracao;
        private System.Windows.Forms.Button btnsobre;
        private System.Windows.Forms.Button btnimportar;
        private System.Windows.Forms.Button btnsair;
    }
}