
namespace cantinha_do_tio_bill
{
    partial class RelatorioPedidos
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
            this.listview_pedidos = new System.Windows.Forms.ListView();
            this.nPedidosFeitos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nPedidosFeitos);
            this.groupBox1.Controls.Add(this.listview_pedidos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Todos os pedidos feitos";
            // 
            // listview_pedidos
            // 
            this.listview_pedidos.FullRowSelect = true;
            this.listview_pedidos.GridLines = true;
            this.listview_pedidos.HideSelection = false;
            this.listview_pedidos.Location = new System.Drawing.Point(7, 20);
            this.listview_pedidos.Name = "listview_pedidos";
            this.listview_pedidos.Size = new System.Drawing.Size(517, 182);
            this.listview_pedidos.TabIndex = 0;
            this.listview_pedidos.UseCompatibleStateImageBehavior = false;
            this.listview_pedidos.View = System.Windows.Forms.View.List;
            // 
            // nPedidosFeitos
            // 
            this.nPedidosFeitos.AutoSize = true;
            this.nPedidosFeitos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPedidosFeitos.Location = new System.Drawing.Point(7, 209);
            this.nPedidosFeitos.Name = "nPedidosFeitos";
            this.nPedidosFeitos.Size = new System.Drawing.Size(183, 20);
            this.nPedidosFeitos.TabIndex = 1;
            this.nPedidosFeitos.Text = "Número de pedidos feitos: N";
            // 
            // RelatorioPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 280);
            this.Controls.Add(this.groupBox1);
            this.Name = "RelatorioPedidos";
            this.Text = "Relatório de pedidos";
            this.Load += new System.EventHandler(this.RelatorioPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listview_pedidos;
        private System.Windows.Forms.Label nPedidosFeitos;
    }
}