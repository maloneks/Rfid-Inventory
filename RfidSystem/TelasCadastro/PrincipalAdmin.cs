using RfidSystem.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RfidSystem
{
    public partial class PrincipalAdmin : Form
    {
        //@WC 
        //Atribuição de data e hora no Menu Principal Admin usando o Timer
        DateTime data;

        public Form Me { get; private set; }

        //
        public PrincipalAdmin()
        {
            InitializeComponent();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           

            
        }
        private void PrincipalAdmin_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //@WC 
            //Atribuição de data e hora no Menu Principal Admin usando o Timer
            data = DateTime.Now;
            lb_data.Text = "Data: " + data.ToShortDateString();
            lb_hora.Text = "Hora: " + data.ToLongTimeString();

            //
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chamando a tela cadastro de funcionarios por container
            CadastroFuncionarios cadastrofuncionario = new CadastroFuncionarios();
            cadastrofuncionario.MdiParent = this;
            cadastrofuncionario.Show();
        }

        

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Display a message box asking users if they
            // want to exit the application.
            if (MessageBox.Show("Você deseja sair?", "My Application",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
           

        }

        private void btncadastrar01_Click(object sender, EventArgs e)
        {
            CadastrosMenu cadastromenu = new CadastrosMenu();
            cadastromenu.MdiParent = this;
            cadastromenu.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void btnsair_Click_1(object sender, EventArgs e)
        {
            // Display a message box asking users if they
            // want to exit the application.
            if (MessageBox.Show("Você deseja sair?", "My Application",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                  == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
