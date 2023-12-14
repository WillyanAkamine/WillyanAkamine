using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using WindowsFormsApp1.Apresentacao;
using WindowsFormsApp1.Conection;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public string Sconnection { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastro form1 = new Cadastro(); // Cria uma instância do Form1
            form1.Show(); // Exibe o Form1
            this.Hide(); // Oculta o Form2 (opcional)
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txbemail.Text, txbsenha.Text);
            if(controle.tem)
            {
                if (txbemail.Text == "Admin" && txbsenha.Text == "Admin")
                {
                    MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CRUD form3 = new CRUD(); // Cria uma instância do Form1
                    form3.Show(); // Exibe o Form1
                    this.Hide(); // Oculta o Form2 (opcional)
                }
                else 
                {
                    MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Telauser form4 = new Telauser(); // Cria uma instância do Form1
                    form4.Show(); // Exibe o Form1
                    this.Hide(); // Oculta o Form2 (opcional)
                }

            }
            else
            {
                MessageBox.Show("Verificar Email e Senha!!!", "ERRO!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
