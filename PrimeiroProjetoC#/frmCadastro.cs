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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text;

            if (nome == "" || email == "" || senha == "")
            {
                MessageBox.Show(
                    "Preencha todos os campos.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Form1.NomeCadastro = nome;
            Form1.EmailCadastrado = email.ToLower();
            Form1.SenhaCadastrada = senha;

            MessageBox.Show(
                    "Cadastro realizado!",
                    "Suceeso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
