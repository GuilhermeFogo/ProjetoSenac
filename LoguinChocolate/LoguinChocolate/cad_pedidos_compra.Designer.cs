namespace LoguinChocolate
{
    partial class cad_pedidos_compra
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
            this.but_ok = new System.Windows.Forms.Button();
            this.but_sair = new System.Windows.Forms.Button();
            this.but_pesquisa = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.but_concluir = new System.Windows.Forms.Button();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_valor = new System.Windows.Forms.Label();
            this.lb_cod = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lb_datas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(267, 42);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(82, 29);
            this.but_ok.TabIndex = 25;
            this.but_ok.Text = "OK";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Visible = false;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // but_sair
            // 
            this.but_sair.Location = new System.Drawing.Point(494, 315);
            this.but_sair.Name = "but_sair";
            this.but_sair.Size = new System.Drawing.Size(82, 28);
            this.but_sair.TabIndex = 24;
            this.but_sair.Text = "Sair";
            this.but_sair.UseVisualStyleBackColor = true;
            // 
            // but_pesquisa
            // 
            this.but_pesquisa.Location = new System.Drawing.Point(494, 143);
            this.but_pesquisa.Name = "but_pesquisa";
            this.but_pesquisa.Size = new System.Drawing.Size(71, 30);
            this.but_pesquisa.TabIndex = 23;
            this.but_pesquisa.Text = "Pesquisa";
            this.but_pesquisa.UseVisualStyleBackColor = true;
            this.but_pesquisa.Click += new System.EventHandler(this.but_pesquisa_Click);
            // 
            // but_delete
            // 
            this.but_delete.Location = new System.Drawing.Point(490, 91);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(75, 25);
            this.but_delete.TabIndex = 22;
            this.but_delete.Text = "Delete";
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // but_concluir
            // 
            this.but_concluir.Location = new System.Drawing.Point(490, 38);
            this.but_concluir.Name = "but_concluir";
            this.but_concluir.Size = new System.Drawing.Size(76, 28);
            this.but_concluir.TabIndex = 21;
            this.but_concluir.Text = "Concluir";
            this.but_concluir.UseVisualStyleBackColor = true;
            this.but_concluir.Click += new System.EventHandler(this.but_concluir_Click);
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Location = new System.Drawing.Point(14, 160);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(80, 13);
            this.lb_data.TabIndex = 19;
            this.lb_data.Text = "Data do pedido";
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Location = new System.Drawing.Point(57, 97);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(58, 13);
            this.lb_valor.TabIndex = 18;
            this.lb_valor.Text = "Valor Total";
            // 
            // lb_cod
            // 
            this.lb_cod.AutoSize = true;
            this.lb_cod.Location = new System.Drawing.Point(47, 47);
            this.lb_cod.Name = "lb_cod";
            this.lb_cod.Size = new System.Drawing.Size(82, 13);
            this.lb_cod.TabIndex = 17;
            this.lb_cod.Text = "Codigo Compra:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(135, 97);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 14;
            // 
            // txt_cod
            // 
            this.txt_cod.Enabled = false;
            this.txt_cod.Location = new System.Drawing.Point(135, 47);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 20);
            this.txt_cod.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(308, 154);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // lb_datas
            // 
            this.lb_datas.AutoSize = true;
            this.lb_datas.Location = new System.Drawing.Point(221, 160);
            this.lb_datas.Name = "lb_datas";
            this.lb_datas.Size = new System.Drawing.Size(81, 13);
            this.lb_datas.TabIndex = 27;
            this.lb_datas.Text = "Datas Chegada";
            // 
            // cad_pedidos_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 380);
            this.Controls.Add(this.lb_datas);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.but_sair);
            this.Controls.Add(this.but_pesquisa);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_concluir);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.lb_valor);
            this.Controls.Add(this.lb_cod);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_cod);
            this.Name = "cad_pedidos_compra";
            this.Text = "cad_pedidos_compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.Button but_sair;
        private System.Windows.Forms.Button but_pesquisa;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Button but_concluir;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.Label lb_cod;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lb_datas;
    }
}