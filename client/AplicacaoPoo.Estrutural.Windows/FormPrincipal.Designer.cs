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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnConversor = new System.Windows.Forms.Button();
            this.btnComissao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConversor
            // 
            this.btnConversor.BackColor = System.Drawing.Color.Transparent;
            this.btnConversor.FlatAppearance.BorderSize = 0;
            this.btnConversor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConversor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnConversor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConversor.Font = new System.Drawing.Font("Arial Black", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConversor.ForeColor = System.Drawing.Color.White;
            this.btnConversor.Image = ((System.Drawing.Image)(resources.GetObject("btnConversor.Image")));
            this.btnConversor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConversor.Location = new System.Drawing.Point(12, 75);
            this.btnConversor.Name = "btnConversor";
            this.btnConversor.Size = new System.Drawing.Size(228, 60);
            this.btnConversor.TabIndex = 0;
            this.btnConversor.Text = "     Converter Dólar";
            this.btnConversor.UseVisualStyleBackColor = false;
            this.btnConversor.Click += new System.EventHandler(this.btnConversor_Click);
            // 
            // btnComissao
            // 
            this.btnComissao.BackColor = System.Drawing.Color.Transparent;
            this.btnComissao.FlatAppearance.BorderSize = 0;
            this.btnComissao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnComissao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnComissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComissao.Font = new System.Drawing.Font("Arial Black", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComissao.ForeColor = System.Drawing.Color.White;
            this.btnComissao.Image = ((System.Drawing.Image)(resources.GetObject("btnComissao.Image")));
            this.btnComissao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComissao.Location = new System.Drawing.Point(273, 75);
            this.btnComissao.Name = "btnComissao";
            this.btnComissao.Size = new System.Drawing.Size(228, 60);
            this.btnComissao.TabIndex = 1;
            this.btnComissao.Text = "Comissão de Venda";
            this.btnComissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComissao.UseVisualStyleBackColor = false;
            this.btnComissao.Click += new System.EventHandler(this.btnComissao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Black", 14.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "                      Escolha um serviço                    ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(532, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComissao);
            this.Controls.Add(this.btnConversor);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.Text = "Serviços";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConversor;
        private Button btnComissao;
        private Label label1;
    }
}