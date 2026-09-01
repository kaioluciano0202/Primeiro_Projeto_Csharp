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
    public partial class Form1 : Form
    {
        //Esse codigo cadastra um email no cadastro
        private const string EmailCadastrado = "kaio@teste.com";
        //Esse codigo cadastra uma senha no cadastro
        private const string SenhaCadastrada = "1234";

        public Form1()
        {
            InitializeComponent();
            CentralizarPainel();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CentralizarPainel()
        {
            //Mexe na parte esquerda do painel (o div 2 esta limitando nosso painel)
            pnlEntrar.Left = (this.ClientSize.Width - pnlEntrar.Width) / 2;
            //Mexe no topo do painel
            pnlEntrar.Top = (this.ClientSize.Height - pnlEntrar.Height) / 2;

            this.Resize += (s, e) => CentralizarPainel();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text;
        }
    }
}
