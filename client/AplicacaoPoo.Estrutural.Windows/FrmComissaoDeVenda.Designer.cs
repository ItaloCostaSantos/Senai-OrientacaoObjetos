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
            this.lblIdVendedor = new System.Windows.Forms.Label();
            this.btnCalcularComissao = new System.Windows.Forms.Button();
            this.cmbSelecaoProduto = new System.Windows.Forms.ComboBox();
            this.lblSelecaoProduto = new System.Windows.Forms.Label();
            this.txtQuantProduto = new System.Windows.Forms.TextBox();
            this.lblInformaQuantPProduto = new System.Windows.Forms.Label();
            this.cmbNomeVendedor = new System.Windows.Forms.ComboBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIdVendedor
            // 
            this.lblIdVendedor.AutoSize = true;
            this.lblIdVendedor.Font = new System.Drawing.Font("Arial Black", 13.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdVendedor.ForeColor = System.Drawing.Color.White;
            this.lblIdVendedor.Location = new System.Drawing.Point(154, 17);
            this.lblIdVendedor.Name = "lblIdVendedor";
            this.lblIdVendedor.Size = new System.Drawing.Size(198, 26);
            this.lblIdVendedor.TabIndex = 0;
            this.lblIdVendedor.Text = "Nome do Vendedor";
            // 
            // btnCalcularComissao
            // 
            this.btnCalcularComissao.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCalcularComissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularComissao.Font = new System.Drawing.Font("Arial Black", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularComissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCalcularComissao.Location = new System.Drawing.Point(12, 331);
            this.btnCalcularComissao.Name = "btnCalcularComissao";
            this.btnCalcularComissao.Size = new System.Drawing.Size(109, 43);
            this.btnCalcularComissao.TabIndex = 7;
            this.btnCalcularComissao.Text = "Calcular";
            this.btnCalcularComissao.UseVisualStyleBackColor = false;
            this.btnCalcularComissao.Click += new System.EventHandler(this.btnCalcularComissao_Click);
            // 
            // cmbSelecaoProduto
            // 
            this.cmbSelecaoProduto.FormattingEnabled = true;
            this.cmbSelecaoProduto.Location = new System.Drawing.Point(154, 135);
            this.cmbSelecaoProduto.Name = "cmbSelecaoProduto";
            this.cmbSelecaoProduto.Size = new System.Drawing.Size(263, 23);
            this.cmbSelecaoProduto.TabIndex = 9;
            this.cmbSelecaoProduto.SelectedValueChanged += new System.EventHandler(this.cmbSelecaoProduto_SelectedValueChanged);
            // 
            // lblSelecaoProduto
            // 
            this.lblSelecaoProduto.AutoSize = true;
            this.lblSelecaoProduto.ForeColor = System.Drawing.Color.White;
            this.lblSelecaoProduto.Location = new System.Drawing.Point(27, 143);
            this.lblSelecaoProduto.Name = "lblSelecaoProduto";
            this.lblSelecaoProduto.Size = new System.Drawing.Size(113, 15);
            this.lblSelecaoProduto.TabIndex = 11;
            this.lblSelecaoProduto.Text = "Selecione o produto";
            // 
            // txtQuantProduto
            // 
            this.txtQuantProduto.Location = new System.Drawing.Point(154, 287);
            this.txtQuantProduto.Name = "txtQuantProduto";
            this.txtQuantProduto.Size = new System.Drawing.Size(263, 23);
            this.txtQuantProduto.TabIndex = 12;
            // 
            // lblInformaQuantPProduto
            // 
            this.lblInformaQuantPProduto.AutoSize = true;
            this.lblInformaQuantPProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInformaQuantPProduto.Location = new System.Drawing.Point(12, 287);
            this.lblInformaQuantPProduto.Name = "lblInformaQuantPProduto";
            this.lblInformaQuantPProduto.Size = new System.Drawing.Size(124, 15);
            this.lblInformaQuantPProduto.TabIndex = 13;
            this.lblInformaQuantPProduto.Text = "Informe a quantidade ";
            // 
            // cmbNomeVendedor
            // 
            this.cmbNomeVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeVendedor.FormattingEnabled = true;
            this.cmbNomeVendedor.Location = new System.Drawing.Point(154, 63);
            this.cmbNomeVendedor.Name = "cmbNomeVendedor";
            this.cmbNomeVendedor.Size = new System.Drawing.Size(263, 23);
            this.cmbNomeVendedor.TabIndex = 14;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(154, 209);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(263, 23);
            this.txtValorUnitario.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Valor unitário";
            // 
            // FrmComissaoDeVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(448, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.cmbNomeVendedor);
            this.Controls.Add(this.lblInformaQuantPProduto);
            this.Controls.Add(this.txtQuantProduto);
            this.Controls.Add(this.lblSelecaoProduto);
            this.Controls.Add(this.cmbSelecaoProduto);
            this.Controls.Add(this.btnCalcularComissao);
            this.Controls.Add(this.lblIdVendedor);
            this.Name = "FrmComissaoDeVenda";
            this.Text = "FrmComissao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIdVendedor;
        private Button btnCalcularComissao;
        private ComboBox cmbSelecaoProduto;
        private Label lblSelecaoProduto;
        private TextBox txtQuantProduto;
        private Label lblInformaQuantPProduto;
        private ComboBox cmbNomeVendedor;
        private TextBox txtValorUnitario;
        private Label label1;
    }
}