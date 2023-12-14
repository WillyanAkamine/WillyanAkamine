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

namespace WindowsFormsApp1
{
    public partial class Cadastro : Form
    {
        private const string V = @"INSERT INTO User013 VALUES 
            (@Nome, @Job, @Email, @CPF, @Gender, @Senha)";

        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlCadastro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbgener_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btninserir(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbnome.Text) || string.IsNullOrEmpty(txbemail.Text) || string.IsNullOrEmpty(tbsenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios: Nome, Email e Senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
            MessageBox.Show(
                "Nome: " + txbnome.Text +
                "Profissâo: " + txbjob.Text +
                "Email: " + txbemail.Text +
                "CPF: " + mtbCPF.Text +
                "Gênero: " + cmbgener.Text +
                "Senha: " + tbsenha.Text,
                "CADASTRO",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                 );
            Login form1 = new Login(); // Cria uma instância do Form1
            this.Hide(); // Oculta o Form2 (opcional)
            form1.Show(); // Exibe o Form1


            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = V
            ;

            sqlCommand.Parameters.AddWithValue("@Nome", txbnome.Text);
            sqlCommand.Parameters.AddWithValue("@Job", txbjob.Text);
            sqlCommand.Parameters.AddWithValue("@Email", txbemail.Text);
            sqlCommand.Parameters.AddWithValue("@CPF", mtbCPF.Text);
            sqlCommand.Parameters.AddWithValue("@Gender", cmbgener.Text);
            sqlCommand.Parameters.AddWithValue("@Senha", tbsenha.Text);


            try
            {
                //Insere o cliente
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir colaborador no banco.\n"
                    + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
            MessageBox.Show(
                "Cadastrado com Sucesso",
                "CADASTRO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbnome.Clear();
            txbjob.Clear();
            txbemail.Clear();
            mtbCPF.Clear();
            cmbgener.ResetText();
            tbsenha.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbemail_Click(object sender, EventArgs e)
        {

        }

        private void lbgener_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txbemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbnome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

