namespace WindowsFormsApp1.Apresentacao
{
    partial class DASHBOARD
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
            this.seuCalendario = new System.Windows.Forms.MonthCalendar();
            this.relatoriolb = new System.Windows.Forms.Label();
            this.Geratxb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seuCalendario
            // 
            this.seuCalendario.Location = new System.Drawing.Point(39, 111);
            this.seuCalendario.Name = "seuCalendario";
            this.seuCalendario.TabIndex = 0;
            // 
            // relatoriolb
            // 
            this.relatoriolb.AutoSize = true;
            this.relatoriolb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatoriolb.Location = new System.Drawing.Point(127, 60);
            this.relatoriolb.Name = "relatoriolb";
            this.relatoriolb.Size = new System.Drawing.Size(143, 32);
            this.relatoriolb.TabIndex = 1;
            this.relatoriolb.Text = "Relatorios";
            this.relatoriolb.Click += new System.EventHandler(this.label1_Click);
            // 
            // Geratxb
            // 
            this.Geratxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Geratxb.Location = new System.Drawing.Point(144, 376);
            this.Geratxb.Name = "Geratxb";
            this.Geratxb.Size = new System.Drawing.Size(126, 52);
            this.Geratxb.TabIndex = 2;
            this.Geratxb.Text = "GERAR";
            this.Geratxb.UseVisualStyleBackColor = true;
            this.Geratxb.Click += new System.EventHandler(this.Geratxb_Click);
            // 
            // DASHBOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 446);
            this.Controls.Add(this.Geratxb);
            this.Controls.Add(this.relatoriolb);
            this.Controls.Add(this.seuCalendario);
            this.Name = "DASHBOARD";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar seuCalendario;
        private System.Windows.Forms.Label relatoriolb;
        private System.Windows.Forms.Button Geratxb;
    }
}