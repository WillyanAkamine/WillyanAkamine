namespace WindowsFormsApp1
{
    partial class Cadastro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbsenha = new System.Windows.Forms.TextBox();
            this.lbgener = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbjob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbemail = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.cmbgener = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tltnome = new System.Windows.Forms.ToolTip(this.components);
            this.btncolocar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pnlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCadastro.Controls.Add(this.label3);
            this.pnlCadastro.Controls.Add(this.tbsenha);
            this.pnlCadastro.Controls.Add(this.lbgener);
            this.pnlCadastro.Controls.Add(this.mtbCPF);
            this.pnlCadastro.Controls.Add(this.label1);
            this.pnlCadastro.Controls.Add(this.txbjob);
            this.pnlCadastro.Controls.Add(this.label2);
            this.pnlCadastro.Controls.Add(this.txbemail);
            this.pnlCadastro.Controls.Add(this.lbemail);
            this.pnlCadastro.Controls.Add(this.lbnome);
            this.pnlCadastro.Controls.Add(this.txbnome);
            this.pnlCadastro.Controls.Add(this.cmbgener);
            this.pnlCadastro.Controls.Add(this.pictureBox1);
            this.pnlCadastro.Location = new System.Drawing.Point(21, 13);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(348, 251);
            this.pnlCadastro.TabIndex = 0;
            this.pnlCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCadastro_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Senha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbsenha
            // 
            this.tbsenha.Location = new System.Drawing.Point(87, 228);
            this.tbsenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbsenha.Name = "tbsenha";
            this.tbsenha.PasswordChar = '*';
            this.tbsenha.Size = new System.Drawing.Size(140, 20);
            this.tbsenha.TabIndex = 11;
            this.tbsenha.TextChanged += new System.EventHandler(this.tbsenha_TextChanged);
            // 
            // lbgener
            // 
            this.lbgener.AutoSize = true;
            this.lbgener.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgener.Location = new System.Drawing.Point(133, 164);
            this.lbgener.Name = "lbgener";
            this.lbgener.Size = new System.Drawing.Size(45, 16);
            this.lbgener.TabIndex = 9;
            this.lbgener.Text = "Gênero";
            this.lbgener.Click += new System.EventHandler(this.lbgener_Click);
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(112, 144);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(103, 20);
            this.mtbCPF.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "CPF";
            // 
            // txbjob
            // 
            this.txbjob.Location = new System.Drawing.Point(68, 105);
            this.txbjob.Name = "txbjob";
            this.txbjob.Size = new System.Drawing.Size(194, 20);
            this.txbjob.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Profissão";
            // 
            // txbemail
            // 
            this.txbemail.Location = new System.Drawing.Point(68, 67);
            this.txbemail.Name = "txbemail";
            this.txbemail.Size = new System.Drawing.Size(194, 20);
            this.txbemail.TabIndex = 3;
            this.txbemail.TextChanged += new System.EventHandler(this.txbemail_TextChanged);
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbemail.Location = new System.Drawing.Point(144, 49);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(35, 16);
            this.lbemail.TabIndex = 2;
            this.lbemail.Text = "Email";
            this.lbemail.Click += new System.EventHandler(this.lbemail_Click);
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.BackColor = System.Drawing.Color.AliceBlue;
            this.lbnome.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbnome.Location = new System.Drawing.Point(117, 10);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(92, 16);
            this.lbnome.TabIndex = 1;
            this.lbnome.Text = "Nome completo";
            this.lbnome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbnome
            // 
            this.txbnome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbnome.Location = new System.Drawing.Point(68, 29);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(194, 20);
            this.txbnome.TabIndex = 0;
            this.tltnome.SetToolTip(this.txbnome, "Insira seu nome completo");
            this.txbnome.TextChanged += new System.EventHandler(this.txbnome_TextChanged);
            // 
            // cmbgener
            // 
            this.cmbgener.FormattingEnabled = true;
            this.cmbgener.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro",
            "Prefiro não informar"});
            this.cmbgener.Location = new System.Drawing.Point(87, 182);
            this.cmbgener.Name = "cmbgener";
            this.cmbgener.Size = new System.Drawing.Size(140, 21);
            this.cmbgener.TabIndex = 8;
            this.cmbgener.SelectedIndexChanged += new System.EventHandler(this.cmbgener_SelectedIndexChanged);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btncolocar
            // 
            this.btncolocar.BackColor = System.Drawing.Color.DimGray;
            this.btncolocar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btncolocar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncolocar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncolocar.Location = new System.Drawing.Point(21, 321);
            this.btncolocar.Name = "btncolocar";
            this.btncolocar.Size = new System.Drawing.Size(99, 43);
            this.btncolocar.TabIndex = 1;
            this.btncolocar.Text = "Cadastrar";
            this.btncolocar.UseVisualStyleBackColor = false;
            this.btncolocar.Click += new System.EventHandler(this.btninserir);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Red;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(285, 321);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 43);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 382);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btncolocar);
            this.Controls.Add(this.pnlCadastro);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.TextBox txbjob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbemail;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip tltnome;
        private System.Windows.Forms.Label lbgener;
        private System.Windows.Forms.ComboBox cmbgener;
        private System.Windows.Forms.Button btncolocar;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbsenha;
        private System.Windows.Forms.Label label3;
    }
}