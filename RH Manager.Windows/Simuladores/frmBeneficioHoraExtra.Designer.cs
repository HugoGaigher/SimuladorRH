namespace RH_Manager.Windows.Simuladores
{
    partial class frmBeneficioHoraExtra
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
            this.txtTaxaHoraExtra = new System.Windows.Forms.TextBox();
            this.lblTaxaHoraExtra = new System.Windows.Forms.Label();
            this.txtHorasTrabalhadas = new System.Windows.Forms.TextBox();
            this.lblHorasTrabalhadasNoMes = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBase.Location = new System.Drawing.Point(35, 13);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(124, 30);
            this.lblSalarioBase.TabIndex = 0;
            this.lblSalarioBase.Text = "Salário Base";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBase.Location = new System.Drawing.Point(40, 46);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(119, 35);
            this.txtSalarioBase.TabIndex = 1;
            // 
            // txtTaxaHoraExtra
            // 
            this.txtTaxaHoraExtra.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxaHoraExtra.Location = new System.Drawing.Point(40, 128);
            this.txtTaxaHoraExtra.Name = "txtTaxaHoraExtra";
            this.txtTaxaHoraExtra.Size = new System.Drawing.Size(119, 35);
            this.txtTaxaHoraExtra.TabIndex = 3;
            // 
            // lblTaxaHoraExtra
            // 
            this.lblTaxaHoraExtra.AutoSize = true;
            this.lblTaxaHoraExtra.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxaHoraExtra.Location = new System.Drawing.Point(35, 95);
            this.lblTaxaHoraExtra.Name = "lblTaxaHoraExtra";
            this.lblTaxaHoraExtra.Size = new System.Drawing.Size(186, 30);
            this.lblTaxaHoraExtra.TabIndex = 2;
            this.lblTaxaHoraExtra.Text = "Taxa de Hora Extra";
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(244, 46);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(119, 35);
            this.txtHorasTrabalhadas.TabIndex = 5;
            // 
            // lblHorasTrabalhadasNoMes
            // 
            this.lblHorasTrabalhadasNoMes.AutoSize = true;
            this.lblHorasTrabalhadasNoMes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabalhadasNoMes.Location = new System.Drawing.Point(239, 13);
            this.lblHorasTrabalhadasNoMes.Name = "lblHorasTrabalhadasNoMes";
            this.lblHorasTrabalhadasNoMes.Size = new System.Drawing.Size(258, 30);
            this.lblHorasTrabalhadasNoMes.TabIndex = 4;
            this.lblHorasTrabalhadasNoMes.Text = "Horas Trabalhadas no Mês";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(244, 128);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 35);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmBeneficioHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 355);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.lblHorasTrabalhadasNoMes);
            this.Controls.Add(this.txtTaxaHoraExtra);
            this.Controls.Add(this.lblTaxaHoraExtra);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.lblSalarioBase);
            this.Name = "frmBeneficioHoraExtra";
            this.Text = "Cálculo de Hora Extra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.TextBox txtTaxaHoraExtra;
        private System.Windows.Forms.Label lblTaxaHoraExtra;
        private System.Windows.Forms.TextBox txtHorasTrabalhadas;
        private System.Windows.Forms.Label lblHorasTrabalhadasNoMes;
        private System.Windows.Forms.Button btnCalcular;
    }
}