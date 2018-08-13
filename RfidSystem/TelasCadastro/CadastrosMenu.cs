using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RfidSystem.Telas
{
    public partial class CadastrosMenu : Form
    {
        public CadastrosMenu()
        {
            InitializeComponent();
        }

        private void CadastrosMenu_Load(object sender, EventArgs e)
        {
           

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {


            CadastrosMenu cadastrosMenu = new CadastrosMenu();
            
            this.Close();
        }

        private void btnfecharcadastrar_Click(object sender, EventArgs e)
        {
            CadastrosMenu cadastrosMenu = new CadastrosMenu();
            this.Close();
        }

        private void btnfuncionarios_Click(object sender, EventArgs e)
        {
            CadastroFuncionarios cadastroFuncionarios = new CadastroFuncionarios();
            cadastroFuncionarios.ShowDialog();


        }
    }
}
