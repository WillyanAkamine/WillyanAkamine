using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Apresentacao
{
    public partial class DASHBOARD : Form
    {
        public DASHBOARD()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Geratxb_Click(object sender, EventArgs e)
        {
            if (seuCalendario.SelectionStart != null)
            {
                DateTime dataSelecionada = seuCalendario.SelectionStart;

                // Chame o método para gerar o relatório e criar o arquivo Excel com base na data selecionada
                GerarRelatorioEExcel(dataSelecionada);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma data no calendário.");
            }
        }

        private void GerarRelatorioEExcel(DateTime data)
        {
            try
            {
                Connection connection = new Connection();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = connection.ReturnConnection();
                string query = "SELECT Nome, Quantidade, PrecoUnitario FROM Materiais WHERE Data = @Data";
                sqlCommand.CommandText = query;

                sqlCommand.Parameters.AddWithValue("@Data", data);

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

                    // Criar um arquivo Excel usando EPPlus
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("RelatorioMateriais");

                        worksheet.Cells["A1"].Value = "Nome";
                        worksheet.Cells["B1"].Value = "Quantidade";
                        worksheet.Cells["C1"].Value = "Preço"; // Alterado para "Preço" para corresponder ao nome da coluna no banco de dados

                        int row = 2;

                        // Preencher o arquivo Excel com dados do banco de dados
                        while (reader.Read())
                        {
                            worksheet.Cells[$"A{row}"].Value = reader["Nome"].ToString();
                            worksheet.Cells[$"B{row}"].Value = reader["Quantidade"];
                            worksheet.Cells[$"C{row}"].Value = reader["PrecoUnitario"]; // Alterado para "PrecoUnitario"

                            row++;
                        }

                        // Combine o caminho da pasta "Downloads" com o nome do arquivo
                        string filePath = Path.Combine(downloadsPath, "RelatorioMateriais.xlsx");

                        // Salvar o arquivo Excel
                        package.SaveAs(new System.IO.FileInfo(filePath));

                        MessageBox.Show($"Relatório gerado com sucesso e salvo em {downloadsPath}\\RelatorioMateriais.xlsx");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }

        }
    }
}   

