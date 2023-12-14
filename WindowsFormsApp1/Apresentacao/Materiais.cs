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
    public partial class Materiais : Form
    {
        public Materiais()
        {
            InitializeComponent();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            try
            {
                // Consulta SQL para selecionar todos os registros da tabela
                string consultaSQL = "SELECT * FROM Materiais";
                string DataBase = "BANCOWILL";
                using (SqlConnection conexao = new SqlConnection(@"Data Source=" + Environment.MachineName +
                @"\SQLEXPRESS;Initial Catalog=" + DataBase + ";Integrated Security=true"))
                {
                    conexao.Open();
                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conexao))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            // Vincule os dados do DataTable ao DataGridView
                            BDSQL.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os registros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                string DataBase = "BANCOWILL";
                using (SqlConnection conexao = new SqlConnection(@"Data Source=" + Environment.MachineName +
                @"\SQLEXPRESS;Initial Catalog=" + DataBase + ";Integrated Security=true"))
                {
                    conexao.Open();

                    // Consulta SQL para selecionar todos os registros da tabela
                    string consultaSQL = "SELECT * FROM Materiais";

                    using (SqlCommand cmd = new SqlCommand(consultaSQL, conexao))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            // Vincule os dados do DataTable ao DataGridView   
                            BDSQL.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os registros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string DataBase = "BANCOWILL";
                using (SqlConnection conexao = new SqlConnection(@"Data Source=" + Environment.MachineName +
                @"\SQLEXPRESS;Initial Catalog=" + DataBase + ";Integrated Security=true"))
                {
                    conexao.Open();

                    foreach (DataGridViewRow linha in BDSQL.Rows)
                    {
                        if (!linha.IsNewRow) // Evite a última linha em branco, se houver
                        {
                            int id = (int)linha.Cells["ID"].Value; // Suponha que "ID" é a coluna que identifica exclusivamente o registro
                            string novoValor = linha.Cells["Nome"].Value.ToString(); // Substitua "Nome" pelo nome da coluna que deseja atualizar

                            // Crie um comando SQL UPDATE para atualizar o registro
                            string consultaSQL = "UPDATE Materiais SET Nome = @NovoValor WHERE ID = @ID";
                            using (SqlCommand cmd = new SqlCommand(consultaSQL, conexao))
                            {
                                cmd.Parameters.AddWithValue("@NovoValor", novoValor);
                                cmd.Parameters.AddWithValue("@ID", id);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Alterações salvas com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar as alterações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (BDSQL.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("Tem certeza de que deseja excluir o registro selecionado?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    int id = (int)BDSQL.SelectedRows[0].Cells["ID"].Value; // Suponha que "ID" é a coluna que identifica exclusivamente o registro

                    try
                    {
                        string DataBase = "BANCOWILL";
                        using (SqlConnection conexao = new SqlConnection(@"Data Source=" + Environment.MachineName +
                        @"\SQLEXPRESS;Initial Catalog=" + DataBase + ";Integrated Security=true"))
                        {
                            conexao.Open();

                            // Crie um comando SQL DELETE para excluir o registro no banco de dados
                            string consultaSQL = "DELETE FROM Materiais WHERE ID = @ID";
                            using (SqlCommand cmd = new SqlCommand(consultaSQL, conexao))
                            {
                                cmd.Parameters.AddWithValue("@ID", id);
                                cmd.ExecuteNonQuery();
                            }

                            // Atualize o DataGridView após a exclusão
                            BDSQL.Rows.RemoveAt(BDSQL.SelectedRows[0].Index);

                            MessageBox.Show("Registro excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txbpesq_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txbpesq.Text; // Obtém o termo de pesquisa do TextBox

            // Consulta SQL para pesquisar registros com base no nome
            string consultaSQL = "SELECT * FROM Materiais WHERE Nome LIKE @termo";

            string DataBase = "BANCOWILL";
            using (SqlConnection conexao = new SqlConnection(@"Data Source=" + Environment.MachineName +
                @"\SQLEXPRESS;Initial Catalog=" + DataBase + ";Integrated Security=true"))
            {
                conexao.Open();
                using (SqlCommand cmd = new SqlCommand(consultaSQL, conexao))
                {
                    cmd.Parameters.AddWithValue("@termo", "%" + termoPesquisa + "%"); // Usamos '%' para permitir correspondências parciais

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Vincule os dados do DataTable ao DataGridView ou outra exibição
                        BDSQL.DataSource = dt;
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            MateriaisCAD materiaisCADForm = new MateriaisCAD();
            materiaisCADForm.Show();
        }

        private void BDSQL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Certifique-se de ajustar a consulta SQL conforme necessário para a estrutura do seu banco de dados.
            string consultaSQL = "SELECT * FROM Materiais";
            string DataBase = "BANCOWILL";
            using (SqlConnection conexao = new SqlConnection(@"Data Source=" + Environment.MachineName +
            @"\SQLEXPRESS;Initial Catalog=" + DataBase + ";Integrated Security=true"))
            {
                conexao.Open();
                using (SqlCommand cmd = new SqlCommand(consultaSQL, conexao))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Vincule os dados do DataTable ao DataGridView
                        BDSQL.DataSource = dt;
                    }
                }
            }
        }
    }
}
