namespace RH_Manager.Windows.Simuladores
{
    partial class frmBeneficioAdicionalNoturno
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
            this.lblHorasTrabalhadas = new System.Windows.Forms.Label();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.txtHorasNoturnas = new System.Windows.Forms.TextBox();
            this.lblHorasNoturnas = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHorasTrabalhadas
            // 
            this.lblHorasTrabalhadas.AutoSize = true;
            this.lblHorasTrabalhadas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabalhadas.Location = new System.Drawing.Point(425, 29);
            this.lblHorasTrabalhadas.Name = "lblHorasTrabalhadas";
            this.lblHorasTrabalhadas.Size = new System.Drawing.Size(230, 30);
            this.lblHorasTrabalhadas.TabIndex = 0;
            this.lblHorasTrabalhadas.Text = "HORAS TRABALHADAS";
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBase.Location = new System.Drawing.Point(61, 127);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(152, 30);
            this.lblSalarioBase.TabIndex = 1;
            this.lblSalarioBase.Text = "SALÁRIO BASE";
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(430, 73);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(225, 35);
            this.txtHorasTrabalhadas.TabIndex = 2;
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBase.Location = new System.Drawing.Point(66, 172);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(225, 35);
            this.txtSalarioBase.TabIndex = 3;
            // 
            // txtHorasNoturnas
            // 
            this.txtHorasNoturnas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasNoturnas.Location = new System.Drawing.Point(66, 73);
            this.txtHorasNoturnas.Name = "txtHorasNoturnas";
            this.txtHorasNoturnas.Size = new System.Drawing.Size(225, 35);
            this.txtHorasNoturnas.TabIndex = 4;
            // 
            // lblHorasNoturnas
            // 
            this.lblHorasNoturnas.AutoSize = true;
            this.lblHorasNoturnas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasNoturnas.ForeColor = System.Drawing.Color.Black;
            this.lblHorasNoturnas.Location = new System.Drawing.Point(61, 29);
            this.lblHorasNoturnas.Name = "lblHorasNoturnas";
            this.lblHorasNoturnas.Size = new System.Drawing.Size(346, 30);
            this.lblHorasNoturnas.TabIndex = 5;
            this.lblHorasNoturnas.Text = "HORAS NOTURNAS TRABALHADAS";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(430, 144);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(225, 63);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "CALCULAR ADICIONAL NOTURNO";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Yellow;
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelResultado.Location = new System.Drawing.Point(121, 296);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(454, 124);
            this.panelResultado.TabIndex = 7;
            this.panelResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(198, 49);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(68, 30);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label1";
            // 
            // frmBeneficioAdicionalNoturno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RH_Manager.Windows.Properties.Resources.horas_noturnas;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblHorasNoturnas);
            this.Controls.Add(this.txtHorasNoturnas);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.lblSalarioBase);
            this.Controls.Add(this.lblHorasTrabalhadas);
            this.Name = "frmBeneficioAdicionalNoturno";
            this.Text = "Adicional Noturno";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHorasTrabalhadas;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.TextBox txtHorasNoturnas;
        private System.Windows.Forms.Label lblHorasNoturnas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}