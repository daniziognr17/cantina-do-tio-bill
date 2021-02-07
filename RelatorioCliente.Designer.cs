
namespace cantinha_do_tio_bill
{
    partial class RelatorioCliente
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
            this.listview_clientes = new System.Windows.Forms.ListView();
            this.nClientesCadastrados = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nClientesCadastrados);
            this.groupBox1.Controls.Add(this.listview_clientes);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de clientes cadastrados";
            // 
            // listview_clientes
            // 
            this.listview_clientes.FullRowSelect = true;
            this.listview_clientes.GridLines = true;
            this.listview_clientes.HideSelection = false;
            this.listview_clientes.Location = new System.Drawing.Point(7, 29);
            this.listview_clientes.Name = "listview_clientes";
            this.listview_clientes.Size = new System.Drawing.Size(405, 168);
            this.listview_clientes.TabIndex = 0;
            this.listview_clientes.UseCompatibleStateImageBehavior = false;
            this.listview_clientes.View = System.Windows.Forms.View.List;
            // 
            // nClientesCadastrados
            // 
            this.nClientesCadastrados.AutoSize = true;
            this.nClientesCadastrados.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nClientesCadastrados.Location = new System.Drawing.Point(6, 213);
            this.nClientesCadastrados.Name = "nClientesCadastrados";
            this.nClientesCadastrados.Size = new System.Drawing.Size(237, 20);
            this.nClientesCadastrados.TabIndex = 2;
            this.nClientesCadastrados.Text = "Número de quentinhas cadastradas: N";
            // 
            // RelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 287);
            this.Controls.Add(this.groupBox1);
            this.Name = "RelatorioCliente";
            this.Text = "Relatório de clientes";
            this.Load += new System.EventHandler(this.RemoverCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listview_clientes;
        private System.Windows.Forms.Label nClientesCadastrados;
    }
}