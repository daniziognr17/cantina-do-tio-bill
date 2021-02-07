
namespace cantinha_do_tio_bill
{
    partial class RelatorioQuentinhas
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
            this.listview_quentinhas = new System.Windows.Forms.ListView();
            this.nQuentinhasCadastradas = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nQuentinhasCadastradas);
            this.groupBox1.Controls.Add(this.listview_quentinhas);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de quentinhas cadastradas";
            // 
            // listview_quentinhas
            // 
            this.listview_quentinhas.FullRowSelect = true;
            this.listview_quentinhas.GridLines = true;
            this.listview_quentinhas.HideSelection = false;
            this.listview_quentinhas.Location = new System.Drawing.Point(7, 20);
            this.listview_quentinhas.Name = "listview_quentinhas";
            this.listview_quentinhas.Size = new System.Drawing.Size(458, 248);
            this.listview_quentinhas.TabIndex = 0;
            this.listview_quentinhas.UseCompatibleStateImageBehavior = false;
            this.listview_quentinhas.View = System.Windows.Forms.View.List;
            // 
            // nQuentinhasCadastradas
            // 
            this.nQuentinhasCadastradas.AutoSize = true;
            this.nQuentinhasCadastradas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nQuentinhasCadastradas.Location = new System.Drawing.Point(6, 287);
            this.nQuentinhasCadastradas.Name = "nQuentinhasCadastradas";
            this.nQuentinhasCadastradas.Size = new System.Drawing.Size(237, 20);
            this.nQuentinhasCadastradas.TabIndex = 2;
            this.nQuentinhasCadastradas.Text = "Número de quentinhas cadastradas: N";
            // 
            // RelatorioQuentinhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 354);
            this.Controls.Add(this.groupBox1);
            this.Name = "RelatorioQuentinhas";
            this.Text = "Relatório de quentinhas";
            this.Load += new System.EventHandler(this.RelatorioQuentinhas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listview_quentinhas;
        private System.Windows.Forms.Label nQuentinhasCadastradas;
    }
}