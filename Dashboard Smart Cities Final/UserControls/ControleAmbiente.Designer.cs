using System;
using System.Windows.Forms;

namespace Dashboard_Smart_Cities_Final.UserControls
{
    partial class ControleAmbiente : UserControl // Ensure ControleAmbiente inherits from UserControl
    {
        private System.Windows.Forms.ComboBox comboBoxAmbientes; // Add the missing field declaration  
        private Button btnEnviar;
        private Button btnToggleLuz;
        private Button btnToggleUmidificador;
        private Label lblStatus;

        #region Código gerado pelo Designer de Componentes  

        private void InitializeComponent()
        {
            this.comboBoxAmbientes = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnToggleLuz = new System.Windows.Forms.Button();
            this.btnToggleUmidificador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAmbientes
            // 
            this.comboBoxAmbientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAmbientes.Items.AddRange(new object[] {
            "QUARTO_1",
            "QUARTO_2",
            "SALA",
            "COZINHA"});
            this.comboBoxAmbientes.Location = new System.Drawing.Point(10, 10);
            this.comboBoxAmbientes.Name = "comboBoxAmbientes";
            this.comboBoxAmbientes.Size = new System.Drawing.Size(150, 24);
            this.comboBoxAmbientes.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(10, 40);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(231, 16);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status: Luz e Umidificador desligados";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(10, 70);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar comando";
            // 
            // btnToggleLuz
            // 
            this.btnToggleLuz.Location = new System.Drawing.Point(10, 100);
            this.btnToggleLuz.Name = "btnToggleLuz";
            this.btnToggleLuz.Size = new System.Drawing.Size(75, 23);
            this.btnToggleLuz.TabIndex = 3;
            this.btnToggleLuz.Text = "Ligar/Desligar Luz";
            // 
            // btnToggleUmidificador
            // 
            this.btnToggleUmidificador.Location = new System.Drawing.Point(10, 130);
            this.btnToggleUmidificador.Name = "btnToggleUmidificador";
            this.btnToggleUmidificador.Size = new System.Drawing.Size(75, 23);
            this.btnToggleUmidificador.TabIndex = 4;
            this.btnToggleUmidificador.Text = "Ligar/Desligar Umidificador";
            // 
            // ControleAmbiente
            // 
            this.Controls.Add(this.comboBoxAmbientes);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnToggleLuz);
            this.Controls.Add(this.btnToggleUmidificador);
            this.Name = "ControleAmbiente";
            this.Size = new System.Drawing.Size(200, 170);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ControleAmbiente_Load_2(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ControleAmbiente_Load_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ControleAmbiente_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnToggleUmidificador_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnToggleLuz_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ComboBoxAmbientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SuspendLayout()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
