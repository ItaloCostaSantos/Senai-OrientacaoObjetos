namespace AplicacaoPoo.Windows
{
    partial class frmCliente
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtValorDebito = new System.Windows.Forms.TextBox();
            this.txtValorCredito = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblValorDebito = new System.Windows.Forms.Label();
            this.lblValorCredito = new System.Windows.Forms.Label();
            this.lblSaldoInicial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(28, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 0;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(28, 117);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 23);
            this.txtCPF.TabIndex = 1;
            // 
            // txtValorDebito
            // 
            this.txtValorDebito.Location = new System.Drawing.Point(28, 199);
            this.txtValorDebito.Name = "txtValorDebito";
            this.txtValorDebito.Size = new System.Drawing.Size(100, 23);
            this.txtValorDebito.TabIndex = 2;
            // 
            // txtValorCredito
            // 
            this.txtValorCredito.Location = new System.Drawing.Point(28, 287);
            this.txtValorCredito.Name = "txtValorCredito";
            this.txtValorCredito.Size = new System.Drawing.Size(100, 23);
            this.txtValorCredito.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(28, 88);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(28, 15);
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "CPF";
            // 
            // lblValorDebito
            // 
            this.lblValorDebito.AutoSize = true;
            this.lblValorDebito.Location = new System.Drawing.Point(28, 163);
            this.lblValorDebito.Name = "lblValorDebito";
            this.lblValorDebito.Size = new System.Drawing.Size(86, 15);
            this.lblValorDebito.TabIndex = 6;
            this.lblValorDebito.Text = "Valor de debito";
            // 
            // lblValorCredito
            // 
            this.lblValorCredito.AutoSize = true;
            this.lblValorCredito.Location = new System.Drawing.Point(28, 247);
            this.lblValorCredito.Name = "lblValorCredito";
            this.lblValorCredito.Size = new System.Drawing.Size(89, 15);
            this.lblValorCredito.TabIndex = 7;
            this.lblValorCredito.Text = "Valor de credito";
            // 
            // lblSaldoInicial
            // 
            this.lblSaldoInicial.AutoSize = true;
            this.lblSaldoInicial.Location = new System.Drawing.Point(306, 44);
            this.lblSaldoInicial.Name = "lblSaldoInicial";
            this.lblSaldoInicial.Size = new System.Drawing.Size(70, 15);
            this.lblSaldoInicial.TabIndex = 8;
            this.lblSaldoInicial.Text = "Saldo Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(306, 120);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(36, 15);
            this.lblSaldo.TabIndex = 10;
            this.lblSaldo.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(264, 291);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 390);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaldoInicial);
            this.Controls.Add(this.lblValorCredito);
            this.Controls.Add(this.lblValorDebito);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtValorCredito);
            this.Controls.Add(this.txtValorDebito);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtValorDebito;
        private TextBox txtValorCredito;
        private Label lblNome;
        private Label lblCPF;
        private Label lblValorDebito;
        private Label lblValorCredito;
        private Label lblSaldoInicial;
        private Label label2;
        private Label lblSaldo;
        private Label label4;
        private Button btnCalcular;
    }
}