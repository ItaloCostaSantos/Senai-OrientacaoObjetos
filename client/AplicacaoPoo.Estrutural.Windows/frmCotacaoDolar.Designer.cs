namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmCotacaoDolar
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
            this.lblValorAtual.Font = new System.Drawing.Font("Arial Black", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorAtual.ForeColor = System.Drawing.Color.White;
            this.lblValorAtual.Location = new System.Drawing.Point(22, 10);
            this.lblValorAtual.Name = "lblValorAtual";
            this.lblValorAtual.Size = new System.Drawing.Size(181, 22);
            this.lblValorAtual.TabIndex = 0;
            this.lblValorAtual.Text = "Valor do dolar atual?";
            // 
            // txtValorAtual
            // 
            this.txtValorAtual.Location = new System.Drawing.Point(22, 43);
            this.txtValorAtual.Name = "txtValorAtual";
            this.txtValorAtual.Size = new System.Drawing.Size(164, 25);
            this.txtValorAtual.TabIndex = 1;
            this.txtValorAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorAtual_KeyPress);
            // 
            // lblValorDolar
            // 
            this.lblValorDolar.AutoSize = true;
            this.lblValorDolar.Font = new System.Drawing.Font("Arial Black", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorDolar.ForeColor = System.Drawing.Color.White;
            this.lblValorDolar.Location = new System.Drawing.Point(22, 92);
            this.lblValorDolar.Name = "lblValorDolar";
            this.lblValorDolar.Size = new System.Drawing.Size(130, 22);
            this.lblValorDolar.TabIndex = 2;
            this.lblValorDolar.Text = "Valor em dolar";
            // 
            // txtValorEmDolar
            // 
            this.txtValorEmDolar.Location = new System.Drawing.Point(22, 134);
            this.txtValorEmDolar.Name = "txtValorEmDolar";
            this.txtValorEmDolar.Size = new System.Drawing.Size(164, 25);
            this.txtValorEmDolar.TabIndex = 3;
            // 
            // btnConverter
            // 
            this.btnConverter.BackColor = System.Drawing.Color.Goldenrod;
            this.btnConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConverter.Font = new System.Drawing.Font("Arial Black", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConverter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnConverter.Location = new System.Drawing.Point(22, 194);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(109, 39);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = false;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // frmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(250, 257);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtValorEmDolar);
            this.Controls.Add(this.lblValorDolar);
            this.Controls.Add(this.txtValorAtual);
            this.Controls.Add(this.lblValorAtual);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Name = "frmCotacaoDolar";
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