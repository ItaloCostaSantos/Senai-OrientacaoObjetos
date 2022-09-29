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
            this.txtIdVendedor = new System.Windows.Forms.TextBox();
            this.lblCodigoPeca = new System.Windows.Forms.Label();
            this.txtCodigoPeca = new System.Windows.Forms.TextBox();
            this.txtPrecoUnitPeca = new System.Windows.Forms.TextBox();
            this.lblPrecoUnitPeca = new System.Windows.Forms.Label();
            this.gbxPeca = new System.Windows.Forms.GroupBox();
            this.txtQuantVendaPeca = new System.Windows.Forms.TextBox();
            this.lblQuantVendaPeca = new System.Windows.Forms.Label();
            this.btnCalcularComissao = new System.Windows.Forms.Button();
            this.lblValorComissao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxPeca.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdVendedor
            // 
            this.lblIdVendedor.AutoSize = true;
            this.lblIdVendedor.Font = new System.Drawing.Font("Arial Black", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdVendedor.ForeColor = System.Drawing.Color.White;
            this.lblIdVendedor.Location = new System.Drawing.Point(12, 13);
            this.lblIdVendedor.Name = "lblIdVendedor";
            this.lblIdVendedor.Size = new System.Drawing.Size(123, 19);
            this.lblIdVendedor.TabIndex = 0;
            this.lblIdVendedor.Text = "ID do Vendedor";
            // 
            // txtIdVendedor
            // 
            this.txtIdVendedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdVendedor.Location = new System.Drawing.Point(154, 11);
            this.txtIdVendedor.Name = "txtIdVendedor";
            this.txtIdVendedor.Size = new System.Drawing.Size(280, 23);
            this.txtIdVendedor.TabIndex = 1;
            // 
            // lblCodigoPeca
            // 
            this.lblCodigoPeca.AutoSize = true;
            this.lblCodigoPeca.Font = new System.Drawing.Font("Arial Black", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoPeca.ForeColor = System.Drawing.Color.White;
            this.lblCodigoPeca.Location = new System.Drawing.Point(6, 34);
            this.lblCodigoPeca.Name = "lblCodigoPeca";
            this.lblCodigoPeca.Size = new System.Drawing.Size(61, 19);
            this.lblCodigoPeca.TabIndex = 2;
            this.lblCodigoPeca.Text = "Código";
            // 
            // txtCodigoPeca
            // 
            this.txtCodigoPeca.Location = new System.Drawing.Point(207, 32);
            this.txtCodigoPeca.Name = "txtCodigoPeca";
            this.txtCodigoPeca.Size = new System.Drawing.Size(200, 27);
            this.txtCodigoPeca.TabIndex = 3;
            // 
            // txtPrecoUnitPeca
            // 
            this.txtPrecoUnitPeca.Location = new System.Drawing.Point(207, 71);
            this.txtPrecoUnitPeca.Name = "txtPrecoUnitPeca";
            this.txtPrecoUnitPeca.Size = new System.Drawing.Size(200, 27);
            this.txtPrecoUnitPeca.TabIndex = 5;
            this.txtPrecoUnitPeca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoUnitPeca_KeyPress);
            // 
            // lblPrecoUnitPeca
            // 
            this.lblPrecoUnitPeca.AutoSize = true;
            this.lblPrecoUnitPeca.Font = new System.Drawing.Font("Arial Black", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecoUnitPeca.ForeColor = System.Drawing.Color.White;
            this.lblPrecoUnitPeca.Location = new System.Drawing.Point(6, 74);
            this.lblPrecoUnitPeca.Name = "lblPrecoUnitPeca";
            this.lblPrecoUnitPeca.Size = new System.Drawing.Size(140, 19);
            this.lblPrecoUnitPeca.TabIndex = 4;
            this.lblPrecoUnitPeca.Text = "Preço unitário R$";
            // 
            // gbxPeca
            // 
            this.gbxPeca.Controls.Add(this.txtQuantVendaPeca);
            this.gbxPeca.Controls.Add(this.lblQuantVendaPeca);
            this.gbxPeca.Controls.Add(this.lblCodigoPeca);
            this.gbxPeca.Controls.Add(this.txtPrecoUnitPeca);
            this.gbxPeca.Controls.Add(this.txtCodigoPeca);
            this.gbxPeca.Controls.Add(this.lblPrecoUnitPeca);
            this.gbxPeca.Font = new System.Drawing.Font("Arial Black", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxPeca.ForeColor = System.Drawing.Color.White;
            this.gbxPeca.Location = new System.Drawing.Point(12, 55);
            this.gbxPeca.Name = "gbxPeca";
            this.gbxPeca.Size = new System.Drawing.Size(422, 154);
            this.gbxPeca.TabIndex = 6;
            this.gbxPeca.TabStop = false;
            this.gbxPeca.Text = "Peças";
            // 
            // txtQuantVendaPeca
            // 
            this.txtQuantVendaPeca.Location = new System.Drawing.Point(207, 112);
            this.txtQuantVendaPeca.Name = "txtQuantVendaPeca";
            this.txtQuantVendaPeca.Size = new System.Drawing.Size(200, 27);
            this.txtQuantVendaPeca.TabIndex = 7;
            // 
            // lblQuantVendaPeca
            // 
            this.lblQuantVendaPeca.AutoSize = true;
            this.lblQuantVendaPeca.Font = new System.Drawing.Font("Arial Black", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuantVendaPeca.ForeColor = System.Drawing.Color.White;
            this.lblQuantVendaPeca.Location = new System.Drawing.Point(6, 115);
            this.lblQuantVendaPeca.Name = "lblQuantVendaPeca";
            this.lblQuantVendaPeca.Size = new System.Drawing.Size(160, 19);
            this.lblQuantVendaPeca.TabIndex = 6;
            this.lblQuantVendaPeca.Text = "Quantidade Vendida";
            // 
            // btnCalcularComissao
            // 
            this.btnCalcularComissao.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCalcularComissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularComissao.Font = new System.Drawing.Font("Arial Black", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularComissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCalcularComissao.Location = new System.Drawing.Point(12, 228);
            this.btnCalcularComissao.Name = "btnCalcularComissao";
            this.btnCalcularComissao.Size = new System.Drawing.Size(109, 34);
            this.btnCalcularComissao.TabIndex = 7;
            this.btnCalcularComissao.Text = "Calcular";
            this.btnCalcularComissao.UseVisualStyleBackColor = false;
            this.btnCalcularComissao.Click += new System.EventHandler(this.btnCalcularComissao_Click);
            // 
            // lblValorComissao
            // 
            this.lblValorComissao.AutoSize = true;
            this.lblValorComissao.Font = new System.Drawing.Font("Arial Black", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorComissao.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblValorComissao.Location = new System.Drawing.Point(320, 235);
            this.lblValorComissao.Name = "lblValorComissao";
            this.lblValorComissao.Size = new System.Drawing.Size(0, 19);
            this.lblValorComissao.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(160, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Valor da comissão:";
            // 
            // FrmComissaoDeVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(448, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValorComissao);
            this.Controls.Add(this.btnCalcularComissao);
            this.Controls.Add(this.gbxPeca);
            this.Controls.Add(this.txtIdVendedor);
            this.Controls.Add(this.lblIdVendedor);
            this.Name = "FrmComissaoDeVenda";
            this.Text = "FrmComissao";
            this.gbxPeca.ResumeLayout(false);
            this.gbxPeca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIdVendedor;
        private TextBox txtIdVendedor;
        private Label lblCodigoPeca;
        private TextBox txtCodigoPeca;
        private TextBox txtPrecoUnitPeca;
        private Label lblPrecoUnitPeca;
        private GroupBox gbxPeca;
        private TextBox txtQuantVendaPeca;
        private Label lblQuantVendaPeca;
        private Button btnCalcularComissao;
        private Label lblValorComissao;
        private Label label1;
    }
}