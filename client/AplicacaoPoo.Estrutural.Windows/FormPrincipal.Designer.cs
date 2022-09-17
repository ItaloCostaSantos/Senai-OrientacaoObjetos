namespace AplicacaoPoo.Estrutural.Windows
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConversor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConversor
            // 
            this.btnConversor.FlatAppearance.BorderSize = 0;
            this.btnConversor.Location = new System.Drawing.Point(32, 45);
            this.btnConversor.Name = "btnConversor";
            this.btnConversor.Size = new System.Drawing.Size(167, 34);
            this.btnConversor.TabIndex = 0;
            this.btnConversor.Text = "Conversor de dolar";
            this.btnConversor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConversor.UseVisualStyleBackColor = true;
            this.btnConversor.Click += new System.EventHandler(this.btnConversor_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Controle de Venda";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(462, 111);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConversor);
            this.Name = "FormPrincipal";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnConversor;
        private Button button2;
    }
}