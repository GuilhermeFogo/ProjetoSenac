namespace LoguinChocolate
{
    partial class cad_Usuarios
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
            this.caixa_cod = new System.Windows.Forms.TextBox();
            this.lb_cod = new System.Windows.Forms.Label();
            this.numericupdown = new System.Windows.Forms.TextBox();
            this.but_deletar = new System.Windows.Forms.Button();
            this.but_alterar = new System.Windows.Forms.Button();
            this.but_concluir = new System.Windows.Forms.Button();
            this.lb_identificador = new System.Windows.Forms.Label();
            this.caixa_email = new System.Windows.Forms.TextBox();
            this.dtp_nascimento = new System.Windows.Forms.DateTimePicker();
            this.caixa_senha = new System.Windows.Forms.TextBox();
            this.caixa_nome = new System.Windows.Forms.TextBox();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.but_sair = new System.Windows.Forms.Button();
            this.but_ok = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.but_pesquisar);
            this.groupBox1.Controls.Add(this.caixa_cod);
            this.groupBox1.Controls.Add(this.lb_cod);
            this.groupBox1.Controls.Add(this.numericupdown);
            this.groupBox1.Controls.Add(this.but_deletar);
            this.groupBox1.Controls.Add(this.but_alterar);
            this.groupBox1.Controls.Add(this.but_concluir);
            this.groupBox1.Controls.Add(this.lb_identificador);
            this.groupBox1.Controls.Add(this.caixa_email);
            this.groupBox1.Controls.Add(this.dtp_nascimento);
            this.groupBox1.Controls.Add(this.caixa_senha);
            this.groupBox1.Controls.Add(this.caixa_nome);
            this.groupBox1.Controls.Add(this.lb_data);
            this.groupBox1.Controls.Add(this.lb_email);
            this.groupBox1.Controls.Add(this.lb_senha);
            this.groupBox1.Controls.Add(this.lb_nome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Usuario";
            // 
            // but_pesquisar
            // 
            this.but_pesquisar.Location = new System.Drawing.Point(260, 269);
            this.but_pesquisar.Name = "but_pesquisar";
            this.but_pesquisar.Size = new System.Drawing.Size(117, 40);
            this.but_pesquisar.TabIndex = 36;
            this.but_pesquisar.Text = "Desbloquear";
            this.but_pesquisar.UseVisualStyleBackColor = true;
            this.but_pesquisar.Click += new System.EventHandler(this.but_pesquisar_Click);
            // 
            // caixa_cod
            // 
            this.caixa_cod.Enabled = false;
            this.caixa_cod.Location = new System.Drawing.Point(117, 47);
            this.caixa_cod.Name = "caixa_cod";
            this.caixa_cod.Size = new System.Drawing.Size(141, 23);
            this.caixa_cod.TabIndex = 35;
            // 
            // lb_cod
            // 
            this.lb_cod.AutoSize = true;
            this.lb_cod.Location = new System.Drawing.Point(55, 50);
            this.lb_cod.Name = "lb_cod";
            this.lb_cod.Size = new System.Drawing.Size(56, 17);
            this.lb_cod.TabIndex = 34;
            this.lb_cod.Text = "Codigo:";
            // 
            // numericupdown
            // 
            this.numericupdown.Location = new System.Drawing.Point(127, 281);
            this.numericupdown.Name = "numericupdown";
            this.numericupdown.Size = new System.Drawing.Size(100, 23);
            this.numericupdown.TabIndex = 33;
            // 
            // but_deletar
            // 
            this.but_deletar.Enabled = false;
            this.but_deletar.Location = new System.Drawing.Point(297, 327);
            this.but_deletar.Name = "but_deletar";
            this.but_deletar.Size = new System.Drawing.Size(92, 34);
            this.but_deletar.TabIndex = 32;
            this.but_deletar.Text = "Deletar";
            this.but_deletar.UseVisualStyleBackColor = true;
            this.but_deletar.Click += new System.EventHandler(this.but_deletar_Click);
            // 
            // but_alterar
            // 
            this.but_alterar.Enabled = false;
            this.but_alterar.Location = new System.Drawing.Point(198, 327);
            this.but_alterar.Name = "but_alterar";
            this.but_alterar.Size = new System.Drawing.Size(93, 34);
            this.but_alterar.TabIndex = 31;
            this.but_alterar.Text = "Alterar";
            this.but_alterar.UseVisualStyleBackColor = true;
            this.but_alterar.Click += new System.EventHandler(this.but_alterar_Click);
            // 
            // but_concluir
            // 
            this.but_concluir.Location = new System.Drawing.Point(80, 327);
            this.but_concluir.Name = "but_concluir";
            this.but_concluir.Size = new System.Drawing.Size(112, 34);
            this.but_concluir.TabIndex = 30;
            this.but_concluir.Text = "Concluir";
            this.but_concluir.UseVisualStyleBackColor = true;
            this.but_concluir.Click += new System.EventHandler(this.but_concluir_Click);
            // 
            // lb_identificador
            // 
            this.lb_identificador.AutoSize = true;
            this.lb_identificador.Location = new System.Drawing.Point(21, 281);
            this.lb_identificador.Name = "lb_identificador";
            this.lb_identificador.Size = new System.Drawing.Size(97, 17);
            this.lb_identificador.TabIndex = 25;
            this.lb_identificador.Text = " Identificador :";
            // 
            // caixa_email
            // 
            this.caixa_email.Location = new System.Drawing.Point(74, 196);
            this.caixa_email.Name = "caixa_email";
            this.caixa_email.Size = new System.Drawing.Size(284, 23);
            this.caixa_email.TabIndex = 23;
            // 
            // dtp_nascimento
            // 
            this.dtp_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nascimento.Location = new System.Drawing.Point(74, 235);
            this.dtp_nascimento.Name = "dtp_nascimento";
            this.dtp_nascimento.Size = new System.Drawing.Size(87, 23);
            this.dtp_nascimento.TabIndex = 22;
            // 
            // caixa_senha
            // 
            this.caixa_senha.Location = new System.Drawing.Point(80, 149);
            this.caixa_senha.Name = "caixa_senha";
            this.caixa_senha.PasswordChar = '*';
            this.caixa_senha.Size = new System.Drawing.Size(178, 23);
            this.caixa_senha.TabIndex = 21;
            // 
            // caixa_nome
            // 
            this.caixa_nome.Location = new System.Drawing.Point(153, 85);
            this.caixa_nome.Name = "caixa_nome";
            this.caixa_nome.Size = new System.Drawing.Size(224, 23);
            this.caixa_nome.TabIndex = 20;
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Location = new System.Drawing.Point(22, 241);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(46, 17);
            this.lb_data.TabIndex = 19;
            this.lb_data.Text = "Data :";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(24, 199);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(50, 17);
            this.lb_email.TabIndex = 18;
            this.lb_email.Text = "Email :";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(22, 149);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(57, 17);
            this.lb_senha.TabIndex = 17;
            this.lb_senha.Text = "Senha :";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(21, 87);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(126, 17);
            this.lb_nome.TabIndex = 16;
            this.lb_nome.Text = "Nome do Usuario :";
            // 
            // but_sair
            // 
            this.but_sair.Location = new System.Drawing.Point(388, 396);
            this.but_sair.Name = "but_sair";
            this.but_sair.Size = new System.Drawing.Size(69, 27);
            this.but_sair.TabIndex = 27;
            this.but_sair.Text = "Sair";
            this.but_sair.UseVisualStyleBackColor = true;
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(268, 403);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(93, 20);
            this.but_ok.TabIndex = 28;
            this.but_ok.Text = "OK";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Visible = false;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // cad_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(480, 429);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.but_sair);
            this.Name = "cad_Usuarios";
            this.Text = " Cadastro de Usuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_sair;
        private System.Windows.Forms.Button but_concluir;
        private System.Windows.Forms.Label lb_identificador;
        private System.Windows.Forms.TextBox caixa_email;
        private System.Windows.Forms.DateTimePicker dtp_nascimento;
        private System.Windows.Forms.TextBox caixa_senha;
        private System.Windows.Forms.TextBox caixa_nome;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Button but_alterar;
        private System.Windows.Forms.Button but_deletar;
        private System.Windows.Forms.TextBox numericupdown;
        private System.Windows.Forms.TextBox caixa_cod;
        private System.Windows.Forms.Label lb_cod;
        private System.Windows.Forms.Button but_pesquisar;
        private System.Windows.Forms.Button but_ok;


    }
}