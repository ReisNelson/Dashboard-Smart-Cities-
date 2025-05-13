namespace Dashboard_Smart_Cities_Final.UserControls
{
    partial class UcHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcHome));
            SATAUiFramework.BorderRadius borderRadius2 = new SATAUiFramework.BorderRadius();
            this.sataPanelEconomia = new SATAUiFramework.SATAPanel();
            this.pictureBoxGraph = new System.Windows.Forms.PictureBox();
            this.labelSemanaAtual = new System.Windows.Forms.Label();
            this.labelEconomizadoAtual = new System.Windows.Forms.Label();
            this.labelgastoAtual = new System.Windows.Forms.Label();
            this.sataPanelGasto = new SATAUiFramework.SATAPanel();
            this.labelGastoAnterior = new System.Windows.Forms.Label();
            this.pictureBoxDegraph = new System.Windows.Forms.PictureBox();
            this.labelSemana = new System.Windows.Forms.Label();
            this.labelGastoPassado = new System.Windows.Forms.Label();
            this.panelPesquisaUc = new System.Windows.Forms.Panel();
            this.labelRegistrar = new System.Windows.Forms.Label();
            this.labelOu = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.pictureAccount = new System.Windows.Forms.PictureBox();
            this.sataSearchBox = new SATATextBox();
            this.labelGeral = new System.Windows.Forms.Label();
            this.sataCircularProgress1 = new SATAUiFramework.Controls.SATACircularProgress();
            this.sataCircularProgress2 = new SATAUiFramework.Controls.SATACircularProgress();
            this.sataPanelEconomia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).BeginInit();
            this.sataPanelGasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDegraph)).BeginInit();
            this.panelPesquisaUc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // sataPanelEconomia
            // 
            this.sataPanelEconomia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.sataPanelEconomia.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.sataPanelEconomia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            borderRadius1.BottomLeft = 20;
            borderRadius1.BottomRight = 20;
            borderRadius1.TopLeft = 20;
            borderRadius1.TopRight = 20;
            this.sataPanelEconomia.BorderRadius = borderRadius1;
            this.sataPanelEconomia.BorderThickness = 0;
            this.sataPanelEconomia.Controls.Add(this.pictureBoxGraph);
            this.sataPanelEconomia.Controls.Add(this.labelSemanaAtual);
            this.sataPanelEconomia.Controls.Add(this.labelEconomizadoAtual);
            this.sataPanelEconomia.Controls.Add(this.labelgastoAtual);
            this.sataPanelEconomia.Location = new System.Drawing.Point(94, 122);
            this.sataPanelEconomia.Name = "sataPanelEconomia";
            this.sataPanelEconomia.Size = new System.Drawing.Size(320, 200);
            this.sataPanelEconomia.TabIndex = 4;
            // 
            // pictureBoxGraph
            // 
            this.pictureBoxGraph.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGraph.Image")));
            this.pictureBoxGraph.Location = new System.Drawing.Point(232, 118);
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
            this.labelSemanaAtual.Location = new System.Drawing.Point(199, 12);
            this.labelSemanaAtual.Name = "labelSemanaAtual";
            this.labelSemanaAtual.Size = new System.Drawing.Size(72, 13);
            this.labelSemanaAtual.TabIndex = 6;
            this.labelSemanaAtual.Text = "Essa semana";
            this.labelSemanaAtual.Click += new System.EventHandler(this.labelSemanaAtual_Click);
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
            // sataPanelGasto
            // 
            this.sataPanelGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.sataPanelGasto.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.sataPanelGasto.BorderColor = System.Drawing.Color.Black;
            borderRadius2.BottomLeft = 15;
            borderRadius2.BottomRight = 15;
            borderRadius2.TopLeft = 15;
            borderRadius2.TopRight = 15;
            this.sataPanelGasto.BorderRadius = borderRadius2;
            this.sataPanelGasto.BorderThickness = 0;
            this.sataPanelGasto.Controls.Add(this.labelGastoAnterior);
            this.sataPanelGasto.Controls.Add(this.pictureBoxDegraph);
            this.sataPanelGasto.Controls.Add(this.labelSemana);
            this.sataPanelGasto.Controls.Add(this.labelGastoPassado);
            this.sataPanelGasto.Location = new System.Drawing.Point(694, 122);
            this.sataPanelGasto.Name = "sataPanelGasto";
            this.sataPanelGasto.Size = new System.Drawing.Size(389, 116);
            this.sataPanelGasto.TabIndex = 7;
            // 
            // labelGastoAnterior
            // 
            this.labelGastoAnterior.AutoSize = true;
            this.labelGastoAnterior.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGastoAnterior.ForeColor = System.Drawing.Color.Crimson;
            this.labelGastoAnterior.Location = new System.Drawing.Point(134, 70);
            this.labelGastoAnterior.Name = "labelGastoAnterior";
            this.labelGastoAnterior.Size = new System.Drawing.Size(82, 13);
            this.labelGastoAnterior.TabIndex = 7;
            this.labelGastoAnterior.Text = "22%+ gastado";
            // 
            // pictureBoxDegraph
            // 
            this.pictureBoxDegraph.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDegraph.Image")));
            this.pictureBoxDegraph.Location = new System.Drawing.Point(311, 42);
            this.pictureBoxDegraph.Name = "pictureBoxDegraph";
            this.pictureBoxDegraph.Size = new System.Drawing.Size(39, 43);
            this.pictureBoxDegraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDegraph.TabIndex = 7;
            this.pictureBoxDegraph.TabStop = false;
            // 
            // labelSemana
            // 
            this.labelSemana.AutoSize = true;
            this.labelSemana.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemana.ForeColor = System.Drawing.Color.White;
            this.labelSemana.Location = new System.Drawing.Point(283, 12);
            this.labelSemana.Name = "labelSemana";
            this.labelSemana.Size = new System.Drawing.Size(93, 13);
            this.labelSemana.TabIndex = 7;
            this.labelSemana.Text = "Semana passada";
            // 
            // labelGastoPassado
            // 
            this.labelGastoPassado.AutoSize = true;
            this.labelGastoPassado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGastoPassado.ForeColor = System.Drawing.Color.White;
            this.labelGastoPassado.Location = new System.Drawing.Point(132, 31);
            this.labelGastoPassado.Name = "labelGastoPassado";
            this.labelGastoPassado.Size = new System.Drawing.Size(85, 30);
            this.labelGastoPassado.TabIndex = 7;
            this.labelGastoPassado.Text = "76KWh";
            // 
            // panelPesquisaUc
            // 
            this.panelPesquisaUc.Controls.Add(this.labelRegistrar);
            this.panelPesquisaUc.Controls.Add(this.labelOu);
            this.panelPesquisaUc.Controls.Add(this.labelLogin);
            this.panelPesquisaUc.Controls.Add(this.pictureAccount);
            this.panelPesquisaUc.Controls.Add(this.sataSearchBox);
            this.panelPesquisaUc.Controls.Add(this.labelGeral);
            this.panelPesquisaUc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPesquisaUc.Location = new System.Drawing.Point(0, 0);
            this.panelPesquisaUc.Name = "panelPesquisaUc";
            this.panelPesquisaUc.Size = new System.Drawing.Size(1313, 94);
            this.panelPesquisaUc.TabIndex = 9;
            // 
            // labelRegistrar
            // 
            this.labelRegistrar.AutoSize = true;
            this.labelRegistrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrar.ForeColor = System.Drawing.Color.White;
            this.labelRegistrar.Location = new System.Drawing.Point(1007, 44);
            this.labelRegistrar.Name = "labelRegistrar";
            this.labelRegistrar.Size = new System.Drawing.Size(53, 13);
            this.labelRegistrar.TabIndex = 4;
            this.labelRegistrar.Text = "Registrar";
            this.labelRegistrar.Click += new System.EventHandler(this.labelRegistrar_Click);
            // 
            // labelOu
            // 
            this.labelOu.AutoSize = true;
            this.labelOu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOu.ForeColor = System.Drawing.Color.White;
            this.labelOu.Location = new System.Drawing.Point(1050, 30);
            this.labelOu.Name = "labelOu";
            this.labelOu.Size = new System.Drawing.Size(21, 13);
            this.labelOu.TabIndex = 4;
            this.labelOu.Text = "ou";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(1007, 30);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(37, 13);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // pictureAccount
            // 
            this.pictureAccount.Image = ((System.Drawing.Image)(resources.GetObject("pictureAccount.Image")));
            this.pictureAccount.Location = new System.Drawing.Point(1092, 30);
            this.pictureAccount.Name = "pictureAccount";
            this.pictureAccount.Size = new System.Drawing.Size(28, 27);
            this.pictureAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAccount.TabIndex = 3;
            this.pictureAccount.TabStop = false;
            this.pictureAccount.Click += new System.EventHandler(this.pictureAccount_Click);
            // 
            // sataSearchBox
            // 
            this.sataSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.sataSearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.sataSearchBox.BorderFocusColor = System.Drawing.Color.Transparent;
            this.sataSearchBox.BorderRadius = 5;
            this.sataSearchBox.BorderSize = 3;
            this.sataSearchBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sataSearchBox.Icon = ((System.Drawing.Image)(resources.GetObject("sataSearchBox.Icon")));
            this.sataSearchBox.IconSize = new System.Drawing.Size(20, 20);
            this.sataSearchBox.Location = new System.Drawing.Point(737, 27);
            this.sataSearchBox.Multiline = false;
            this.sataSearchBox.Name = "sataSearchBox";
            this.sataSearchBox.PasswordChar = false;
            this.sataSearchBox.PlaceholderColor = System.Drawing.Color.White;
            this.sataSearchBox.PlaceholderText = "Pesquisar...";
            this.sataSearchBox.Size = new System.Drawing.Size(250, 39);
            this.sataSearchBox.TabIndex = 2;
            this.sataSearchBox.Texts = "";
            this.sataSearchBox.UnderlinedStyle = false;
            // 
            // labelGeral
            // 
            this.labelGeral.AutoSize = true;
            this.labelGeral.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGeral.ForeColor = System.Drawing.Color.White;
            this.labelGeral.Location = new System.Drawing.Point(29, 27);
            this.labelGeral.Name = "labelGeral";
            this.labelGeral.Size = new System.Drawing.Size(64, 30);
            this.labelGeral.TabIndex = 1;
            this.labelGeral.Text = "Geral";
            // 
            // sataCircularProgress1
            // 
            this.sataCircularProgress1.AnimationSpeed = 3;
            this.sataCircularProgress1.BackColor = System.Drawing.Color.RoyalBlue;
            this.sataCircularProgress1.FilledColor = System.Drawing.Color.DeepSkyBlue;
            this.sataCircularProgress1.FilledColorAlpha = 130;
            this.sataCircularProgress1.FilledThickness = 40;
            this.sataCircularProgress1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sataCircularProgress1.IsAnimated = true;
            this.sataCircularProgress1.Location = new System.Drawing.Point(316, 358);
            this.sataCircularProgress1.Name = "sataCircularProgress1";
            this.sataCircularProgress1.Percentage = 15;
            this.sataCircularProgress1.ShowText = true;
            this.sataCircularProgress1.Size = new System.Drawing.Size(82, 75);
            this.sataCircularProgress1.TabIndex = 10;
            this.sataCircularProgress1.TextColor = System.Drawing.Color.White;
            this.sataCircularProgress1.TextSize = 15;
            this.sataCircularProgress1.UnFilledColor = System.Drawing.Color.MidnightBlue;
            this.sataCircularProgress1.UnfilledThickness = 24;
            // 
            // sataCircularProgress2
            // 
            this.sataCircularProgress2.AnimationSpeed = 3;
            this.sataCircularProgress2.BackColor = System.Drawing.Color.Crimson;
            this.sataCircularProgress2.FilledColor = System.Drawing.Color.OrangeRed;
            this.sataCircularProgress2.FilledColorAlpha = 130;
            this.sataCircularProgress2.FilledThickness = 40;
            this.sataCircularProgress2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sataCircularProgress2.IsAnimated = true;
            this.sataCircularProgress2.Location = new System.Drawing.Point(649, 323);
            this.sataCircularProgress2.Name = "sataCircularProgress2";
            this.sataCircularProgress2.Percentage = 22;
            this.sataCircularProgress2.ShowText = true;
            this.sataCircularProgress2.Size = new System.Drawing.Size(82, 75);
            this.sataCircularProgress2.TabIndex = 10;
            this.sataCircularProgress2.TextColor = System.Drawing.Color.White;
            this.sataCircularProgress2.TextSize = 15;
            this.sataCircularProgress2.UnFilledColor = System.Drawing.Color.DarkRed;
            this.sataCircularProgress2.UnfilledThickness = 24;
            // 
            // UcHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.sataCircularProgress1);
            this.Controls.Add(this.sataCircularProgress2);
            this.Controls.Add(this.panelPesquisaUc);
            this.Controls.Add(this.sataPanelGasto);
            this.Controls.Add(this.sataPanelEconomia);
            this.Name = "UcHome";
            this.Size = new System.Drawing.Size(1313, 765);
            this.Load += new System.EventHandler(this.UcHome_Load);
            this.sataPanelEconomia.ResumeLayout(false);
            this.sataPanelEconomia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGraph)).EndInit();
            this.sataPanelGasto.ResumeLayout(false);
            this.sataPanelGasto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDegraph)).EndInit();
            this.panelPesquisaUc.ResumeLayout(false);
            this.panelPesquisaUc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SATAUiFramework.SATAPanel sataPanelEconomia;
        private System.Windows.Forms.PictureBox pictureBoxGraph;
        private System.Windows.Forms.Label labelSemanaAtual;
        private System.Windows.Forms.Label labelEconomizadoAtual;
        private System.Windows.Forms.Label labelgastoAtual;
        private SATAUiFramework.SATAPanel sataPanelGasto;
        private System.Windows.Forms.Label labelGastoAnterior;
        private System.Windows.Forms.PictureBox pictureBoxDegraph;
        private System.Windows.Forms.Label labelSemana;
        private System.Windows.Forms.Label labelGastoPassado;
        private System.Windows.Forms.Panel panelPesquisaUc;
        private System.Windows.Forms.Label labelRegistrar;
        private System.Windows.Forms.Label labelOu;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.PictureBox pictureAccount;
        private SATATextBox sataSearchBox;
        private System.Windows.Forms.Label labelGeral;
        private SATAUiFramework.Controls.SATACircularProgress sataCircularProgress1;
        private SATAUiFramework.Controls.SATACircularProgress sataCircularProgress2;
    }
}
