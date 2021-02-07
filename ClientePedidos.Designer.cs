
namespace cantinha_do_tio_bill
{
    partial class ClientePedidos
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
            this.lista_pedidos_cliente = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lista_pedidos_cliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de pedidos ";
            // 
            // lista_pedidos_cliente
            // 
            this.lista_pedidos_cliente.FormattingEnabled = true;
            this.lista_pedidos_cliente.Location = new System.Drawing.Point(6, 30);
            this.lista_pedidos_cliente.Name = "lista_pedidos_cliente";
            this.lista_pedidos_cliente.Size = new System.Drawing.Size(387, 95);
            this.lista_pedidos_cliente.TabIndex = 0;
            // 
            // ClientePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 244);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientePedidos";
            this.Text = "Pedidos do Cliente";
            this.Load += new System.EventHandler(this.ClientePedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lista_pedidos_cliente;
    }
}