namespace LoguinChocolate
{
    partial class cad_Produtos
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
            this.but_concluir = new System.Windows.Forms.Button();
            this.but_pesquisar = new System.Windows.Forms.Button();
            this.cod_p = new System.Windows.Forms.Label();
            this.caixa_cod_p = new System.Windows.Forms.TextBox();
            this.but_promocao = new System.Windows.Forms.Button();
            this.but_alterar = new System.Windows.Forms.Button();
            this.but_deletar = new System.Windows.Forms.Button();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.caixa_descricao = new System.Windows.Forms.RichTextBox();
            this.LB_descricao = new System.Windows.Forms.Label();
            this.lb_marca = new System.Windows.Forms.Label();
            this.caixa_codmarca = new System.Windows.Forms.TextBox();
            this.lb_preco_promocao = new System.Windows.Forms.Label();
            this.caixa_preco = new System.Windows.Forms.TextBox();
            this.lb_preco = new System.Windows.Forms.Label();
            this.caixa_cod_barras = new System.Windows.Forms.TextBox();
            this.caixa_nome = new System.Windows.Forms.TextBox();
            this.lb_cod = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.dataGrid_Marcas = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cadastro = new System.Windows.Forms.GroupBox();
            this.but_deletar_marca = new System.Windows.Forms.Button();
            this.but_alterar_marca = new System.Windows.Forms.Button();
            this.but_selecionar_marcas = new System.Windows.Forms.Button();
            this.caixa_alterar_marca = new System.Windows.Forms.TextBox();
            this.caixa_cod_marca = new System.Windows.Forms.TextBox();
            this.lbl_novo_nome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_CadastrarMarcas = new System.Windows.Forms.Button();
            this.lb_CodMarca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.caixa_nova_marca = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Marcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.but_concluir);
            this.groupBox1.Controls.Add(this.but_pesquisar);
            this.groupBox1.Controls.Add(this.cod_p);
            this.groupBox1.Controls.Add(this.caixa_cod_p);
            this.groupBox1.Controls.Add(this.but_promocao);
            this.groupBox1.Controls.Add(this.but_alterar);
            this.groupBox1.Controls.Add(this.but_deletar);
            this.groupBox1.Controls.Add(this.btn_cadastro);
            this.groupBox1.Controls.Add(this.caixa_descricao);
            this.groupBox1.Controls.Add(this.LB_descricao);
            this.groupBox1.Controls.Add(this.lb_marca);
            this.groupBox1.Controls.Add(this.caixa_codmarca);
            this.groupBox1.Controls.Add(this.lb_preco_promocao);
            this.groupBox1.Controls.Add(this.caixa_preco);
            this.groupBox1.Controls.Add(this.lb_preco);
            this.groupBox1.Controls.Add(this.caixa_cod_barras);
            this.groupBox1.Controls.Add(this.caixa_nome);
            this.groupBox1.Controls.Add(this.lb_cod);
            this.groupBox1.Controls.Add(this.lb_nome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 380);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Produtos";
            // 
            // but_concluir
            // 
            this.but_concluir.Location = new System.Drawing.Point(285, 32);
            this.but_concluir.Name = "but_concluir";
            this.but_concluir.Size = new System.Drawing.Size(80, 23);
            this.but_concluir.TabIndex = 44;
            this.but_concluir.Text = "Concluir";
            this.but_concluir.UseVisualStyleBackColor = true;
            this.but_concluir.Visible = false;
            this.but_concluir.Click += new System.EventHandler(this.but_concluir_Click);
            // 
            // but_pesquisar
            // 
            this.but_pesquisar.Location = new System.Drawing.Point(6, 323);
            this.but_pesquisar.Name = "but_pesquisar";
            this.but_pesquisar.Size = new System.Drawing.Size(88, 51);
            this.but_pesquisar.TabIndex = 43;
            this.but_pesquisar.Text = "Pesquisar";
            this.but_pesquisar.UseVisualStyleBackColor = true;
            this.but_pesquisar.Click += new System.EventHandler(this.but_pesquisar_Click);
            // 
            // cod_p
            // 
            this.cod_p.AutoSize = true;
            this.cod_p.Location = new System.Drawing.Point(10, 35);
            this.cod_p.Name = "cod_p";
            this.cod_p.Size = new System.Drawing.Size(110, 17);
            this.cod_p.TabIndex = 42;
            this.cod_p.Text = "Codigo Produto:";
            // 
            // caixa_cod_p
            // 
            this.caixa_cod_p.Location = new System.Drawing.Point(142, 32);
            this.caixa_cod_p.Name = "caixa_cod_p";
            this.caixa_cod_p.ReadOnly = true;
            this.caixa_cod_p.Size = new System.Drawing.Size(100, 23);
            this.caixa_cod_p.TabIndex = 41;
            // 
            // but_promocao
            // 
            this.but_promocao.Location = new System.Drawing.Point(142, 144);
            this.but_promocao.Name = "but_promocao";
            this.but_promocao.Size = new System.Drawing.Size(181, 26);
            this.but_promocao.TabIndex = 40;
            this.but_promocao.Text = "Cadastro Promoção";
            this.but_promocao.UseVisualStyleBackColor = true;
            this.but_promocao.Click += new System.EventHandler(this.but_promocao_Click);
            // 
            // but_alterar
            // 
            this.but_alterar.Enabled = false;
            this.but_alterar.Location = new System.Drawing.Point(195, 319);
            this.but_alterar.Name = "but_alterar";
            this.but_alterar.Size = new System.Drawing.Size(84, 55);
            this.but_alterar.TabIndex = 39;
            this.but_alterar.Text = "Alterar";
            this.but_alterar.UseVisualStyleBackColor = true;
            this.but_alterar.Click += new System.EventHandler(this.but_alterar_Click);
            // 
            // but_deletar
            // 
            this.but_deletar.Enabled = false;
            this.but_deletar.Location = new System.Drawing.Point(285, 319);
            this.but_deletar.Name = "but_deletar";
            this.but_deletar.Size = new System.Drawing.Size(97, 55);
            this.but_deletar.TabIndex = 38;
            this.but_deletar.Text = "Deletar";
            this.but_deletar.UseVisualStyleBackColor = true;
            this.but_deletar.Click += new System.EventHandler(this.but_deletar_Click);
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Location = new System.Drawing.Point(109, 319);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(80, 55);
            this.btn_cadastro.TabIndex = 32;
            this.btn_cadastro.Text = "Cadastrar";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // caixa_descricao
            // 
            this.caixa_descricao.Location = new System.Drawing.Point(142, 205);
            this.caixa_descricao.Name = "caixa_descricao";
            this.caixa_descricao.Size = new System.Drawing.Size(240, 78);
            this.caixa_descricao.TabIndex = 31;
            this.caixa_descricao.Text = "";
            // 
            // LB_descricao
            // 
            this.LB_descricao.AutoSize = true;
            this.LB_descricao.Location = new System.Drawing.Point(10, 208);
            this.LB_descricao.Name = "LB_descricao";
            this.LB_descricao.Size = new System.Drawing.Size(83, 17);
            this.LB_descricao.TabIndex = 30;
            this.LB_descricao.Text = "Descrição : ";
            // 
            // lb_marca
            // 
            this.lb_marca.AutoSize = true;
            this.lb_marca.Location = new System.Drawing.Point(10, 176);
            this.lb_marca.Name = "lb_marca";
            this.lb_marca.Size = new System.Drawing.Size(107, 17);
            this.lb_marca.TabIndex = 29;
            this.lb_marca.Text = "Código Marca : ";
            // 
            // caixa_codmarca
            // 
            this.caixa_codmarca.Location = new System.Drawing.Point(142, 176);
            this.caixa_codmarca.Name = "caixa_codmarca";
            this.caixa_codmarca.Size = new System.Drawing.Size(100, 23);
            this.caixa_codmarca.TabIndex = 28;
            // 
            // lb_preco_promocao
            // 
            this.lb_preco_promocao.AutoSize = true;
            this.lb_preco_promocao.Location = new System.Drawing.Point(10, 147);
            this.lb_preco_promocao.Name = "lb_preco_promocao";
            this.lb_preco_promocao.Size = new System.Drawing.Size(84, 17);
            this.lb_preco_promocao.TabIndex = 26;
            this.lb_preco_promocao.Text = "Promoção : ";
            // 
            // caixa_preco
            // 
            this.caixa_preco.Location = new System.Drawing.Point(142, 111);
            this.caixa_preco.Name = "caixa_preco";
            this.caixa_preco.Size = new System.Drawing.Size(100, 23);
            this.caixa_preco.TabIndex = 25;
            // 
            // lb_preco
            // 
            this.lb_preco.AutoSize = true;
            this.lb_preco.Location = new System.Drawing.Point(10, 117);
            this.lb_preco.Name = "lb_preco";
            this.lb_preco.Size = new System.Drawing.Size(53, 17);
            this.lb_preco.TabIndex = 24;
            this.lb_preco.Text = "Preço :";
            // 
            // caixa_cod_barras
            // 
            this.caixa_cod_barras.Location = new System.Drawing.Point(142, 84);
            this.caixa_cod_barras.Name = "caixa_cod_barras";
            this.caixa_cod_barras.Size = new System.Drawing.Size(100, 23);
            this.caixa_cod_barras.TabIndex = 23;
            // 
            // caixa_nome
            // 
            this.caixa_nome.Location = new System.Drawing.Point(142, 58);
            this.caixa_nome.Name = "caixa_nome";
            this.caixa_nome.Size = new System.Drawing.Size(100, 23);
            this.caixa_nome.TabIndex = 22;
            // 
            // lb_cod
            // 
            this.lb_cod.AutoSize = true;
            this.lb_cod.Location = new System.Drawing.Point(10, 87);
            this.lb_cod.Name = "lb_cod";
            this.lb_cod.Size = new System.Drawing.Size(126, 17);
            this.lb_cod.TabIndex = 21;
            this.lb_cod.Text = "Codigo de Barras :";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(10, 61);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(103, 17);
            this.lb_nome.TabIndex = 20;
            this.lb_nome.Text = "Nome Produto:";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_Sair.Location = new System.Drawing.Point(690, 693);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(114, 40);
            this.btn_Sair.TabIndex = 37;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // dataGrid_Marcas
            // 
            this.dataGrid_Marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Marcas.Location = new System.Drawing.Point(26, 32);
            this.dataGrid_Marcas.Name = "dataGrid_Marcas";
            this.dataGrid_Marcas.Size = new System.Drawing.Size(262, 248);
            this.dataGrid_Marcas.TabIndex = 43;
            this.dataGrid_Marcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Marcas_CellContentClick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.Cadastro);
            this.groupBox2.Controls.Add(this.but_CadastrarMarcas);
            this.groupBox2.Controls.Add(this.lb_CodMarca);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.caixa_nova_marca);
            this.groupBox2.Controls.Add(this.dataGrid_Marcas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox2.Location = new System.Drawing.Point(431, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 565);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro de Marcas";
            // 
            // Cadastro
            // 
            this.Cadastro.Controls.Add(this.but_deletar_marca);
            this.Cadastro.Controls.Add(this.but_alterar_marca);
            this.Cadastro.Controls.Add(this.but_selecionar_marcas);
            this.Cadastro.Controls.Add(this.caixa_alterar_marca);
            this.Cadastro.Controls.Add(this.caixa_cod_marca);
            this.Cadastro.Controls.Add(this.lbl_novo_nome);
            this.Cadastro.Controls.Add(this.label3);
            this.Cadastro.Location = new System.Drawing.Point(6, 371);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(361, 181);
            this.Cadastro.TabIndex = 49;
            this.Cadastro.TabStop = false;
            this.Cadastro.Text = "ALTERAR | DELETAR";
            // 
            // but_deletar_marca
            // 
            this.but_deletar_marca.Location = new System.Drawing.Point(241, 110);
            this.but_deletar_marca.Name = "but_deletar_marca";
            this.but_deletar_marca.Size = new System.Drawing.Size(108, 50);
            this.but_deletar_marca.TabIndex = 6;
            this.but_deletar_marca.Text = "Deletar Marca";
            this.but_deletar_marca.UseVisualStyleBackColor = true;
            this.but_deletar_marca.Click += new System.EventHandler(this.but_deletar_marca_Click);
            // 
            // but_alterar_marca
            // 
            this.but_alterar_marca.Location = new System.Drawing.Point(137, 110);
            this.but_alterar_marca.Name = "but_alterar_marca";
            this.but_alterar_marca.Size = new System.Drawing.Size(98, 50);
            this.but_alterar_marca.TabIndex = 5;
            this.but_alterar_marca.Text = "Alterar Marca";
            this.but_alterar_marca.UseVisualStyleBackColor = true;
            this.but_alterar_marca.Click += new System.EventHandler(this.but_alterar_marca_Click);
            // 
            // but_selecionar_marcas
            // 
            this.but_selecionar_marcas.Location = new System.Drawing.Point(29, 110);
            this.but_selecionar_marcas.Name = "but_selecionar_marcas";
            this.but_selecionar_marcas.Size = new System.Drawing.Size(102, 50);
            this.but_selecionar_marcas.TabIndex = 4;
            this.but_selecionar_marcas.Text = "Selecionar Marca";
            this.but_selecionar_marcas.UseVisualStyleBackColor = true;
            this.but_selecionar_marcas.Click += new System.EventHandler(this.but_selecionar_marcas_Click);
            // 
            // caixa_alterar_marca
            // 
            this.caixa_alterar_marca.Location = new System.Drawing.Point(172, 58);
            this.caixa_alterar_marca.Name = "caixa_alterar_marca";
            this.caixa_alterar_marca.Size = new System.Drawing.Size(154, 23);
            this.caixa_alterar_marca.TabIndex = 3;
            // 
            // caixa_cod_marca
            // 
            this.caixa_cod_marca.Location = new System.Drawing.Point(172, 22);
            this.caixa_cod_marca.Name = "caixa_cod_marca";
            this.caixa_cod_marca.Size = new System.Drawing.Size(154, 23);
            this.caixa_cod_marca.TabIndex = 2;
            // 
            // lbl_novo_nome
            // 
            this.lbl_novo_nome.AutoSize = true;
            this.lbl_novo_nome.Location = new System.Drawing.Point(9, 64);
            this.lbl_novo_nome.Name = "lbl_novo_nome";
            this.lbl_novo_nome.Size = new System.Drawing.Size(90, 17);
            this.lbl_novo_nome.TabIndex = 1;
            this.lbl_novo_nome.Text = "Novo Nome :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código Marca : ";
            // 
            // but_CadastrarMarcas
            // 
            this.but_CadastrarMarcas.Location = new System.Drawing.Point(241, 299);
            this.but_CadastrarMarcas.Name = "but_CadastrarMarcas";
            this.but_CadastrarMarcas.Size = new System.Drawing.Size(105, 55);
            this.but_CadastrarMarcas.TabIndex = 48;
            this.but_CadastrarMarcas.Text = "Cadastrar Marcas";
            this.but_CadastrarMarcas.UseVisualStyleBackColor = true;
            this.but_CadastrarMarcas.Click += new System.EventHandler(this.but_CadastrarMarcas_Click);
            // 
            // lb_CodMarca
            // 
            this.lb_CodMarca.AutoSize = true;
            this.lb_CodMarca.Location = new System.Drawing.Point(124, 337);
            this.lb_CodMarca.Name = "lb_CodMarca";
            this.lb_CodMarca.Size = new System.Drawing.Size(13, 17);
            this.lb_CodMarca.TabIndex = 47;
            this.lb_CodMarca.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Código Gerado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Marcas:";
            // 
            // caixa_nova_marca
            // 
            this.caixa_nova_marca.Location = new System.Drawing.Point(70, 301);
            this.caixa_nova_marca.Name = "caixa_nova_marca";
            this.caixa_nova_marca.Size = new System.Drawing.Size(100, 23);
            this.caixa_nova_marca.TabIndex = 44;
            // 
            // cad_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(816, 745);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Sair);
            this.Name = "cad_Produtos";
            this.Text = "Cadastro Produtos";
            this.Load += new System.EventHandler(this.cad_Produtos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Marcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Cadastro.ResumeLayout(false);
            this.Cadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.RichTextBox caixa_descricao;
        private System.Windows.Forms.Label LB_descricao;
        private System.Windows.Forms.Label lb_marca;
        private System.Windows.Forms.TextBox caixa_codmarca;
        private System.Windows.Forms.Label lb_preco_promocao;
        private System.Windows.Forms.TextBox caixa_preco;
        private System.Windows.Forms.Label lb_preco;
        private System.Windows.Forms.TextBox caixa_cod_barras;
        private System.Windows.Forms.TextBox caixa_nome;
        private System.Windows.Forms.Label lb_cod;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Button but_alterar;
        private System.Windows.Forms.Button but_deletar;
        private System.Windows.Forms.Button but_promocao;
        private System.Windows.Forms.Label cod_p;
        private System.Windows.Forms.TextBox caixa_cod_p;
        private System.Windows.Forms.DataGridView dataGrid_Marcas;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_CodMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox caixa_nova_marca;
        private System.Windows.Forms.Button but_CadastrarMarcas;
        private System.Windows.Forms.Button but_concluir;
        private System.Windows.Forms.Button but_pesquisar;
        private System.Windows.Forms.GroupBox Cadastro;
        private System.Windows.Forms.Button but_deletar_marca;
        private System.Windows.Forms.Button but_alterar_marca;
        private System.Windows.Forms.Button but_selecionar_marcas;
        private System.Windows.Forms.TextBox caixa_alterar_marca;
        private System.Windows.Forms.TextBox caixa_cod_marca;
        private System.Windows.Forms.Label lbl_novo_nome;
        private System.Windows.Forms.Label label3;

    }
}