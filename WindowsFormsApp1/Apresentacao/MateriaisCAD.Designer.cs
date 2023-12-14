namespace WindowsFormsApp1.Apresentacao
{
    partial class MateriaisCAD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriaisCAD));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btncolocar = new System.Windows.Forms.Button();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.txbpreco = new System.Windows.Forms.MaskedTextBox();
            this.lbPreco = new System.Windows.Forms.Label();
            this.txbmedida = new System.Windows.Forms.TextBox();
            this.lbMedida = new System.Windows.Forms.Label();
            this.txbquant = new System.Windows.Forms.TextBox();
            this.lbquant = new System.Windows.Forms.Label();
            this.lbmaterial = new System.Windows.Forms.Label();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Red;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(273, 307);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 43);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btncolocar
            // 
            this.btncolocar.BackColor = System.Drawing.Color.DimGray;
            this.btncolocar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btncolocar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncolocar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncolocar.Location = new System.Drawing.Point(9, 307);
            this.btncolocar.Name = "btncolocar";
            this.btncolocar.Size = new System.Drawing.Size(99, 43);
            this.btncolocar.TabIndex = 4;
            this.btncolocar.Text = "Cadastrar";
            this.btncolocar.UseVisualStyleBackColor = false;
            this.btncolocar.Click += new System.EventHandler(this.btncolocar_Click);
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCadastro.Controls.Add(this.txbpreco);
            this.pnlCadastro.Controls.Add(this.lbPreco);
            this.pnlCadastro.Controls.Add(this.txbmedida);
            this.pnlCadastro.Controls.Add(this.lbMedida);
            this.pnlCadastro.Controls.Add(this.txbquant);
            this.pnlCadastro.Controls.Add(this.lbquant);
            this.pnlCadastro.Controls.Add(this.lbmaterial);
            this.pnlCadastro.Controls.Add(this.txbnome);
            this.pnlCadastro.Controls.Add(this.pictureBox1);
            this.pnlCadastro.Location = new System.Drawing.Point(9, 50);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(348, 251);
            this.pnlCadastro.TabIndex = 3;
            // 
            // txbpreco
            // 
            this.txbpreco.Location = new System.Drawing.Point(112, 209);
            this.txbpreco.Mask = "000.00";
            this.txbpreco.Name = "txbpreco";
            this.txbpreco.Size = new System.Drawing.Size(103, 20);
            this.txbpreco.TabIndex = 7;
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(143, 190);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(37, 16);
            this.lbPreco.TabIndex = 6;
            this.lbPreco.Text = "Preco";
            // 
            // txbmedida
            // 
            this.txbmedida.Location = new System.Drawing.Point(68, 156);
            this.txbmedida.Name = "txbmedida";
            this.txbmedida.Size = new System.Drawing.Size(194, 20);
            this.txbmedida.TabIndex = 5;
            // 
            // lbMedida
            // 
            this.lbMedida.AutoSize = true;
            this.lbMedida.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedida.Location = new System.Drawing.Point(121, 137);
            this.lbMedida.Name = "lbMedida";
            this.lbMedida.Size = new System.Drawing.Size(94, 16);
            this.lbMedida.TabIndex = 4;
            this.lbMedida.Text = "Unidade Medida";
            // 
            // txbquant
            // 
            this.txbquant.Location = new System.Drawing.Point(68, 94);
            this.txbquant.Name = "txbquant";
            this.txbquant.Size = new System.Drawing.Size(194, 20);
            this.txbquant.TabIndex = 3;
            // 
            // lbquant
            // 
            this.lbquant.AutoSize = true;
            this.lbquant.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbquant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbquant.Location = new System.Drawing.Point(133, 75);
            this.lbquant.Name = "lbquant";
            this.lbquant.Size = new System.Drawing.Size(69, 16);
            this.lbquant.TabIndex = 2;
            this.lbquant.Text = "Quantidade";
            // 
            // lbmaterial
            // 
            this.lbmaterial.AutoSize = true;
            this.lbmaterial.BackColor = System.Drawing.Color.AliceBlue;
            this.lbmaterial.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmaterial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbmaterial.Location = new System.Drawing.Point(121, 21);
            this.lbmaterial.Name = "lbmaterial";
            this.lbmaterial.Size = new System.Drawing.Size(85, 16);
            this.lbmaterial.TabIndex = 1;
            this.lbmaterial.Text = "Nome Material";
            this.lbmaterial.Click += new System.EventHandler(this.lbnome_Click);
            // 
            // txbnome
            // 
            this.txbnome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbnome.Location = new System.Drawing.Point(68, 40);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(194, 20);
            this.txbnome.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // MateriaisCAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 364);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btncolocar);
            this.Controls.Add(this.pnlCadastro);
            this.Name = "MateriaisCAD";
            this.Text = "MateriaisCAD";
            this.Load += new System.EventHandler(this.MateriaisCAD_Load);
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btncolocar;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.MaskedTextBox txbpreco;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.TextBox txbmedida;
        private System.Windows.Forms.Label lbMedida;
        private System.Windows.Forms.TextBox txbquant;
        private System.Windows.Forms.Label lbquant;
        private System.Windows.Forms.Label lbmaterial;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}