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
            this.txtHorasExtras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBase.Location = new System.Drawing.Point(47, 16);
            this.lblSalarioBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(159, 37);
            this.lblSalarioBase.TabIndex = 0;
            this.lblSalarioBase.Text = "Salário Base";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBase.Location = new System.Drawing.Point(53, 57);
            this.txtSalarioBase.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(157, 42);
            this.txtSalarioBase.TabIndex = 1;
            // 
            // txtTaxaHoraExtra
            // 
            this.txtTaxaHoraExtra.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxaHoraExtra.Location = new System.Drawing.Point(53, 158);
            this.txtTaxaHoraExtra.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaxaHoraExtra.Name = "txtTaxaHoraExtra";
            this.txtTaxaHoraExtra.Size = new System.Drawing.Size(157, 42);
            this.txtTaxaHoraExtra.TabIndex = 3;
            // 
            // lblTaxaHoraExtra
            // 
            this.lblTaxaHoraExtra.AutoSize = true;
            this.lblTaxaHoraExtra.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxaHoraExtra.Location = new System.Drawing.Point(47, 117);
            this.lblTaxaHoraExtra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxaHoraExtra.Name = "lblTaxaHoraExtra";
            this.lblTaxaHoraExtra.Size = new System.Drawing.Size(235, 37);
            this.lblTaxaHoraExtra.TabIndex = 2;
            this.lblTaxaHoraExtra.Text = "Taxa de Hora Extra";
            // 
            // txtHorasTrabalhadas
            // 
            this.txtHorasTrabalhadas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasTrabalhadas.Location = new System.Drawing.Point(325, 57);
            this.txtHorasTrabalhadas.Margin = new System.Windows.Forms.Padding(4);
            this.txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            this.txtHorasTrabalhadas.Size = new System.Drawing.Size(157, 42);
            this.txtHorasTrabalhadas.TabIndex = 5;
            // 
            // lblHorasTrabalhadasNoMes
            // 
            this.lblHorasTrabalhadasNoMes.AutoSize = true;
            this.lblHorasTrabalhadasNoMes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabalhadasNoMes.Location = new System.Drawing.Point(319, 16);
            this.lblHorasTrabalhadasNoMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorasTrabalhadasNoMes.Name = "lblHorasTrabalhadasNoMes";
            this.lblHorasTrabalhadasNoMes.Size = new System.Drawing.Size(329, 37);
            this.lblHorasTrabalhadasNoMes.TabIndex = 4;
            this.lblHorasTrabalhadasNoMes.Text = "Horas Trabalhadas no Mês";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(54, 241);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(159, 43);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtHorasExtras
            // 
            this.txtHorasExtras.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasExtras.Location = new System.Drawing.Point(324, 158);
            this.txtHorasExtras.Margin = new System.Windows.Forms.Padding(4);
            this.txtHorasExtras.Name = "txtHorasExtras";
            this.txtHorasExtras.Size = new System.Drawing.Size(157, 42);
            this.txtHorasExtras.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Horas Extras Trabalhadas";
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Yellow;
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(326, 241);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(322, 162);
            this.panelResultado.TabIndex = 10;
            this.panelResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(113, 69);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(91, 38);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label2";
            // 
            // frmBeneficioHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 437);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.txtHorasExtras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtHorasTrabalhadas);
            this.Controls.Add(this.lblHorasTrabalhadasNoMes);
            this.Controls.Add(this.txtTaxaHoraExtra);
            this.Controls.Add(this.lblTaxaHoraExtra);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.lblSalarioBase);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBeneficioHoraExtra";
            this.Text = "Cálculo de Hora Extra";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
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
        private System.Windows.Forms.TextBox txtHorasExtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}