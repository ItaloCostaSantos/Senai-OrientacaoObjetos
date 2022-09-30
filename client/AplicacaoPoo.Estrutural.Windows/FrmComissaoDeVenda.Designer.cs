namespace AplicacaoPoo.Estrutural.Windows
{
    partial class FrmComissaoDeVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComissaoDeVenda));
            this.lblIdVendedor = new System.Windows.Forms.Label();
            this.btnCalcularComissao = new System.Windows.Forms.Button();
            this.cmbSelecaoPeca = new System.Windows.Forms.ComboBox();
            this.lblSelecaoPeca = new System.Windows.Forms.Label();
            this.txtQuantPeca = new System.Windows.Forms.TextBox();
            this.lblInformaQuantPeca = new System.Windows.Forms.Label();
            this.cmbNomeVendedor = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdVendedor
            // 
            this.lblIdVendedor.AutoSize = true;
            this.lblIdVendedor.Font = new System.Drawing.Font("Arial Black", 13.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdVendedor.ForeColor = System.Drawing.Color.White;
            this.lblIdVendedor.Location = new System.Drawing.Point(154, 19);
            this.lblIdVendedor.Name = "lblIdVendedor";
            this.lblIdVendedor.Size = new System.Drawing.Size(217, 28);
            this.lblIdVendedor.TabIndex = 0;
            this.lblIdVendedor.Text = "Nome do Vendedor";
            // 
            // btnCalcularComissao
            // 
            this.btnCalcularComissao.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCalcularComissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularComissao.Font = new System.Drawing.Font("Arial Black", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularComissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCalcularComissao.Location = new System.Drawing.Point(23, 333);
            this.btnCalcularComissao.Name = "btnCalcularComissao";
            this.btnCalcularComissao.Size = new System.Drawing.Size(109, 49);
            this.btnCalcularComissao.TabIndex = 7;
            this.btnCalcularComissao.Text = "Calcular";
            this.btnCalcularComissao.UseVisualStyleBackColor = false;
            this.btnCalcularComissao.Click += new System.EventHandler(this.btnCalcularComissao_Click);
            // 
            // cmbSelecaoPeca
            // 
            this.cmbSelecaoPeca.FormattingEnabled = true;
            this.cmbSelecaoPeca.Location = new System.Drawing.Point(154, 153);
            this.cmbSelecaoPeca.Name = "cmbSelecaoPeca";
            this.cmbSelecaoPeca.Size = new System.Drawing.Size(263, 25);
            this.cmbSelecaoPeca.TabIndex = 9;
            // 
            // lblSelecaoPeca
            // 
            this.lblSelecaoPeca.AutoSize = true;
            this.lblSelecaoPeca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSelecaoPeca.Location = new System.Drawing.Point(27, 162);
            this.lblSelecaoPeca.Name = "lblSelecaoPeca";
            this.lblSelecaoPeca.Size = new System.Drawing.Size(105, 17);
            this.lblSelecaoPeca.TabIndex = 11;
            this.lblSelecaoPeca.Text = "Selecione a Peça";
            // 
            // txtQuantPeca
            // 
            this.txtQuantPeca.Location = new System.Drawing.Point(154, 240);
            this.txtQuantPeca.Name = "txtQuantPeca";
            this.txtQuantPeca.Size = new System.Drawing.Size(263, 25);
            this.txtQuantPeca.TabIndex = 12;
            // 
            // lblInformaQuantPeca
            // 
            this.lblInformaQuantPeca.AutoSize = true;
            this.lblInformaQuantPeca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInformaQuantPeca.Location = new System.Drawing.Point(15, 240);
            this.lblInformaQuantPeca.Name = "lblInformaQuantPeca";
            this.lblInformaQuantPeca.Size = new System.Drawing.Size(138, 17);
            this.lblInformaQuantPeca.TabIndex = 13;
            this.lblInformaQuantPeca.Text = "Informe a quantidade ";
            // 
            // cmbNomeVendedor
            // 
            this.cmbNomeVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeVendedor.FormattingEnabled = true;
            this.cmbNomeVendedor.Location = new System.Drawing.Point(154, 71);
            this.cmbNomeVendedor.Name = "cmbNomeVendedor";
            this.cmbNomeVendedor.Size = new System.Drawing.Size(263, 25);
            this.cmbNomeVendedor.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FrmComissaoDeVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(448, 396);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbNomeVendedor);
            this.Controls.Add(this.lblInformaQuantPeca);
            this.Controls.Add(this.txtQuantPeca);
            this.Controls.Add(this.lblSelecaoPeca);
            this.Controls.Add(this.cmbSelecaoPeca);
            this.Controls.Add(this.btnCalcularComissao);
            this.Controls.Add(this.lblIdVendedor);
            this.Name = "FrmComissaoDeVenda";
            this.Text = "FrmComissao";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIdVendedor;
        private Button btnCalcularComissao;
        private ComboBox cmbSelecaoPeca;
        private Label lblSelecaoPeca;
        private TextBox txtQuantPeca;
        private Label lblInformaQuantPeca;
        private ComboBox cmbNomeVendedor;
        private PictureBox pictureBox1;
    }
}