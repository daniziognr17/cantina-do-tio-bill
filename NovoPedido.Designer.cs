
namespace cantinha_do_tio_bill
{
    partial class NovoPedido
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
            this.button1 = new System.Windows.Forms.Button();
            this.total_a_pagar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listview_quentinhas = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.total_a_pagar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listview_quentinhas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulário de cadastro de pedidos";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(461, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Fazer pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // total_a_pagar
            // 
            this.total_a_pagar.AutoSize = true;
            this.total_a_pagar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_a_pagar.Location = new System.Drawing.Point(6, 341);
            this.total_a_pagar.Name = "total_a_pagar";
            this.total_a_pagar.Size = new System.Drawing.Size(151, 29);
            this.total_a_pagar.TabIndex = 3;
            this.total_a_pagar.Text = "Valor Total: R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "OBS: Utilize a tecla CTRL para seleciona mais de uma opção";
            // 
            // listview_quentinhas
            // 
            this.listview_quentinhas.FullRowSelect = true;
            this.listview_quentinhas.GridLines = true;
            this.listview_quentinhas.HideSelection = false;
            this.listview_quentinhas.Location = new System.Drawing.Point(10, 56);
            this.listview_quentinhas.Name = "listview_quentinhas";
            this.listview_quentinhas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listview_quentinhas.Size = new System.Drawing.Size(674, 258);
            this.listview_quentinhas.TabIndex = 1;
            this.listview_quentinhas.UseCompatibleStateImageBehavior = false;
            this.listview_quentinhas.View = System.Windows.Forms.View.List;
            this.listview_quentinhas.SelectedIndexChanged += new System.EventHandler(this.listview_quentinhas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quentinhas";
            // 
            // NovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 445);
            this.Controls.Add(this.groupBox1);
            this.Name = "NovoPedido";
            this.Text = "Novo Pedido";
            this.Load += new System.EventHandler(this.NovoPedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listview_quentinhas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label total_a_pagar;
        private System.Windows.Forms.Label label2;
    }
}