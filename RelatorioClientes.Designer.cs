
namespace cantinha_do_tio_bill
{
    partial class RelatorioClientes
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
            this.list_box_clientes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // list_box_clientes
            // 
            this.list_box_clientes.FormattingEnabled = true;
            this.list_box_clientes.Location = new System.Drawing.Point(28, 39);
            this.list_box_clientes.Name = "list_box_clientes";
            this.list_box_clientes.Size = new System.Drawing.Size(313, 173);
            this.list_box_clientes.TabIndex = 0;
            this.list_box_clientes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // RelatorioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 325);
            this.Controls.Add(this.list_box_clientes);
            this.Name = "RelatorioClientes";
            this.Text = "RelatorioClientes";
            this.Load += new System.EventHandler(this.RelatorioClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_box_clientes;
    }
}