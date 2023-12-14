namespace WindowsFormsApp1.Apresentacao
{
    partial class Materiais
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txbpesq = new System.Windows.Forms.TextBox();
            this.tbnpesq = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.BDSQL = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BDSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // txbpesq
            // 
            this.txbpesq.Location = new System.Drawing.Point(430, 72);
            this.txbpesq.Name = "txbpesq";
            this.txbpesq.Size = new System.Drawing.Size(108, 20);
            this.txbpesq.TabIndex = 20;
            // 
            // tbnpesq
            // 
            this.tbnpesq.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnpesq.Location = new System.Drawing.Point(430, 37);
            this.tbnpesq.Name = "tbnpesq";
            this.tbnpesq.Size = new System.Drawing.Size(105, 29);
            this.tbnpesq.TabIndex = 19;
            this.tbnpesq.Text = "PESQUISAR";
            this.tbnpesq.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(-148, 382);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(103, 32);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "SALVAR";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(165, 38);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(106, 29);
            this.btnedit.TabIndex = 17;
            this.btnedit.Text = "EDITAR";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(300, 38);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(105, 29);
            this.btndel.TabIndex = 16;
            this.btndel.Text = "EXCLUIR";
            this.btndel.UseVisualStyleBackColor = true;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(-124, 38);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(114, 29);
            this.btnCadastro.TabIndex = 15;
            this.btnCadastro.Text = "CADASTRAR";
            this.btnCadastro.UseVisualStyleBackColor = true;
            // 
            // btnLista
            // 
            this.btnLista.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.Location = new System.Drawing.Point(25, 38);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(105, 29);
            this.btnLista.TabIndex = 14;
            this.btnLista.Text = "LISTAR";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // BDSQL
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BDSQL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BDSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BDSQL.Location = new System.Drawing.Point(25, 98);
            this.BDSQL.Name = "BDSQL";
            this.BDSQL.RowHeadersWidth = 62;
            this.BDSQL.Size = new System.Drawing.Size(1096, 263);
            this.BDSQL.TabIndex = 13;
            this.BDSQL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BDSQL_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(991, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 29);
            this.button2.TabIndex = 22;
            this.button2.Text = "CADASTRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Materiais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 436);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbpesq);
            this.Controls.Add(this.tbnpesq);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.BDSQL);
            this.Name = "Materiais";
            this.Text = "Materiais";
            ((System.ComponentModel.ISupportInitialize)(this.BDSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbpesq;
        private System.Windows.Forms.Button tbnpesq;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.DataGridView BDSQL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}