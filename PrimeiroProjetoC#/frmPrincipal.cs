using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjetoC_
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

        }

        public void DefinirBoasVindas(string nome)
        {
            lblBoasVindas.Text = "Bem-vindo, " + nome + "!";

        }

        private void lblBoasVindas_Click(object sender, EventArgs e)
        {

        }
    }
}
