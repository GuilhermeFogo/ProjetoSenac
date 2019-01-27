namespace LoguinChocolate
{
    partial class relatorio_vendas
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_cod = new System.Windows.Forms.Label();
            this.caixa_codvenda = new System.Windows.Forms.TextBox();
            this.but_pesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_datainicio = new System.Windows.Forms.Label();
            this.lb_data_fim = new System.Windows.Forms.Label();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fim = new System.Windows.Forms.DateTimePicker();
            this.but_sair = new System.Windows.Forms.Button();
            this.but_relatorio_mes = new System.Windows.Forms.Button();
            this.but_relatorio_semana = new System.Windows.Forms.Button();
            this.but_relatorio_dia = new System.Windows.Forms.Button();
            this.reportVendasMes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportVendasSemana = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportVendasDia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 20;
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
            this.groupBox1.Controls.Add(this.lb_cod);
            this.groupBox1.Controls.Add(this.caixa_codvenda);
            this.groupBox1.Controls.Add(this.but_pesquisar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.lb_datainicio);
            this.groupBox1.Controls.Add(this.lb_data_fim);
            this.groupBox1.Controls.Add(this.dtp_inicio);
            this.groupBox1.Controls.Add(this.dtp_fim);
            this.groupBox1.Location = new System.Drawing.Point(22, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 462);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatorio";
            // 
            // lb_cod
            // 
            this.lb_cod.AutoSize = true;
            this.lb_cod.Location = new System.Drawing.Point(28, 22);
            this.lb_cod.Name = "lb_cod";
            this.lb_cod.Size = new System.Drawing.Size(74, 13);
            this.lb_cod.TabIndex = 43;
            this.lb_cod.Text = "Cod Vendas : ";
            // 
            // caixa_codvenda
            // 
            this.caixa_codvenda.Location = new System.Drawing.Point(114, 19);
            this.caixa_codvenda.Name = "caixa_codvenda";
            this.caixa_codvenda.Size = new System.Drawing.Size(94, 20);
            this.caixa_codvenda.TabIndex = 42;
            // 
            // but_pesquisar
            // 
            this.but_pesquisar.Location = new System.Drawing.Point(254, 10);
            this.but_pesquisar.Name = "but_pesquisar";
            this.but_pesquisar.Size = new System.Drawing.Size(98, 37);
            this.but_pesquisar.TabIndex = 41;
            this.but_pesquisar.Text = "Pesquisar";
            this.but_pesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(452, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(310, 395);
            this.dataGridView1.TabIndex = 39;
            // 
            // lb_datainicio
            // 
            this.lb_datainicio.AutoSize = true;
            this.lb_datainicio.Location = new System.Drawing.Point(28, 64);
            this.lb_datainicio.Name = "lb_datainicio";
            this.lb_datainicio.Size = new System.Drawing.Size(81, 13);
            this.lb_datainicio.TabIndex = 38;
            this.lb_datainicio.Text = "Data de inicio : ";
            // 
            // lb_data_fim
            // 
            this.lb_data_fim.AutoSize = true;
            this.lb_data_fim.Location = new System.Drawing.Point(232, 61);
            this.lb_data_fim.Name = "lb_data_fim";
            this.lb_data_fim.Size = new System.Drawing.Size(70, 13);
            this.lb_data_fim.TabIndex = 37;
            this.lb_data_fim.Text = "Data de Fim :";
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicio.Location = new System.Drawing.Point(115, 58);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(94, 20);
            this.dtp_inicio.TabIndex = 36;
            // 
            // dtp_fim
            // 
            this.dtp_fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fim.Location = new System.Drawing.Point(302, 58);
            this.dtp_fim.Name = "dtp_fim";
            this.dtp_fim.Size = new System.Drawing.Size(83, 20);
            this.dtp_fim.TabIndex = 35;
            // 
            // but_sair
            // 
            this.but_sair.Location = new System.Drawing.Point(745, 470);
            this.but_sair.Name = "but_sair";
            this.but_sair.Size = new System.Drawing.Size(81, 32);
            this.but_sair.TabIndex = 40;
            this.but_sair.Text = "Sair";
            this.but_sair.UseVisualStyleBackColor = true;
            // 
            // but_relatorio_mes
            // 
            this.but_relatorio_mes.Location = new System.Drawing.Point(265, 96);
            this.but_relatorio_mes.Name = "but_relatorio_mes";
            this.but_relatorio_mes.Size = new System.Drawing.Size(75, 23);
            this.but_relatorio_mes.TabIndex = 50;
            this.but_relatorio_mes.Text = "Mês";
            this.but_relatorio_mes.UseVisualStyleBackColor = true;
            this.but_relatorio_mes.Click += new System.EventHandler(this.but_relatorio_mes_Click);
            // 
            // but_relatorio_semana
            // 
            this.but_relatorio_semana.Location = new System.Drawing.Point(148, 96);
            this.but_relatorio_semana.Name = "but_relatorio_semana";
            this.but_relatorio_semana.Size = new System.Drawing.Size(75, 23);
            this.but_relatorio_semana.TabIndex = 49;
            this.but_relatorio_semana.Text = "Semana";
            this.but_relatorio_semana.UseVisualStyleBackColor = true;
            this.but_relatorio_semana.Click += new System.EventHandler(this.but_relatorio_semana_Click);
            // 
            // but_relatorio_dia
            // 
            this.but_relatorio_dia.Location = new System.Drawing.Point(31, 96);
            this.but_relatorio_dia.Name = "but_relatorio_dia";
            this.but_relatorio_dia.Size = new System.Drawing.Size(75, 23);
            this.but_relatorio_dia.TabIndex = 48;
            this.but_relatorio_dia.Text = "Dia";
            this.but_relatorio_dia.UseVisualStyleBackColor = true;
            this.but_relatorio_dia.Click += new System.EventHandler(this.but_relatorio_dia_Click);
            // 
            // reportVendasMes
            // 
            this.reportVendasMes.Location = new System.Drawing.Point(6, 364);
            this.reportVendasMes.Name = "reportVendasMes";
            this.reportVendasMes.Size = new System.Drawing.Size(396, 92);
            this.reportVendasMes.TabIndex = 51;
            // 
            // reportVendasSemana
            // 
            this.reportVendasSemana.DocumentMapWidth = 52;
            this.reportVendasSemana.Location = new System.Drawing.Point(6, 254);
            this.reportVendasSemana.Name = "reportVendasSemana";
            this.reportVendasSemana.Size = new System.Drawing.Size(387, 94);
            this.reportVendasSemana.TabIndex = 52;
            // 
            // reportVendasDia
            // 
            this.reportVendasDia.Location = new System.Drawing.Point(6, 141);
            this.reportVendasDia.Name = "reportVendasDia";
            this.reportVendasDia.Size = new System.Drawing.Size(387, 95);
            this.reportVendasDia.TabIndex = 53;
            // 
            // relatorio_vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(838, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_sair);
            this.Name = "relatorio_vendas";
            this.Text = "relatorio_vendas";
            this.Load += new System.EventHandler(this.relatorio_vendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_cod;
        private System.Windows.Forms.TextBox caixa_codvenda;
        private System.Windows.Forms.Button but_pesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_datainicio;
        private System.Windows.Forms.Label lb_data_fim;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.DateTimePicker dtp_fim;
        private System.Windows.Forms.Button but_sair;
        private System.Windows.Forms.Button but_relatorio_mes;
        private System.Windows.Forms.Button but_relatorio_semana;
        private System.Windows.Forms.Button but_relatorio_dia;
        private Microsoft.Reporting.WinForms.ReportViewer reportVendasMes;
        private Microsoft.Reporting.WinForms.ReportViewer reportVendasSemana;
        private Microsoft.Reporting.WinForms.ReportViewer reportVendasDia;
    }
}