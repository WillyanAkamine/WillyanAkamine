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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
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
            MessageBox.Show(
                "Nome: " + txbnome.Text +
                "Profissâo: " + txbjob.Text +
                "Email: " + txbemail.Text +
                "CPF: " + mtbCPF.Text +
                "Gênero: " + cmbgener.Text,
                "CADASTRO",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information
                 );


            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO User013 VALUES 
            (@name, @job, @email, @cpf, @gener)"
            ;

            sqlCommand.Parameters.AddWithValue("@name", txbnome.Text);
            sqlCommand.Parameters.AddWithValue("@job", txbjob.Text);
            sqlCommand.Parameters.AddWithValue("@email", lbemail.Text);
            sqlCommand.Parameters.AddWithValue("@cpf", mtbCPF.Text);
            sqlCommand.Parameters.AddWithValue("@gener", cmbgener.Text);

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

        private void button2_Click(object sender, EventArgs e)
        {
            txbnome.Clear();
            txbjob.Clear();
            txbemail.Clear();
            mtbCPF.Clear();
            cmbgener.ResetText();
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
    }
}

