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
            this.txtValorEmDolar = new System.Windows.Forms.TextBox();
            this.lblPrimeiroValor = new System.Windows.Forms.Label();
            this.lblSegundoValor = new System.Windows.Forms.Label();
            this.cmbMoedas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtValorEmDolar
            // 
            this.txtValorEmDolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValorEmDolar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorEmDolar.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorEmDolar.ForeColor = System.Drawing.Color.Gray;
            this.txtValorEmDolar.Location = new System.Drawing.Point(21, 104);
            this.txtValorEmDolar.Name = "txtValorEmDolar";
            this.txtValorEmDolar.PlaceholderText = "informe o valor";
            this.txtValorEmDolar.Size = new System.Drawing.Size(150, 19);
            this.txtValorEmDolar.TabIndex = 3;
            this.txtValorEmDolar.TextChanged += new System.EventHandler(this.txtValorEmDolar_TextChanged);
            // 
            // lblPrimeiroValor
            // 
            this.lblPrimeiroValor.AutoSize = true;
            this.lblPrimeiroValor.ForeColor = System.Drawing.Color.White;
            this.lblPrimeiroValor.Location = new System.Drawing.Point(21, 22);
            this.lblPrimeiroValor.Name = "lblPrimeiroValor";
            this.lblPrimeiroValor.Size = new System.Drawing.Size(0, 15);
            this.lblPrimeiroValor.TabIndex = 5;
            // 
            // lblSegundoValor
            // 
            this.lblSegundoValor.AutoSize = true;
            this.lblSegundoValor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegundoValor.ForeColor = System.Drawing.Color.White;
            this.lblSegundoValor.Location = new System.Drawing.Point(18, 52);
            this.lblSegundoValor.Name = "lblSegundoValor";
            this.lblSegundoValor.Size = new System.Drawing.Size(0, 30);
            this.lblSegundoValor.TabIndex = 6;
            // 
            // cmbMoedas
            // 
            this.cmbMoedas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbMoedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoedas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMoedas.ForeColor = System.Drawing.Color.Yellow;
            this.cmbMoedas.FormattingEnabled = true;
            this.cmbMoedas.Location = new System.Drawing.Point(210, 104);
            this.cmbMoedas.Name = "cmbMoedas";
            this.cmbMoedas.Size = new System.Drawing.Size(121, 23);
            this.cmbMoedas.TabIndex = 7;
            this.cmbMoedas.SelectedIndexChanged += new System.EventHandler(this.cmbMoedas_SelectedIndexChanged);
            //this.cmbMoedas.SelectedValueChanged += new System.EventHandler(this.cmbMoedas_SelectedValueChanged);
            // 
            // frmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(362, 183);
            this.Controls.Add(this.cmbMoedas);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.lblPrimeiroValor);
            this.Controls.Add(this.txtValorEmDolar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Name = "frmCotacaoDolar";
            this.Text = "CotacaoDolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtValorEmDolar;
        private Label lblPrimeiroValor;
        private Label lblSegundoValor;
        private ComboBox cmbMoedas;
    }
}