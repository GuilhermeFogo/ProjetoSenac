namespace cad_fornecedores
{
    partial class Form1
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
            this.lb_nome = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.caixa_numero = new System.Windows.Forms.TextBox();
            this.caixa_contato = new System.Windows.Forms.TextBox();
            this.caixa_nome = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.lb_contato = new System.Windows.Forms.Label();
            this.lb_cnpj = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.but_alterar = new System.Windows.Forms.Button();
            this.but_sair = new System.Windows.Forms.Button();
            this.but_inserir = new System.Windows.Forms.Button();
            this.but_excluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_listar = new System.Windows.Forms.Button();
            this.lb_nome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_nome.Controls.Add(this.but_listar);
            this.lb_nome.Controls.Add(this.dataGridView1);
            this.lb_nome.Controls.Add(this.but_excluir);
            this.lb_nome.Controls.Add(this.but_inserir);
            this.lb_nome.Controls.Add(this.but_sair);
            this.lb_nome.Controls.Add(this.but_alterar);
            this.lb_nome.Controls.Add(this.label8);
            this.lb_nome.Controls.Add(this.lb_cnpj);
            this.lb_nome.Controls.Add(this.lb_contato);
            this.lb_nome.Controls.Add(this.lb_numero);
            this.lb_nome.Controls.Add(this.label4);
            this.lb_nome.Controls.Add(this.textBox8);
            this.lb_nome.Controls.Add(this.caixa_nome);
            this.lb_nome.Controls.Add(this.caixa_contato);
            this.lb_nome.Controls.Add(this.caixa_numero);
            this.lb_nome.Controls.Add(this.textBox4);
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(12, 12);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(1032, 446);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.TabStop = false;
            this.lb_nome.Text = "Cadastro Fornecedores";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(566, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 3;
            // 
            // caixa_numero
            // 
            this.caixa_numero.Location = new System.Drawing.Point(367, 112);
            this.caixa_numero.Name = "caixa_numero";
            this.caixa_numero.Size = new System.Drawing.Size(100, 23);
            this.caixa_numero.TabIndex = 4;
            // 
            // caixa_contato
            // 
            this.caixa_contato.Location = new System.Drawing.Point(159, 112);
            this.caixa_contato.Name = "caixa_contato";
            this.caixa_contato.Size = new System.Drawing.Size(100, 23);
            this.caixa_contato.TabIndex = 5;
            // 
            // caixa_nome
            // 
            this.caixa_nome.Location = new System.Drawing.Point(283, 44);
            this.caixa_nome.Name = "caixa_nome";
            this.caixa_nome.Size = new System.Drawing.Size(100, 23);
            this.caixa_nome.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(92, 44);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 23);
            this.textBox8.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "E-mail :";
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(296, 115);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(70, 17);
            this.lb_numero.TabIndex = 12;
            this.lb_numero.Text = "Numero : ";
            // 
            // lb_contato
            // 
            this.lb_contato.AutoSize = true;
            this.lb_contato.Location = new System.Drawing.Point(30, 115);
            this.lb_contato.Name = "lb_contato";
            this.lb_contato.Size = new System.Drawing.Size(126, 17);
            this.lb_contato.TabIndex = 13;
            this.lb_contato.Text = "Nome do Contato :";
            // 
            // lb_cnpj
            // 
            this.lb_cnpj.AutoSize = true;
            this.lb_cnpj.Location = new System.Drawing.Point(223, 47);
            this.lb_cnpj.Name = "lb_cnpj";
            this.lb_cnpj.Size = new System.Drawing.Size(55, 17);
            this.lb_cnpj.TabIndex = 14;
            this.lb_cnpj.Text = "CNPJ : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nome:";
            // 
            // but_alterar
            // 
            this.but_alterar.Location = new System.Drawing.Point(197, 386);
            this.but_alterar.Name = "but_alterar";
            this.but_alterar.Size = new System.Drawing.Size(96, 37);
            this.but_alterar.TabIndex = 16;
            this.but_alterar.Text = "Alterar";
            this.but_alterar.UseVisualStyleBackColor = true;
            // 
            // but_sair
            // 
            this.but_sair.Location = new System.Drawing.Point(941, 417);
            this.but_sair.Name = "but_sair";
            this.but_sair.Size = new System.Drawing.Size(75, 23);
            this.but_sair.TabIndex = 17;
            this.but_sair.Text = "Sair";
            this.but_sair.UseVisualStyleBackColor = true;
            // 
            // but_inserir
            // 
            this.but_inserir.Location = new System.Drawing.Point(58, 387);
            this.but_inserir.Name = "but_inserir";
            this.but_inserir.Size = new System.Drawing.Size(98, 34);
            this.but_inserir.TabIndex = 18;
            this.but_inserir.Text = "Concluir";
            this.but_inserir.UseVisualStyleBackColor = true;
            // 
            // but_excluir
            // 
            this.but_excluir.Location = new System.Drawing.Point(317, 386);
            this.but_excluir.Name = "but_excluir";
            this.but_excluir.Size = new System.Drawing.Size(99, 37);
            this.but_excluir.TabIndex = 19;
            this.but_excluir.Text = "Excluir";
            this.but_excluir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(566, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(329, 188);
            this.dataGridView1.TabIndex = 20;
            // 
            // but_listar
            // 
            this.but_listar.Location = new System.Drawing.Point(482, 245);
            this.but_listar.Name = "but_listar";
            this.but_listar.Size = new System.Drawing.Size(75, 23);
            this.but_listar.TabIndex = 21;
            this.but_listar.Text = "Listar";
            this.but_listar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 470);
            this.Controls.Add(this.lb_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.lb_nome.ResumeLayout(false);
            this.lb_nome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lb_nome;
        private System.Windows.Forms.Button but_inserir;
        private System.Windows.Forms.Button but_sair;
        private System.Windows.Forms.Button but_alterar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_cnpj;
        private System.Windows.Forms.Label lb_contato;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox caixa_nome;
        private System.Windows.Forms.TextBox caixa_contato;
        private System.Windows.Forms.TextBox caixa_numero;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button but_listar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_excluir;
    }
}

