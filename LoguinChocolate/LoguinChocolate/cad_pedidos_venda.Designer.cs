namespace LoguinChocolate
{
    partial class cad_pedidos_venda
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
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_descrisao = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_cod = new System.Windows.Forms.Label();
            this.lb_valor = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_descrisao = new System.Windows.Forms.Label();
            this.but_concluir = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_pesquisa = new System.Windows.Forms.Button();
            this.but_sair = new System.Windows.Forms.Button();
            this.but_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_cod
            // 
            this.txt_cod.Enabled = false;
            this.txt_cod.Location = new System.Drawing.Point(122, 36);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 20);
            this.txt_cod.TabIndex = 0;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(122, 86);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 1;
            // 
            // txt_descrisao
            // 
            this.txt_descrisao.Location = new System.Drawing.Point(108, 181);
            this.txt_descrisao.Name = "txt_descrisao";
            this.txt_descrisao.Size = new System.Drawing.Size(167, 60);
            this.txt_descrisao.TabIndex = 2;
            this.txt_descrisao.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 143);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lb_cod
            // 
            this.lb_cod.AutoSize = true;
            this.lb_cod.Location = new System.Drawing.Point(34, 36);
            this.lb_cod.Name = "lb_cod";
            this.lb_cod.Size = new System.Drawing.Size(82, 13);
            this.lb_cod.TabIndex = 4;
            this.lb_cod.Text = "Codigo Compra:";
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Location = new System.Drawing.Point(44, 86);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(58, 13);
            this.lb_valor.TabIndex = 5;
            this.lb_valor.Text = "Valor Total";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Location = new System.Drawing.Point(51, 143);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(30, 13);
            this.lb_data.TabIndex = 6;
            this.lb_data.Text = "Data";
            // 
            // lb_descrisao
            // 
            this.lb_descrisao.AutoSize = true;
            this.lb_descrisao.Location = new System.Drawing.Point(47, 181);
            this.lb_descrisao.Name = "lb_descrisao";
            this.lb_descrisao.Size = new System.Drawing.Size(55, 13);
            this.lb_descrisao.TabIndex = 7;
            this.lb_descrisao.Text = "Descricao";
            // 
            // but_concluir
            // 
            this.but_concluir.Location = new System.Drawing.Point(477, 27);
            this.but_concluir.Name = "but_concluir";
            this.but_concluir.Size = new System.Drawing.Size(76, 28);
            this.but_concluir.TabIndex = 8;
            this.but_concluir.Text = "Concluir";
            this.but_concluir.UseVisualStyleBackColor = true;
            this.but_concluir.Click += new System.EventHandler(this.but_concluir_Click);
            // 
            // but_delete
            // 
            this.but_delete.Location = new System.Drawing.Point(477, 80);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(75, 25);
            this.but_delete.TabIndex = 9;
            this.but_delete.Text = "Delete";
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_pesquisa
            // 
            this.but_pesquisa.Location = new System.Drawing.Point(481, 132);
            this.but_pesquisa.Name = "but_pesquisa";
            this.but_pesquisa.Size = new System.Drawing.Size(71, 30);
            this.but_pesquisa.TabIndex = 10;
            this.but_pesquisa.Text = "Pesquisa";
            this.but_pesquisa.UseVisualStyleBackColor = true;
            this.but_pesquisa.Click += new System.EventHandler(this.but_pesquisa_Click);
            // 
            // but_sair
            // 
            this.but_sair.Location = new System.Drawing.Point(481, 304);
            this.but_sair.Name = "but_sair";
            this.but_sair.Size = new System.Drawing.Size(82, 28);
            this.but_sair.TabIndex = 11;
            this.but_sair.Text = "Sair";
            this.but_sair.UseVisualStyleBackColor = true;
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(254, 31);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(82, 29);
            this.but_ok.TabIndex = 12;
            this.but_ok.Text = "OK";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Visible = false;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // cad_pedidos_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 344);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.but_sair);
            this.Controls.Add(this.but_pesquisa);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_concluir);
            this.Controls.Add(this.lb_descrisao);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.lb_valor);
            this.Controls.Add(this.lb_cod);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_descrisao);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_cod);
            this.Name = "cad_pedidos_venda";
            this.Text = "cad_pedidos_venda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.RichTextBox txt_descrisao;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb_cod;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_descrisao;
        private System.Windows.Forms.Button but_concluir;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_pesquisa;
        private System.Windows.Forms.Button but_sair;
        private System.Windows.Forms.Button but_ok;
    }
}