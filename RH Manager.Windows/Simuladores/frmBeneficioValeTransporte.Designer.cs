namespace RH_Manager.Windows.Simuladores
{
    partial class frmBeneficioValeTransporte
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
            this.btnCalculaDescontoValeTransporte = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblUsoMensalDoTransporte = new System.Windows.Forms.Label();
            this.txtUsoMensalDoTransporte = new System.Windows.Forms.TextBox();
            this.txtValorDaPassagem = new System.Windows.Forms.TextBox();
            this.lblValorDaPassagem = new System.Windows.Forms.Label();
            this.lblCustoBeneficio = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.BackColor = System.Drawing.Color.White;
            this.lblSalarioBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBase.Location = new System.Drawing.Point(12, 9);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(113, 21);
            this.lblSalarioBase.TabIndex = 0;
            this.lblSalarioBase.Text = "SALÁRIO BASE";
            this.lblSalarioBase.Click += new System.EventHandler(this.lblValeTransporte_Click);
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBase.Location = new System.Drawing.Point(16, 33);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(159, 29);
            this.txtSalarioBase.TabIndex = 1;
            // 
            // btnCalculaDescontoValeTransporte
            // 
            this.btnCalculaDescontoValeTransporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculaDescontoValeTransporte.Location = new System.Drawing.Point(313, 95);
            this.btnCalculaDescontoValeTransporte.Name = "btnCalculaDescontoValeTransporte";
            this.btnCalculaDescontoValeTransporte.Size = new System.Drawing.Size(217, 56);
            this.btnCalculaDescontoValeTransporte.TabIndex = 2;
            this.btnCalculaDescontoValeTransporte.Text = "CALCULAR VALE-TRANSPORTE";
            this.btnCalculaDescontoValeTransporte.UseVisualStyleBackColor = true;
            this.btnCalculaDescontoValeTransporte.Click += new System.EventHandler(this.btnCalculaDescontoValeTransporte_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Yellow;
            this.panelResultado.Controls.Add(this.lblCustoBeneficio);
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(33, 195);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(528, 161);
            this.panelResultado.TabIndex = 3;
            this.panelResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(231, 39);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(68, 30);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "label1";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsoMensalDoTransporte
            // 
            this.lblUsoMensalDoTransporte.AutoSize = true;
            this.lblUsoMensalDoTransporte.BackColor = System.Drawing.Color.White;
            this.lblUsoMensalDoTransporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsoMensalDoTransporte.Location = new System.Drawing.Point(12, 98);
            this.lblUsoMensalDoTransporte.Name = "lblUsoMensalDoTransporte";
            this.lblUsoMensalDoTransporte.Size = new System.Drawing.Size(168, 21);
            this.lblUsoMensalDoTransporte.TabIndex = 4;
            this.lblUsoMensalDoTransporte.Text = "USO DO TRANSPORTE";
            // 
            // txtUsoMensalDoTransporte
            // 
            this.txtUsoMensalDoTransporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsoMensalDoTransporte.Location = new System.Drawing.Point(16, 122);
            this.txtUsoMensalDoTransporte.Name = "txtUsoMensalDoTransporte";
            this.txtUsoMensalDoTransporte.Size = new System.Drawing.Size(159, 29);
            this.txtUsoMensalDoTransporte.TabIndex = 5;
            // 
            // txtValorDaPassagem
            // 
            this.txtValorDaPassagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDaPassagem.Location = new System.Drawing.Point(368, 33);
            this.txtValorDaPassagem.Name = "txtValorDaPassagem";
            this.txtValorDaPassagem.Size = new System.Drawing.Size(159, 29);
            this.txtValorDaPassagem.TabIndex = 6;
            // 
            // lblValorDaPassagem
            // 
            this.lblValorDaPassagem.AutoSize = true;
            this.lblValorDaPassagem.BackColor = System.Drawing.Color.White;
            this.lblValorDaPassagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaPassagem.Location = new System.Drawing.Point(364, 9);
            this.lblValorDaPassagem.Name = "lblValorDaPassagem";
            this.lblValorDaPassagem.Size = new System.Drawing.Size(166, 21);
            this.lblValorDaPassagem.TabIndex = 7;
            this.lblValorDaPassagem.Text = "VALOR DA PASSAGEM";
            // 
            // lblCustoBeneficio
            // 
            this.lblCustoBeneficio.AutoSize = true;
            this.lblCustoBeneficio.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustoBeneficio.Location = new System.Drawing.Point(13, 97);
            this.lblCustoBeneficio.Name = "lblCustoBeneficio";
            this.lblCustoBeneficio.Size = new System.Drawing.Size(68, 30);
            this.lblCustoBeneficio.TabIndex = 1;
            this.lblCustoBeneficio.Text = "label1";
            // 
            // frmBeneficioValeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::RH_Manager.Windows.Properties.Resources.vale_transporte;
            this.ClientSize = new System.Drawing.Size(585, 368);
            this.Controls.Add(this.lblValorDaPassagem);
            this.Controls.Add(this.txtValorDaPassagem);
            this.Controls.Add(this.txtUsoMensalDoTransporte);
            this.Controls.Add(this.lblUsoMensalDoTransporte);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalculaDescontoValeTransporte);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.lblSalarioBase);
            this.Name = "frmBeneficioValeTransporte";
            this.Text = "Custo-Benefício do Vale Transporte";
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Button btnCalculaDescontoValeTransporte;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblUsoMensalDoTransporte;
        private System.Windows.Forms.TextBox txtUsoMensalDoTransporte;
        private System.Windows.Forms.TextBox txtValorDaPassagem;
        private System.Windows.Forms.Label lblValorDaPassagem;
        private System.Windows.Forms.Label lblCustoBeneficio;
    }
}