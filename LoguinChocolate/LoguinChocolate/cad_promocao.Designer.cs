namespace LoguinChocolate
{
    partial class cad_promocao
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
            this.btn_promocao_destiva = new System.Windows.Forms.Button();
            this.btn_promo_ativar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_salvar = new System.Windows.Forms.Button();
            this.caixa_codproduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.caixa_valor = new System.Windows.Forms.TextBox();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_sair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btn_promocao_destiva);
            this.groupBox1.Controls.Add(this.btn_promo_ativar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.but_salvar);
            this.groupBox1.Controls.Add(this.caixa_codproduto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.caixa_valor);
            this.groupBox1.Controls.Add(this.dtp_final);
            this.groupBox1.Controls.Add(this.dtp_inicio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 414);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Promoção";
            // 
            // btn_promocao_destiva
            // 
            this.btn_promocao_destiva.Location = new System.Drawing.Point(665, 374);
            this.btn_promocao_destiva.Name = "btn_promocao_destiva";
            this.btn_promocao_destiva.Size = new System.Drawing.Size(190, 34);
            this.btn_promocao_destiva.TabIndex = 22;
            this.btn_promocao_destiva.Text = "Desativar Promoção";
            this.btn_promocao_destiva.UseVisualStyleBackColor = true;
            this.btn_promocao_destiva.Click += new System.EventHandler(this.btn_promocao_destiva_Click);
            // 
            // btn_promo_ativar
            // 
            this.btn_promo_ativar.Location = new System.Drawing.Point(461, 374);
            this.btn_promo_ativar.Name = "btn_promo_ativar";
            this.btn_promo_ativar.Size = new System.Drawing.Size(198, 32);
            this.btn_promo_ativar.TabIndex = 21;
            this.btn_promo_ativar.Text = "Ativar promoção";
            this.btn_promo_ativar.UseVisualStyleBackColor = true;
            this.btn_promo_ativar.Click += new System.EventHandler(this.btn_promo_ativar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(331, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 238);
            this.dataGridView1.TabIndex = 19;
            // 
            // but_salvar
            // 
            this.but_salvar.Location = new System.Drawing.Point(867, 373);
            this.but_salvar.Name = "but_salvar";
            this.but_salvar.Size = new System.Drawing.Size(61, 34);
            this.but_salvar.TabIndex = 17;
            this.but_salvar.Text = "Salvar";
            this.but_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_salvar.UseVisualStyleBackColor = true;
            // 
            // caixa_codproduto
            // 
            this.caixa_codproduto.Location = new System.Drawing.Point(168, 243);
            this.caixa_codproduto.Name = "caixa_codproduto";
            this.caixa_codproduto.Size = new System.Drawing.Size(100, 23);
            this.caixa_codproduto.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Codigo do Produto";
            // 
            // caixa_valor
            // 
            this.caixa_valor.Location = new System.Drawing.Point(86, 190);
            this.caixa_valor.Name = "caixa_valor";
            this.caixa_valor.Size = new System.Drawing.Size(100, 23);
            this.caixa_valor.TabIndex = 14;
            // 
            // dtp_final
            // 
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_final.Location = new System.Drawing.Point(127, 148);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(111, 23);
            this.dtp_final.TabIndex = 13;
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicio.Location = new System.Drawing.Point(134, 105);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(103, 23);
            this.dtp_inicio.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Inicio :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Final : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor : ";
            // 
            // but_sair
            // 
            this.but_sair.Location = new System.Drawing.Point(977, 547);
            this.but_sair.Name = "but_sair";
            this.but_sair.Size = new System.Drawing.Size(84, 37);
            this.but_sair.TabIndex = 18;
            this.but_sair.Text = "Sair";
            this.but_sair.UseVisualStyleBackColor = true;
            this.but_sair.Click += new System.EventHandler(this.but_sair_Click);
            // 
            // cad_promocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1073, 596);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.but_sair);
            this.Name = "cad_promocao";
            this.Text = "cad_promocao";
            this.Load += new System.EventHandler(this.cad_promocao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox caixa_codproduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox caixa_valor;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.Button but_salvar;
        private System.Windows.Forms.Button but_sair;
        private System.Windows.Forms.Button btn_promocao_destiva;
        private System.Windows.Forms.Button btn_promo_ativar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}