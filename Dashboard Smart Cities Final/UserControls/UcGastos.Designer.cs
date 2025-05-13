namespace Dashboard_Smart_Cities_Final.UserControls
{
    partial class UcGastos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            SATAUiFramework.BorderRadius borderRadius1 = new SATAUiFramework.BorderRadius();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcGastos));
            this.sataPanelEconomia = new SATAUiFramework.SATAPanel();
            this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.labelSemanaAtual = new System.Windows.Forms.Label();
            this.labelEconomizadoAtual = new System.Windows.Forms.Label();
            this.labelgastoAtual = new System.Windows.Forms.Label();
            this.panelBLUE = new System.Windows.Forms.Panel();
            this.pictureBoxIdeiaLamp = new System.Windows.Forms.PictureBox();
            this.sataPanelEconomia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
            this.panelBLUE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdeiaLamp)).BeginInit();
            this.SuspendLayout();
            // 
            // sataPanelEconomia
            // 
            this.sataPanelEconomia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.sataPanelEconomia.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.sataPanelEconomia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            borderRadius1.BottomLeft = 15;
            borderRadius1.BottomRight = 15;
            borderRadius1.TopLeft = 15;
            borderRadius1.TopRight = 15;
            this.sataPanelEconomia.BorderRadius = borderRadius1;
            this.sataPanelEconomia.BorderThickness = 0;
            this.sataPanelEconomia.Controls.Add(this.pictureBoxGraph);
            this.sataPanelEconomia.Controls.Add(this.labelSemanaAtual);
            this.sataPanelEconomia.Controls.Add(this.labelEconomizadoAtual);
            this.sataPanelEconomia.Controls.Add(this.labelgastoAtual);
            this.sataPanelEconomia.Controls.Add(this.panelBLUE);
            this.sataPanelEconomia.Location = new System.Drawing.Point(182, 200);
            this.sataPanelEconomia.Name = "sataPanelEconomia";
            this.sataPanelEconomia.Size = new System.Drawing.Size(367, 116);
            this.sataPanelEconomia.TabIndex = 5;
            // 
            // pictureBoxGraph
            // 
            this.pictureBoxGraph.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGraph.Image")));
            this.pictureBoxGraph.Location = new System.Drawing.Point(285, 42);
            this.pictureBoxGraph.Name = "pictureBoxGraph";
            this.pictureBoxGraph.Size = new System.Drawing.Size(39, 43);
            this.pictureBoxGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGraph.TabIndex = 6;
            this.pictureBoxGraph.TabStop = false;
            // 
            // labelSemanaAtual
            // 
            this.labelSemanaAtual.AutoSize = true;
            this.labelSemanaAtual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemanaAtual.ForeColor = System.Drawing.Color.White;
            this.labelSemanaAtual.Location = new System.Drawing.Point(273, 12);
            this.labelSemanaAtual.Name = "labelSemanaAtual";
            this.labelSemanaAtual.Size = new System.Drawing.Size(72, 13);
            this.labelSemanaAtual.TabIndex = 6;
            this.labelSemanaAtual.Text = "Essa semana";
            // 
            // labelEconomizadoAtual
            // 
            this.labelEconomizadoAtual.AutoSize = true;
            this.labelEconomizadoAtual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEconomizadoAtual.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelEconomizadoAtual.Location = new System.Drawing.Point(123, 70);
            this.labelEconomizadoAtual.Name = "labelEconomizadoAtual";
            this.labelEconomizadoAtual.Size = new System.Drawing.Size(102, 13);
            this.labelEconomizadoAtual.TabIndex = 5;
            this.labelEconomizadoAtual.Text = "15% economizado";
            // 
            // labelgastoAtual
            // 
            this.labelgastoAtual.AutoSize = true;
            this.labelgastoAtual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgastoAtual.ForeColor = System.Drawing.Color.White;
            this.labelgastoAtual.Location = new System.Drawing.Point(124, 31);
            this.labelgastoAtual.Name = "labelgastoAtual";
            this.labelgastoAtual.Size = new System.Drawing.Size(97, 30);
            this.labelgastoAtual.TabIndex = 5;
            this.labelgastoAtual.Text = "192KWh";
            // 
            // panelBLUE
            // 
            this.panelBLUE.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelBLUE.Controls.Add(this.pictureBoxIdeiaLamp);
            this.panelBLUE.Location = new System.Drawing.Point(0, 0);
            this.panelBLUE.Name = "panelBLUE";
            this.panelBLUE.Size = new System.Drawing.Size(94, 116);
            this.panelBLUE.TabIndex = 0;
            // 
            // pictureBoxIdeiaLamp
            // 
            this.pictureBoxIdeiaLamp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIdeiaLamp.Image")));
            this.pictureBoxIdeiaLamp.Location = new System.Drawing.Point(23, 31);
            this.pictureBoxIdeiaLamp.Name = "pictureBoxIdeiaLamp";
            this.pictureBoxIdeiaLamp.Size = new System.Drawing.Size(48, 54);
            this.pictureBoxIdeiaLamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIdeiaLamp.TabIndex = 5;
            this.pictureBoxIdeiaLamp.TabStop = false;
            // 
            // UcGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.sataPanelEconomia);
            this.Name = "UcGastos";
            this.Size = new System.Drawing.Size(1159, 765);
            this.sataPanelEconomia.ResumeLayout(false);
            this.sataPanelEconomia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
            this.panelBLUE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIdeiaLamp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SATAUiFramework.SATAPanel sataPanelEconomia;
        private System.Windows.Forms.PictureBox pictureBoxGraph;
        private System.Windows.Forms.Label labelSemanaAtual;
        private System.Windows.Forms.Label labelEconomizadoAtual;
        private System.Windows.Forms.Label labelgastoAtual;
        private System.Windows.Forms.Panel panelBLUE;
        private System.Windows.Forms.PictureBox pictureBoxIdeiaLamp;
    }
}
