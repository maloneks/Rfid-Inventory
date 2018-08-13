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
    }
}
