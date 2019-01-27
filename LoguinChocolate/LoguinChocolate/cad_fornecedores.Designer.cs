namespace LoguinChocolate
{
    partial class cad_fornecedores
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
            this.but_ok = new System.Windows.Forms.Button();
            this.but_pesquisa = new System.Windows.Forms.Button();
            this.caixa_cod = new System.Windows.Forms.TextBox();
            this.lb_cod = new System.Windows.Forms.Label();
            this.lb_email2 = new System.Windows.Forms.Label();
            this.caixa_email2 = new System.Windows.Forms.TextBox();
            this.caixa_celular = new System.Windows.Forms.TextBox();
            this.lb_celular = new System.Windows.Forms.Label();
            this.caixa_telefone2 = new System.Windows.Forms.TextBox();
            this.lb_telefone2 = new System.Windows.Forms.Label();
            this.but_deletar = new System.Windows.Forms.Button();
            this.but_inserir = new System.Windows.Forms.Button();
            this.but_alterar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_cnpj = new System.Windows.Forms.Label();
            this.lb_contato = new System.Windows.Forms.Label();
            this.lb_numero = new System.Windows.Forms.Label();
            this.lb_email1 = new System.Windows.Forms.Label();
            this.caixa_nome = new System.Windows.Forms.TextBox();
            this.caixa_cnpj = new System.Windows.Forms.TextBox();
            this.caixa_nomecontato = new System.Windows.Forms.TextBox();
            this.caixa_telefone1 = new System.Windows.Forms.TextBox();
            this.caixa_email1 = new System.Windows.Forms.TextBox();
            this.but_sair = new System.Windows.Forms.Button();
            this.lb_nome.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_nome.Controls.Add(this.but_ok);
            this.lb_nome.Controls.Add(this.but_pesquisa);
            this.lb_nome.Controls.Add(this.caixa_cod);
            this.lb_nome.Controls.Add(this.lb_cod);
            this.lb_nome.Controls.Add(this.lb_email2);
            this.lb_nome.Controls.Add(this.caixa_email2);
            this.lb_nome.Controls.Add(this.caixa_celular);
            this.lb_nome.Controls.Add(this.lb_celular);
            this.lb_nome.Controls.Add(this.caixa_telefone2);
            this.lb_nome.Controls.Add(this.lb_telefone2);
            this.lb_nome.Controls.Add(this.but_deletar);
            this.lb_nome.Controls.Add(this.but_inserir);
            this.lb_nome.Controls.Add(this.but_alterar);
            this.lb_nome.Controls.Add(this.label8);
            this.lb_nome.Controls.Add(this.lb_cnpj);
            this.lb_nome.Controls.Add(this.lb_contato);
            this.lb_nome.Controls.Add(this.lb_numero);
            this.lb_nome.Controls.Add(this.lb_email1);
            this.lb_nome.Controls.Add(this.caixa_nome);
            this.lb_nome.Controls.Add(this.caixa_cnpj);
            this.lb_nome.Controls.Add(this.caixa_nomecontato);
            this.lb_nome.Controls.Add(this.caixa_telefone1);
            this.lb_nome.Controls.Add(this.caixa_email1);
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(11, 12);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(779, 342);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.TabStop = false;
            this.lb_nome.Text = "Cadastro Fornecedores";
            // 
            // but_ok
            // 
            this.but_ok.Enabled = false;
            this.but_ok.Location = new System.Drawing.Point(258, 192);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(61, 24);
            this.but_ok.TabIndex = 39;
            this.but_ok.Text = "OK";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Visible = false;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // but_pesquisa
            // 
            this.but_pesquisa.Location = new System.Drawing.Point(312, 299);
            this.but_pesquisa.Name = "but_pesquisa";
            this.but_pesquisa.Size = new System.Drawing.Size(93, 26);
            this.but_pesquisa.TabIndex = 38;
            this.but_pesquisa.Text = "Pesquisa";
            this.but_pesquisa.UseVisualStyleBackColor = true;
            this.but_pesquisa.Click += new System.EventHandler(this.but_pesquisa_Click);
            // 
            // caixa_cod
            // 
            this.caixa_cod.Location = new System.Drawing.Point(98, 193);
            this.caixa_cod.Name = "caixa_cod";
            this.caixa_cod.Size = new System.Drawing.Size(141, 23);
            this.caixa_cod.TabIndex = 37;
            // 
            // lb_cod
            // 
            this.lb_cod.AutoSize = true;
            this.lb_cod.Location = new System.Drawing.Point(36, 196);
            this.lb_cod.Name = "lb_cod";
            this.lb_cod.Size = new System.Drawing.Size(56, 17);
            this.lb_cod.TabIndex = 36;
            this.lb_cod.Text = "Codigo:";
            // 
            // lb_email2
            // 
            this.lb_email2.AutoSize = true;
            this.lb_email2.Location = new System.Drawing.Point(432, 110);
            this.lb_email2.Name = "lb_email2";
            this.lb_email2.Size = new System.Drawing.Size(67, 17);
            this.lb_email2.TabIndex = 28;
            this.lb_email2.Text = "E-mail 2 :";
            // 
            // caixa_email2
            // 
            this.caixa_email2.Location = new System.Drawing.Point(505, 107);
            this.caixa_email2.Name = "caixa_email2";
            this.caixa_email2.Size = new System.Drawing.Size(241, 23);
            this.caixa_email2.TabIndex = 27;
            // 
            // caixa_celular
            // 
            this.caixa_celular.Location = new System.Drawing.Point(497, 151);
            this.caixa_celular.Name = "caixa_celular";
            this.caixa_celular.Size = new System.Drawing.Size(100, 23);
            this.caixa_celular.TabIndex = 26;
            // 
            // lb_celular
            // 
            this.lb_celular.AutoSize = true;
            this.lb_celular.Location = new System.Drawing.Point(431, 154);
            this.lb_celular.Name = "lb_celular";
            this.lb_celular.Size = new System.Drawing.Size(60, 17);
            this.lb_celular.TabIndex = 25;
            this.lb_celular.Text = "Celular :";
            // 
            // caixa_telefone2
            // 
            this.caixa_telefone2.Location = new System.Drawing.Point(312, 151);
            this.caixa_telefone2.Name = "caixa_telefone2";
            this.caixa_telefone2.Size = new System.Drawing.Size(100, 23);
            this.caixa_telefone2.TabIndex = 24;
            // 
            // lb_telefone2
            // 
            this.lb_telefone2.AutoSize = true;
            this.lb_telefone2.Location = new System.Drawing.Point(216, 154);
            this.lb_telefone2.Name = "lb_telefone2";
            this.lb_telefone2.Size = new System.Drawing.Size(90, 17);
            this.lb_telefone2.TabIndex = 23;
            this.lb_telefone2.Text = "2° Telefone :";
            // 
            // but_deletar
            // 
            this.but_deletar.Enabled = false;
            this.but_deletar.Location = new System.Drawing.Point(678, 295);
            this.but_deletar.Name = "but_deletar";
            this.but_deletar.Size = new System.Drawing.Size(97, 34);
            this.but_deletar.TabIndex = 19;
            this.but_deletar.Text = "Deletar";
            this.but_deletar.UseVisualStyleBackColor = true;
            this.but_deletar.Click += new System.EventHandler(this.but_deletar_Click);
            // 
            // but_inserir
            // 
            this.but_inserir.Location = new System.Drawing.Point(435, 295);
            this.but_inserir.Name = "but_inserir";
            this.but_inserir.Size = new System.Drawing.Size(100, 34);
            this.but_inserir.TabIndex = 18;
            this.but_inserir.Text = "Concluir";
            this.but_inserir.UseVisualStyleBackColor = true;
            this.but_inserir.Click += new System.EventHandler(this.but_inserir_Click);
            // 
            // but_alterar
            // 
            this.but_alterar.Enabled = false;
            this.but_alterar.Location = new System.Drawing.Point(566, 295);
            this.but_alterar.Name = "but_alterar";
            this.but_alterar.Size = new System.Drawing.Size(96, 34);
            this.but_alterar.TabIndex = 16;
            this.but_alterar.Text = "Alterar";
            this.but_alterar.UseVisualStyleBackColor = true;
            this.but_alterar.Click += new System.EventHandler(this.but_alterar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nome:";
            // 
            // lb_cnpj
            // 
            this.lb_cnpj.AutoSize = true;
            this.lb_cnpj.Location = new System.Drawing.Point(25, 77);
            this.lb_cnpj.Name = "lb_cnpj";
            this.lb_cnpj.Size = new System.Drawing.Size(55, 17);
            this.lb_cnpj.TabIndex = 14;
            this.lb_cnpj.Text = "CNPJ : ";
            // 
            // lb_contato
            // 
            this.lb_contato.AutoSize = true;
            this.lb_contato.Location = new System.Drawing.Point(372, 44);
            this.lb_contato.Name = "lb_contato";
            this.lb_contato.Size = new System.Drawing.Size(126, 17);
            this.lb_contato.TabIndex = 13;
            this.lb_contato.Text = "Nome do Contato :";
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Location = new System.Drawing.Point(6, 154);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(90, 17);
            this.lb_numero.TabIndex = 12;
            this.lb_numero.Text = "1° Telefone :";
            // 
            // lb_email1
            // 
            this.lb_email1.AutoSize = true;
            this.lb_email1.Location = new System.Drawing.Point(25, 113);
            this.lb_email1.Name = "lb_email1";
            this.lb_email1.Size = new System.Drawing.Size(67, 17);
            this.lb_email1.TabIndex = 11;
            this.lb_email1.Text = "E-mail 1 :";
            // 
            // caixa_nome
            // 
            this.caixa_nome.Location = new System.Drawing.Point(98, 38);
            this.caixa_nome.Name = "caixa_nome";
            this.caixa_nome.Size = new System.Drawing.Size(242, 23);
            this.caixa_nome.TabIndex = 7;
            // 
            // caixa_cnpj
            // 
            this.caixa_cnpj.Location = new System.Drawing.Point(98, 74);
            this.caixa_cnpj.Name = "caixa_cnpj";
            this.caixa_cnpj.Size = new System.Drawing.Size(142, 23);
            this.caixa_cnpj.TabIndex = 6;
            // 
            // caixa_nomecontato
            // 
            this.caixa_nomecontato.Location = new System.Drawing.Point(505, 41);
            this.caixa_nomecontato.Name = "caixa_nomecontato";
            this.caixa_nomecontato.Size = new System.Drawing.Size(241, 23);
            this.caixa_nomecontato.TabIndex = 5;
            // 
            // caixa_telefone1
            // 
            this.caixa_telefone1.Location = new System.Drawing.Point(98, 151);
            this.caixa_telefone1.Name = "caixa_telefone1";
            this.caixa_telefone1.Size = new System.Drawing.Size(100, 23);
            this.caixa_telefone1.TabIndex = 4;
            // 
            // caixa_email1
            // 
            this.caixa_email1.Location = new System.Drawing.Point(98, 107);
            this.caixa_email1.Name = "caixa_email1";
            this.caixa_email1.Size = new System.Drawing.Size(242, 23);
            this.caixa_email1.TabIndex = 3;
            // 
            // but_sair
            // 
            this.but_sair.Location = new System.Drawing.Point(715, 360);
            this.but_sair.Name = "but_sair";
            this.but_sair.Size = new System.Drawing.Size(75, 23);
            this.but_sair.TabIndex = 17;
            this.but_sair.Text = "Sair";
            this.but_sair.UseVisualStyleBackColor = true;
            // 
            // cad_fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(816, 391);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.but_sair);
            this.Name = "cad_fornecedores";
            this.Text = "cad_fornecedores";
            this.lb_nome.ResumeLayout(false);
            this.lb_nome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lb_nome;
        private System.Windows.Forms.Button but_deletar;
        private System.Windows.Forms.Button but_inserir;
        private System.Windows.Forms.Button but_sair;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_cnpj;
        private System.Windows.Forms.Label lb_contato;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.Label lb_email1;
        private System.Windows.Forms.TextBox caixa_nome;
        private System.Windows.Forms.TextBox caixa_cnpj;
        private System.Windows.Forms.TextBox caixa_nomecontato;
        private System.Windows.Forms.TextBox caixa_telefone1;
        private System.Windows.Forms.TextBox caixa_email1;
        private System.Windows.Forms.Label lb_email2;
        private System.Windows.Forms.TextBox caixa_email2;
        private System.Windows.Forms.TextBox caixa_celular;
        private System.Windows.Forms.Label lb_celular;
        private System.Windows.Forms.TextBox caixa_telefone2;
        private System.Windows.Forms.Label lb_telefone2;
        private System.Windows.Forms.Button but_alterar;
        private System.Windows.Forms.TextBox caixa_cod;
        private System.Windows.Forms.Label lb_cod;
        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.Button but_pesquisa;
    }
}