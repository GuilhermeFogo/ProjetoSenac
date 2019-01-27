namespace LoguinChocolate
{
    partial class relatorio_produtos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_pesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.caixa_codproduto = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.but_sair = new System.Windows.Forms.Button();
            this.reportVendasDia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportVendasSemana = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportVendasMes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.but_relatorio_mes = new System.Windows.Forms.Button();
            this.but_relatorio_semana = new System.Windows.Forms.Button();
            this.but_relatorio_dia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.reportVendasDia);
            this.groupBox1.Controls.Add(this.reportVendasSemana);
            this.groupBox1.Controls.Add(this.reportVendasMes);
            this.groupBox1.Controls.Add(this.but_relatorio_mes);
            this.groupBox1.Controls.Add(this.but_relatorio_semana);
            this.groupBox1.Controls.Add(this.but_relatorio_dia);
            this.groupBox1.Controls.Add(this.but_pesquisar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.caixa_codproduto);
            this.groupBox1.Controls.Add(this.lb_nome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 456);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatorio";
            // 
            // but_pesquisar
            // 
            this.but_pesquisar.Location = new System.Drawing.Point(257, 22);
            this.but_pesquisar.Name = "but_pesquisar";
            this.but_pesquisar.Size = new System.Drawing.Size(92, 35);
            this.but_pesquisar.TabIndex = 36;
            this.but_pesquisar.Text = "Pesquisar";
            this.but_pesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(468, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 320);
            this.dataGridView1.TabIndex = 35;
            // 
            // caixa_codproduto
            // 
            this.caixa_codproduto.Location = new System.Drawing.Point(122, 38);
            this.caixa_codproduto.Name = "caixa_codproduto";
            this.caixa_codproduto.Size = new System.Drawing.Size(100, 23);
            this.caixa_codproduto.TabIndex = 25;
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(25, 40);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(91, 17);
            this.lb_nome.TabIndex = 20;
            this.lb_nome.Text = "Cod. Produto";
            // 
            // but_sair
            // 
            this.but_sair.Location = new System.Drawing.Point(918, 474);
            this.but_sair.Name = "but_sair";
            this.but_sair.Size = new System.Drawing.Size(91, 30);
            this.but_sair.TabIndex = 37;
            this.but_sair.Text = "Sair";
            this.but_sair.UseVisualStyleBackColor = true;
            // 
            // reportVendasDia
            // 
            this.reportVendasDia.Location = new System.Drawing.Point(28, 114);
            this.reportVendasDia.Name = "reportVendasDia";
            this.reportVendasDia.Size = new System.Drawing.Size(387, 95);
            this.reportVendasDia.TabIndex = 59;
            // 
            // reportVendasSemana
            // 
            this.reportVendasSemana.DocumentMapWidth = 52;
            this.reportVendasSemana.Location = new System.Drawing.Point(28, 227);
            this.reportVendasSemana.Name = "reportVendasSemana";
            this.reportVendasSemana.Size = new System.Drawing.Size(387, 94);
            this.reportVendasSemana.TabIndex = 58;
            // 
            // reportVendasMes
            // 
            this.reportVendasMes.Location = new System.Drawing.Point(28, 339);
            this.reportVendasMes.Name = "reportVendasMes";
            this.reportVendasMes.Size = new System.Drawing.Size(396, 92);
            this.reportVendasMes.TabIndex = 57;
            // 
            // but_relatorio_mes
            // 
            this.but_relatorio_mes.Location = new System.Drawing.Point(262, 70);
            this.but_relatorio_mes.Name = "but_relatorio_mes";
            this.but_relatorio_mes.Size = new System.Drawing.Size(75, 23);
            this.but_relatorio_mes.TabIndex = 56;
            this.but_relatorio_mes.Text = "Mês";
            this.but_relatorio_mes.UseVisualStyleBackColor = true;
            // 
            // but_relatorio_semana
            // 
            this.but_relatorio_semana.Location = new System.Drawing.Point(145, 70);
            this.but_relatorio_semana.Name = "but_relatorio_semana";
            this.but_relatorio_semana.Size = new System.Drawing.Size(75, 23);
            this.but_relatorio_semana.TabIndex = 55;
            this.but_relatorio_semana.Text = "Semana";
            this.but_relatorio_semana.UseVisualStyleBackColor = true;
            // 
            // but_relatorio_dia
            // 
            this.but_relatorio_dia.Location = new System.Drawing.Point(28, 70);
            this.but_relatorio_dia.Name = "but_relatorio_dia";
            this.but_relatorio_dia.Size = new System.Drawing.Size(75, 23);
            this.but_relatorio_dia.TabIndex = 54;
            this.but_relatorio_dia.Text = "Dia";
            this.but_relatorio_dia.UseVisualStyleBackColor = true;
            this.but_relatorio_dia.Click += new System.EventHandler(this.but_relatorio_dia_Click);
            // 
            // relatorio_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1037, 504);
            this.Controls.Add(this.but_sair);
            this.Controls.Add(this.groupBox1);
            this.Name = "relatorio_produtos";
            this.Text = "relatorio_produtos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_sair;
        private System.Windows.Forms.Button but_pesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox caixa_codproduto;
        private System.Windows.Forms.Label lb_nome;
        private Microsoft.Reporting.WinForms.ReportViewer reportVendasDia;
        private Microsoft.Reporting.WinForms.ReportViewer reportVendasSemana;
        private Microsoft.Reporting.WinForms.ReportViewer reportVendasMes;
        private System.Windows.Forms.Button but_relatorio_mes;
        private System.Windows.Forms.Button but_relatorio_semana;
        private System.Windows.Forms.Button but_relatorio_dia;
    }
}