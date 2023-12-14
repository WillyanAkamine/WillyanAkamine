namespace WindowsFormsApp1.Apresentacao
{
    partial class CRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mATERIAISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dASHBOARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dADOSDAOBRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRQUIVOSOBRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROJETOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dOCUMENTOCLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BDSQL = new System.Windows.Forms.DataGridView();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.tbnpesq = new System.Windows.Forms.Button();
            this.txbpesq = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sAIRToolStripMenuItem,
            this.mATERIAISToolStripMenuItem,
            this.dASHBOARDToolStripMenuItem,
            this.dADOSDAOBRAToolStripMenuItem,
            this.aRQUIVOSOBRAToolStripMenuItem,
            this.pROJETOSToolStripMenuItem,
            this.dOCUMENTOCLIENTESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1680, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // mATERIAISToolStripMenuItem
            // 
            this.mATERIAISToolStripMenuItem.Name = "mATERIAISToolStripMenuItem";
            this.mATERIAISToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.mATERIAISToolStripMenuItem.Text = "MATERIAIS";
            this.mATERIAISToolStripMenuItem.Click += new System.EventHandler(this.mATERIAISToolStripMenuItem_Click);
            // 
            // dASHBOARDToolStripMenuItem
            // 
            this.dASHBOARDToolStripMenuItem.Name = "dASHBOARDToolStripMenuItem";
            this.dASHBOARDToolStripMenuItem.Size = new System.Drawing.Size(136, 29);
            this.dASHBOARDToolStripMenuItem.Text = "DASHBOARD";
            this.dASHBOARDToolStripMenuItem.Click += new System.EventHandler(this.dASHBOARDToolStripMenuItem_Click);
            // 
            // dADOSDAOBRAToolStripMenuItem
            // 
            this.dADOSDAOBRAToolStripMenuItem.Name = "dADOSDAOBRAToolStripMenuItem";
            this.dADOSDAOBRAToolStripMenuItem.Size = new System.Drawing.Size(172, 29);
            this.dADOSDAOBRAToolStripMenuItem.Text = "DADOS DA OBRA";
            // 
            // aRQUIVOSOBRAToolStripMenuItem
            // 
            this.aRQUIVOSOBRAToolStripMenuItem.Name = "aRQUIVOSOBRAToolStripMenuItem";
            this.aRQUIVOSOBRAToolStripMenuItem.Size = new System.Drawing.Size(169, 29);
            this.aRQUIVOSOBRAToolStripMenuItem.Text = "ARQUIVOS OBRA";
            // 
            // pROJETOSToolStripMenuItem
            // 
            this.pROJETOSToolStripMenuItem.Name = "pROJETOSToolStripMenuItem";
            this.pROJETOSToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.pROJETOSToolStripMenuItem.Text = "PROJETOS";
            // 
            // dOCUMENTOCLIENTESToolStripMenuItem
            // 
            this.dOCUMENTOCLIENTESToolStripMenuItem.Name = "dOCUMENTOCLIENTESToolStripMenuItem";
            this.dOCUMENTOCLIENTESToolStripMenuItem.Size = new System.Drawing.Size(217, 29);
            this.dOCUMENTOCLIENTESToolStripMenuItem.Text = "DOCUMENTO CLIENTES";
            // 
            // BDSQL
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BDSQL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BDSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BDSQL.Location = new System.Drawing.Point(18, 208);
            this.BDSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BDSQL.Name = "BDSQL";
            this.BDSQL.RowHeadersWidth = 62;
            this.BDSQL.Size = new System.Drawing.Size(1644, 405);
            this.BDSQL.TabIndex = 1;
            this.BDSQL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(54, 92);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(171, 45);
            this.btnCadastro.TabIndex = 7;
            this.btnCadastro.Text = "CADASTRAR";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLista
            // 
            this.btnLista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.Location = new System.Drawing.Point(278, 92);
            this.btnLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(158, 45);
            this.btnLista.TabIndex = 6;
            this.btnLista.Text = "LISTAR";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(488, 92);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(159, 45);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "EDITAR";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(690, 92);
            this.btndel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(158, 45);
            this.btndel.TabIndex = 8;
            this.btndel.Text = "EXCLUIR";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(18, 622);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(154, 49);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "SALVAR";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // tbnpesq
            // 
            this.tbnpesq.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnpesq.Location = new System.Drawing.Point(885, 91);
            this.tbnpesq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbnpesq.Name = "tbnpesq";
            this.tbnpesq.Size = new System.Drawing.Size(158, 45);
            this.tbnpesq.TabIndex = 11;
            this.tbnpesq.Text = "PESQUISAR";
            this.tbnpesq.UseVisualStyleBackColor = true;
            this.tbnpesq.Click += new System.EventHandler(this.txbpesq_Click);
            // 
            // txbpesq
            // 
            this.txbpesq.Location = new System.Drawing.Point(885, 145);
            this.txbpesq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbpesq.Name = "txbpesq";
            this.txbpesq.Size = new System.Drawing.Size(160, 26);
            this.txbpesq.TabIndex = 12;
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 689);
            this.Controls.Add(this.txbpesq);
            this.Controls.Add(this.tbnpesq);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.BDSQL);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CRUD";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.DataGridView BDSQL;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button tbnpesq;
        private System.Windows.Forms.TextBox txbpesq;
        private System.Windows.Forms.ToolStripMenuItem mATERIAISToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dASHBOARDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dADOSDAOBRAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRQUIVOSOBRAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROJETOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dOCUMENTOCLIENTESToolStripMenuItem;
    }
}