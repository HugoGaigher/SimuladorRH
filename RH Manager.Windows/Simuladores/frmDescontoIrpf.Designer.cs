namespace RH_Manager.Windows.Simuladores
{
    partial class frmDescontoIrpf
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
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalculaIrpf = new System.Windows.Forms.Button();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.BackColor = System.Drawing.Color.Transparent;
            this.lblSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalarioBase.Location = new System.Drawing.Point(23, 42);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(164, 25);
            this.lblSalarioBase.TabIndex = 0;
            this.lblSalarioBase.Text = "SALÁRIO BASE";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBase.Location = new System.Drawing.Point(28, 87);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(159, 31);
            this.txtSalarioBase.TabIndex = 1;
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Yellow;
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(28, 226);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(445, 100);
            this.panelResultado.TabIndex = 2;
            this.panelResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(177, 37);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(70, 25);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label1";
            // 
            // btnCalculaIrpf
            // 
            this.btnCalculaIrpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculaIrpf.Location = new System.Drawing.Point(28, 141);
            this.btnCalculaIrpf.Name = "btnCalculaIrpf";
            this.btnCalculaIrpf.Size = new System.Drawing.Size(159, 48);
            this.btnCalculaIrpf.TabIndex = 3;
            this.btnCalculaIrpf.Text = "CALCULAR IRPF";
            this.btnCalculaIrpf.UseVisualStyleBackColor = true;
            this.btnCalculaIrpf.Click += new System.EventHandler(this.btnCalculaIrpf_Click);
            // 
            // frmDescontoIrpf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RH_Manager.Windows.Properties.Resources.irpf;
            this.ClientSize = new System.Drawing.Size(498, 340);
            this.Controls.Add(this.btnCalculaIrpf);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.lblSalarioBase);
            this.MaximizeBox = false;
            this.Name = "frmDescontoIrpf";
            this.Text = "Imposto de Renda";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalculaIrpf;
    }
}