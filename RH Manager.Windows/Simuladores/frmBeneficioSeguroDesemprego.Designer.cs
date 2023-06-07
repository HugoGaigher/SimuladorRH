namespace RH_Manager.Windows.Simuladores
{
    partial class frmBeneficioSeguroDesemprego
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
            this.cbbQuantidadeDeSolicitacoes = new System.Windows.Forms.ComboBox();
            this.lblQuantidadeDeSolicitacoes = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbQuantidadeDeSolicitacoes
            // 
            this.cbbQuantidadeDeSolicitacoes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQuantidadeDeSolicitacoes.FormattingEnabled = true;
            this.cbbQuantidadeDeSolicitacoes.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbQuantidadeDeSolicitacoes.Location = new System.Drawing.Point(280, 37);
            this.cbbQuantidadeDeSolicitacoes.Name = "cbbQuantidadeDeSolicitacoes";
            this.cbbQuantidadeDeSolicitacoes.Size = new System.Drawing.Size(121, 38);
            this.cbbQuantidadeDeSolicitacoes.TabIndex = 0;
            this.cbbQuantidadeDeSolicitacoes.SelectedIndexChanged += new System.EventHandler(this.cbbQuantidadeDeSolicitacoes_SelectedIndexChanged);
            // 
            // lblQuantidadeDeSolicitacoes
            // 
            this.lblQuantidadeDeSolicitacoes.AutoSize = true;
            this.lblQuantidadeDeSolicitacoes.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeDeSolicitacoes.Location = new System.Drawing.Point(12, 37);
            this.lblQuantidadeDeSolicitacoes.Name = "lblQuantidadeDeSolicitacoes";
            this.lblQuantidadeDeSolicitacoes.Size = new System.Drawing.Size(262, 30);
            this.lblQuantidadeDeSolicitacoes.TabIndex = 1;
            this.lblQuantidadeDeSolicitacoes.Text = "Quantas vezes já solicitou?";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBase.Location = new System.Drawing.Point(154, 112);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(100, 35);
            this.txtSalarioBase.TabIndex = 2;
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBase.Location = new System.Drawing.Point(12, 112);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(136, 30);
            this.lblSalarioBase.TabIndex = 3;
            this.lblSalarioBase.Text = "Salário bruto:";
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.Yellow;
            this.panelResultado.Controls.Add(this.lblResultado);
            this.panelResultado.Location = new System.Drawing.Point(17, 184);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(538, 173);
            this.panelResultado.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(44, 78);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 30);
            this.lblResultado.TabIndex = 5;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(280, 112);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(121, 35);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "VERIFICAR";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // frmBeneficioSeguroDesemprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 369);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.lblSalarioBase);
            this.Controls.Add(this.txtSalarioBase);
            this.Controls.Add(this.lblQuantidadeDeSolicitacoes);
            this.Controls.Add(this.cbbQuantidadeDeSolicitacoes);
            this.Name = "frmBeneficioSeguroDesemprego";
            this.Text = "Seguro Desemprego";
            this.Load += new System.EventHandler(this.frmBeneficioSeguroDesemprego_Load);
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbQuantidadeDeSolicitacoes;
        private System.Windows.Forms.Label lblQuantidadeDeSolicitacoes;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnVerificar;
    }
}