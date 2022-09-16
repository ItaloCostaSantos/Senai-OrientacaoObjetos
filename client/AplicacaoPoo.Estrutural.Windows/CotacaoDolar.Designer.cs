namespace AplicacaoPoo.Estrutural.Windows
{
    partial class CotacaoDolar
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
            this.lblValorAtual = new System.Windows.Forms.Label();
            this.txtValorAtual = new System.Windows.Forms.TextBox();
            this.lblValorDolar = new System.Windows.Forms.Label();
            this.txtValorEmDolar = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorAtual
            // 
            this.lblValorAtual.AutoSize = true;
            this.lblValorAtual.Location = new System.Drawing.Point(22, 9);
            this.lblValorAtual.Name = "lblValorAtual";
            this.lblValorAtual.Size = new System.Drawing.Size(164, 15);
            this.lblValorAtual.TabIndex = 0;
            this.lblValorAtual.Text = "Informe o valor do dolar atual";
            // 
            // txtValorAtual
            // 
            this.txtValorAtual.Location = new System.Drawing.Point(22, 38);
            this.txtValorAtual.Name = "txtValorAtual";
            this.txtValorAtual.Size = new System.Drawing.Size(164, 23);
            this.txtValorAtual.TabIndex = 1;
            // 
            // lblValorDolar
            // 
            this.lblValorDolar.AutoSize = true;
            this.lblValorDolar.Location = new System.Drawing.Point(22, 81);
            this.lblValorDolar.Name = "lblValorDolar";
            this.lblValorDolar.Size = new System.Drawing.Size(83, 15);
            this.lblValorDolar.TabIndex = 2;
            this.lblValorDolar.Text = "Valor em dolar";
            // 
            // txtValorEmDolar
            // 
            this.txtValorEmDolar.Location = new System.Drawing.Point(22, 118);
            this.txtValorEmDolar.Name = "txtValorEmDolar";
            this.txtValorEmDolar.Size = new System.Drawing.Size(164, 23);
            this.txtValorEmDolar.TabIndex = 3;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(22, 171);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(83, 34);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            // 
            // CotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 227);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtValorEmDolar);
            this.Controls.Add(this.lblValorDolar);
            this.Controls.Add(this.txtValorAtual);
            this.Controls.Add(this.lblValorAtual);
            this.Name = "CotacaoDolar";
            this.Text = "CotacaoDolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblValorAtual;
        private TextBox txtValorAtual;
        private Label lblValorDolar;
        private TextBox txtValorEmDolar;
        private Button btnConverter;
    }
}