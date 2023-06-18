namespace RH_Manager.Windows.Simuladores
{
    partial class frmBeneficioPis
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.txtAnosTrabalhadosCarteiraAssinada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiasTrabalhadosAnoBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerificarDireitoAoPis = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário Base";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBase.Location = new System.Drawing.Point(37, 84);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(158, 43);
            this.txtSalarioBase.TabIndex = 1;
            // 
            // txtAnosTrabalhadosCarteiraAssinada
            // 
            this.txtAnosTrabalhadosCarteiraAssinada.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnosTrabalhadosCarteiraAssinada.Location = new System.Drawing.Point(37, 322);
            this.txtAnosTrabalhadosCarteiraAssinada.Name = "txtAnosTrabalhadosCarteiraAssinada";
            this.txtAnosTrabalhadosCarteiraAssinada.Size = new System.Drawing.Size(158, 43);
            this.txtAnosTrabalhadosCarteiraAssinada.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anos trabalhados de carteira assinada";
            // 
            // txtDiasTrabalhadosAnoBase
            // 
            this.txtDiasTrabalhadosAnoBase.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiasTrabalhadosAnoBase.Location = new System.Drawing.Point(37, 211);
            this.txtDiasTrabalhadosAnoBase.Name = "txtDiasTrabalhadosAnoBase";
            this.txtDiasTrabalhadosAnoBase.Size = new System.Drawing.Size(158, 43);
            this.txtDiasTrabalhadosAnoBase.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dias trabalhados no ano base";
            // 
            // btnVerificarDireitoAoPis
            // 
            this.btnVerificarDireitoAoPis.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarDireitoAoPis.Location = new System.Drawing.Point(37, 412);
            this.btnVerificarDireitoAoPis.Name = "btnVerificarDireitoAoPis";
            this.btnVerificarDireitoAoPis.Size = new System.Drawing.Size(157, 43);
            this.btnVerificarDireitoAoPis.TabIndex = 6;
            this.btnVerificarDireitoAoPis.Text = "VERIFICAR";
            this.btnVerificarDireitoAoPis.UseVisualStyleBackColor = true;
            this.btnVerificarDireitoAoPis.Click += new System.EventHandler(this.btnVerificarDireitoAoPis_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Yellow;
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(292, 365);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(758, 165);
            this.panelResultado.TabIndex = 7;
            this.panelResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(15, 67);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(168, 38);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "lblResultado";
            // 
            // frmBeneficioPis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 542);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnVerificarDireitoAoPis);
            this.Controls.Add(this.txtDiasTrabalhadosAnoBase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnosTrabalhadosCarteiraAssinada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBeneficioPis";
            this.Text = "Benefício PIS";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.TextBox txtAnosTrabalhadosCarteiraAssinada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiasTrabalhadosAnoBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerificarDireitoAoPis;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}