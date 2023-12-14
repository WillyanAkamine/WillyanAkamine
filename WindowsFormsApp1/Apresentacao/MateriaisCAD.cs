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

namespace WindowsFormsApp1.Apresentacao
{
    public partial class MateriaisCAD : Form
    {
        private const string InsertQuery = @"INSERT INTO Materiais (Nome, Quantidade, UnidadeMedida, PrecoUnitario, Data)
                                             VALUES (@Nome, @Quantidade, @UnidadeMedida, @PrecoUnitario, @Data)";
        public MateriaisCAD()
        {

            InitializeComponent();
        }

        private void lbnome_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbnome.Clear();
            txbquant.Clear();
            txbmedida.Clear();
            txbpreco.Clear();
        }

        private void MateriaisCAD_Load(object sender, EventArgs e)
        {

        }

        private void btncolocar_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            if (string.IsNullOrEmpty(txbnome.Text) || string.IsNullOrEmpty(txbquant.Text) || string.IsNullOrEmpty(txbmedida.Text) || string.IsNullOrEmpty(txbpreco.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios: Nome, Quantidade, Unidade de Medida e Preço", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(
                    "Nome: " + txbnome.Text +
                    "Quantidade: " + txbquant.Text +
                    "Unidade de Medida: " + txbmedida.Text +
                    "Preço: " + txbpreco.Text,
                    "CADASTRO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                // Materiais materiaisForm = new Materiais();
                // this.Hide();

                Connection connection = new Connection();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = InsertQuery;

                sqlCommand.Parameters.AddWithValue("@Nome", txbnome.Text);
                sqlCommand.Parameters.AddWithValue("@Quantidade", int.Parse(txbquant.Text));
                sqlCommand.Parameters.AddWithValue("@UnidadeMedida", txbmedida.Text);
                sqlCommand.Parameters.AddWithValue("@PrecoUnitario", decimal.Parse(txbpreco.Text));
                sqlCommand.Parameters.AddWithValue("@Data", dateTime);
                try
                {
                    // Insere o material
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    throw new Exception("Erro: Problemas ao inserir material no banco.\n" + err.Message);
                }
                finally
                {
                    connection.CloseConnection();
                }

                MessageBox.Show(
                    "Material Cadastrado com Sucesso",
                    "CADASTRO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                this.Close();
            }
        }
    }
}
