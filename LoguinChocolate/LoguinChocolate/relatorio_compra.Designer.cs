namespace LoguinChocolate
{
    partial class relatorio_compra
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
            this.but_relatorio_mes = new System.Windows.Forms.Button();
            this.but_relatorio_semana = new System.Windows.Forms.Button();
            this.but_relatorio_dia = new System.Windows.Forms.Button();
            this.report_compras_mes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.report_compras_semana = new Microsoft.Reporting.WinForms.ReportViewer();
            this.report_compras_dia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.caixa_codcompra = new System.Windows.Forms.TextBox();
            this.but_pesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_datainicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fim = new System.Windows.Forms.DateTimePicker();
            this.but_sair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.but_relatorio_mes);
            this.groupBox1.Controls.Add(this.but_relatorio_semana);
            this.groupBox1.Controls.Add(this.but_relatorio_dia);
            this.groupBox1.Controls.Add(this.report_compras_mes);
            this.groupBox1.Controls.Add(this.report_compras_semana);
            this.groupBox1.Controls.Add(this.report_compras_dia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.caixa_codcompra);
            this.groupBox1.Controls.Add(this.but_pesquisar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.lb_datainicio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_inicio);
            this.groupBox1.Controls.Add(this.dtp_fim);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // but_relatorio_mes
            // 
            this.but_relatorio_mes.Location = new System.Drawing.Point(256, 107);
            this.but_relatorio_mes.Name = "but_relatorio_mes";
            this.but_relatorio_mes.Size = new System.Drawing.Size(75, 23);
            this.but_relatorio_mes.TabIndex = 71;
            this.but_relatorio_mes.Text = "Mês";
            this.but_relatorio_mes.UseVisualStyleBackColor = true;
            this.but_relatorio_mes.Click += new System.EventHandler(this.but_relatorio_mes_Click);
            // 
            // but_relatorio_semana
            // 
            this.but_relatorio_semana.Location = new System.Drawing.Point(139, 107);
            this.but_relatorio_semana.Name = "but_relatorio_semana";
            this.but_relatorio_semana.Size = new System.Drawing.Size(75, 23);
            this.but_relatorio_semana.TabIndex = 70;
            this.but_relatorio_semana.Text = "Semana";
            this.but_relatorio_semana.UseVisualStyleBackColor = true;
            this.but_relatorio_semana.Click += new System.EventHandler(this.but_relatorio_semana_Click);
            // 
            // but_relatorio_dia
            // 
            this.but_relatorio_dia.Location = new System.Drawing.Point(22, 107);
            this.but_relatorio_dia.Name = "but_relatorio_dia";
            this.but_relatorio_dia.Size = new System.Drawing.Size(75, 23);
            this.but_relatorio_dia.TabIndex = 69;
            this.but_relatorio_dia.Text = "Dia";
            this.but_relatorio_dia.UseVisualStyleBackColor = true;
            this.but_relatorio_dia.Click += new System.EventHandler(this.but_relatorio_dia_Click);
            // 
            // report_compras_mes
            // 
            this.report_compras_mes.Location = new System.Drawing.Point(9, 360);
            this.report_compras_mes.Name = "report_compras_mes";
            this.report_compras_mes.Size = new System.Drawing.Size(363, 96);
            this.report_compras_mes.TabIndex = 68;
            // 
            // report_compras_semana
            // 
            this.report_compras_semana.Location = new System.Drawing.Point(9, 253);
            this.report_compras_semana.Name = "report_compras_semana";
            this.report_compras_semana.Size = new System.Drawing.Size(363, 88);
            this.report_compras_semana.TabIndex = 67;
            // 
            // report_compras_dia
            // 
            this.report_compras_dia.Location = new System.Drawing.Point(9, 148);
            this.report_compras_dia.Name = "report_compras_dia";
            this.report_compras_dia.Size = new System.Drawing.Size(363, 90);
            this.report_compras_dia.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-41, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "label4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-47, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "label10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-47, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "label7";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-47, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "label14";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Cod Compra : ";
            // 
            // caixa_codcompra
            // 
            this.caixa_codcompra.Location = new System.Drawing.Point(86, 33);
            this.caixa_codcompra.Name = "caixa_codcompra";
            this.caixa_codcompra.Size = new System.Drawing.Size(94, 20);
            this.caixa_codcompra.TabIndex = 54;
            // 
            // but_pesquisar
            // 
            this.but_pesquisar.Location = new System.Drawing.Point(613, 394);
            this.but_pesquisar.Name = "but_pesquisar";
            this.but_pesquisar.Size = new System.Drawing.Size(98, 37);
            this.but_pesquisar.TabIndex = 53;
            this.but_pesquisar.Text = "Pesquisar";
            this.but_pesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(421, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(380, 336);
            this.dataGridView1.TabIndex = 51;
            // 
            // lb_datainicio
            // 
            this.lb_datainicio.AutoSize = true;
            this.lb_datainicio.Location = new System.Drawing.Point(19, 75);
            this.lb_datainicio.Name = "lb_datainicio";
            this.lb_datainicio.Size = new System.Drawing.Size(81, 13);
            this.lb_datainicio.TabIndex = 50;
            this.lb_datainicio.Text = "Data de inicio : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Data de Fim :";
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicio.Location = new System.Drawing.Point(105, 69);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(94, 20);
            this.dtp_inicio.TabIndex = 48;
            // 
            // dtp_fim
            // 
            this.dtp_fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fim.Location = new System.Drawing.Point(262, 33);
            this.dtp_fim.Name = "dtp_fim";
            this.dtp_fim.Size = new System.Drawing.Size(83, 20);
            this.dtp_fim.TabIndex = 47;
            // 
            // but_sair
            // 
            this.but_sair.Location = new System.Drawing.Point(768, 491);
            this.but_sair.Name = "but_sair";
            this.but_sair.Size = new System.Drawing.Size(81, 32);
            this.but_sair.TabIndex = 52;
            this.but_sair.Text = "Sair";
            this.but_sair.UseVisualStyleBackColor = true;
            // 
            // relatorio_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(881, 525);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.but_sair);
            this.Name = "relatorio_compra";
            this.Text = "relatorio_compra";
            this.Load += new System.EventHandler(this.relatorio_compra_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox caixa_codcompra;
        private System.Windows.Forms.Button but_pesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_datainicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.DateTimePicker dtp_fim;
        private System.Windows.Forms.Button but_sair;
        private Microsoft.Reporting.WinForms.ReportViewer report_compras_dia;
        private Microsoft.Reporting.WinForms.ReportViewer report_compras_semana;
        private Microsoft.Reporting.WinForms.ReportViewer report_compras_mes;
        private System.Windows.Forms.Button but_relatorio_mes;
        private System.Windows.Forms.Button but_relatorio_semana;
        private System.Windows.Forms.Button but_relatorio_dia;

    }
}