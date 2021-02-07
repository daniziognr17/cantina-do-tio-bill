
namespace cantinha_do_tio_bill
{
    partial class NovoCliente
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
            this.salvar_cliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endereco_cliente = new System.Windows.Forms.TextBox();
            this.cpf_cnpj_cliente = new System.Windows.Forms.TextBox();
            this.telefone_cliente = new System.Windows.Forms.TextBox();
            this.nome_cliente = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salvar_cliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.endereco_cliente);
            this.groupBox1.Controls.Add(this.cpf_cnpj_cliente);
            this.groupBox1.Controls.Add(this.telefone_cliente);
            this.groupBox1.Controls.Add(this.nome_cliente);
            this.groupBox1.Location = new System.Drawing.Point(13, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulário de Cadastro de Clientes";
            // 
            // salvar_cliente
            // 
            this.salvar_cliente.Location = new System.Drawing.Point(6, 176);
            this.salvar_cliente.Name = "salvar_cliente";
            this.salvar_cliente.Size = new System.Drawing.Size(103, 33);
            this.salvar_cliente.TabIndex = 8;
            this.salvar_cliente.Text = "Salvar";
            this.salvar_cliente.UseVisualStyleBackColor = true;
            this.salvar_cliente.Click += new System.EventHandler(this.salvar_cliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF / CNPJ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // endereco_cliente
            // 
            this.endereco_cliente.Location = new System.Drawing.Point(6, 134);
            this.endereco_cliente.Name = "endereco_cliente";
            this.endereco_cliente.Size = new System.Drawing.Size(338, 20);
            this.endereco_cliente.TabIndex = 3;
            // 
            // cpf_cnpj_cliente
            // 
            this.cpf_cnpj_cliente.Location = new System.Drawing.Point(186, 84);
            this.cpf_cnpj_cliente.Name = "cpf_cnpj_cliente";
            this.cpf_cnpj_cliente.Size = new System.Drawing.Size(153, 20);
            this.cpf_cnpj_cliente.TabIndex = 2;
            // 
            // telefone_cliente
            // 
            this.telefone_cliente.Location = new System.Drawing.Point(6, 84);
            this.telefone_cliente.Name = "telefone_cliente";
            this.telefone_cliente.Size = new System.Drawing.Size(157, 20);
            this.telefone_cliente.TabIndex = 1;
            // 
            // nome_cliente
            // 
            this.nome_cliente.Location = new System.Drawing.Point(6, 36);
            this.nome_cliente.Name = "nome_cliente";
            this.nome_cliente.Size = new System.Drawing.Size(338, 20);
            this.nome_cliente.TabIndex = 0;
            // 
            // NovoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 266);
            this.Controls.Add(this.groupBox1);
            this.Name = "NovoCliente";
            this.Text = "Novo Cliente";
            this.Load += new System.EventHandler(this.NovoCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox endereco_cliente;
        private System.Windows.Forms.TextBox cpf_cnpj_cliente;
        private System.Windows.Forms.TextBox telefone_cliente;
        private System.Windows.Forms.TextBox nome_cliente;
        private System.Windows.Forms.Button salvar_cliente;
        private System.Windows.Forms.Label label4;
    }
}