namespace LoguinChocolate
{
    partial class Loguin
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
            this.label_Usuario = new System.Windows.Forms.Label();
            this.label_Senha = new System.Windows.Forms.Label();
            this.Opcoes = new System.Windows.Forms.GroupBox();
            this.but_sair = new System.Windows.Forms.Button();
            this.but_entrar = new System.Windows.Forms.Button();
            this.caixa_usuario = new System.Windows.Forms.TextBox();
            this.caixa_senha = new System.Windows.Forms.TextBox();
            this.Opcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Usuario
            // 
            this.label_Usuario.AutoSize = true;
            this.label_Usuario.Location = new System.Drawing.Point(16, 33);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(49, 13);
            this.label_Usuario.TabIndex = 0;
            this.label_Usuario.Text = "Usuario :";
            // 
            // label_Senha
            // 
            this.label_Senha.AutoSize = true;
            this.label_Senha.Location = new System.Drawing.Point(16, 80);
            this.label_Senha.Name = "label_Senha";
            this.label_Senha.Size = new System.Drawing.Size(44, 13);
            this.label_Senha.TabIndex = 1;
            this.label_Senha.Text = "Senha :";
            // 
            // Opcoes
            // 
            this.Opcoes.BackColor = System.Drawing.SystemColors.Menu;
            this.Opcoes.Controls.Add(this.but_sair);
            this.Opcoes.Controls.Add(this.but_entrar);
            this.Opcoes.Location = new System.Drawing.Point(12, 124);
            this.Opcoes.Name = "Opcoes";
            this.Opcoes.Size = new System.Drawing.Size(295, 123);
            this.Opcoes.TabIndex = 2;
            this.Opcoes.TabStop = false;
            // 
            // but_sair
            // 
            this.but_sair.Location = new System.Drawing.Point(155, 39);
            this.but_sair.Name = "but_sair";
            this.but_sair.Size = new System.Drawing.Size(107, 41);
            this.but_sair.TabIndex = 1;
            this.but_sair.Text = "Sair";
            this.but_sair.UseVisualStyleBackColor = true;
            this.but_sair.Click += new System.EventHandler(this.but_sair_Click);
            // 
            // but_entrar
            // 
            this.but_entrar.Location = new System.Drawing.Point(22, 39);
            this.but_entrar.Name = "but_entrar";
            this.but_entrar.Size = new System.Drawing.Size(107, 41);
            this.but_entrar.TabIndex = 0;
            this.but_entrar.Text = "Entrar";
            this.but_entrar.UseVisualStyleBackColor = true;
            this.but_entrar.Click += new System.EventHandler(this.but_entrar_Click);
            // 
            // caixa_usuario
            // 
            this.caixa_usuario.Location = new System.Drawing.Point(71, 30);
            this.caixa_usuario.Name = "caixa_usuario";
            this.caixa_usuario.Size = new System.Drawing.Size(158, 20);
            this.caixa_usuario.TabIndex = 3;
            // 
            // caixa_senha
            // 
            this.caixa_senha.Location = new System.Drawing.Point(71, 77);
            this.caixa_senha.Name = "caixa_senha";
            this.caixa_senha.PasswordChar = '*';
            this.caixa_senha.Size = new System.Drawing.Size(158, 20);
            this.caixa_senha.TabIndex = 4;
            // 
            // Loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(324, 262);
            this.Controls.Add(this.caixa_senha);
            this.Controls.Add(this.caixa_usuario);
            this.Controls.Add(this.Opcoes);
            this.Controls.Add(this.label_Senha);
            this.Controls.Add(this.label_Usuario);
            this.Name = "Loguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Loguin";
            this.Opcoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.Label label_Senha;
        private System.Windows.Forms.GroupBox Opcoes;
        private System.Windows.Forms.Button but_sair;
        private System.Windows.Forms.Button but_entrar;
        private System.Windows.Forms.TextBox caixa_usuario;
        private System.Windows.Forms.TextBox caixa_senha;
    }
}