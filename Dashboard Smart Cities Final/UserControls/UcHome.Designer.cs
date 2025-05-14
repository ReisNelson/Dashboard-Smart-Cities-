using System;

namespace Dashboard
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
            SATAUiFramework.BorderRadius borderRadius3 = new SATAUiFramework.BorderRadius();
            FrameworkTest.Charts.SATALineChart.DataSet dataSet1 = new FrameworkTest.Charts.SATALineChart.DataSet();
            FrameworkTest.Charts.SATALineChart.DataSet dataSet2 = new FrameworkTest.Charts.SATALineChart.DataSet();
            this.sataPanelEconomia = new SATAUiFramework.SATAPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.teste = new SATAUiFramework.Controls.SATACircularProgress();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sataSearchBox = new SATATextBox();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.sataCircularProgress1 = new SATAUiFramework.Controls.SATACircularProgress();
            this.label2 = new System.Windows.Forms.Label();
            this.labelGastoAnt = new System.Windows.Forms.Label();
            this.sataPanel3 = new SATAUiFramework.SATAPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.sataGraficoBarra = new FrameworkTest.Charts.SATALineChart();
            this.sataEllipseControl1 = new SATAUiFramework.Controls.SATAEllipseControl();
            this.label1 = new System.Windows.Forms.Label();
            this.sataPanelEconomia.SuspendLayout();
            this.sataPanel1.SuspendLayout();
            this.sataPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sataPanelEconomia
            // 
            this.sataPanelEconomia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.sataPanelEconomia.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.sataPanelEconomia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            borderRadius1.BottomLeft = 20;
            borderRadius1.BottomRight = 20;
            borderRadius1.TopLeft = 20;
            borderRadius1.TopRight = 20;
            this.sataPanelEconomia.BorderRadius = borderRadius1;
            this.sataPanelEconomia.BorderThickness = 0;
            this.sataPanelEconomia.Controls.Add(this.label4);
            this.sataPanelEconomia.Controls.Add(this.teste);
            this.sataPanelEconomia.Controls.Add(this.label5);
            this.sataPanelEconomia.Controls.Add(this.label3);
            this.sataPanelEconomia.Location = new System.Drawing.Point(50, 122);
            this.sataPanelEconomia.Name = "sataPanelEconomia";
            this.sataPanelEconomia.Size = new System.Drawing.Size(325, 223);
            this.sataPanelEconomia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(151, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gasto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // teste
            // 
            this.teste.AnimationSpeed = 5;
            this.teste.FilledColor = System.Drawing.Color.LightBlue;
            this.teste.FilledColorAlpha = 130;
            this.teste.FilledThickness = 15;
            this.teste.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teste.IsAnimated = true;
            this.teste.Location = new System.Drawing.Point(18, 43);
            this.teste.Name = "teste";
            this.teste.Percentage = 30;
            this.teste.ShowText = true;
            this.teste.Size = new System.Drawing.Size(105, 106);
            this.teste.TabIndex = 11;
            this.teste.TextColor = System.Drawing.Color.White;
            this.teste.TextSize = 20;
            this.teste.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(79)))), ((int)(((byte)(165)))));
            this.teste.UnfilledThickness = 15;
            this.teste.Click += new System.EventHandler(this.sataBarraEconomia_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label5.Location = new System.Drawing.Point(191, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "essa semana";
            this.label5.Click += new System.EventHandler(this.labelSemanaAtual_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(140, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "192 kWh";
            // 
            // sataSearchBox
            // 
            this.sataSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.sataSearchBox.BorderColor = System.Drawing.Color.Transparent;
            this.sataSearchBox.BorderFocusColor = System.Drawing.Color.Transparent;
            this.sataSearchBox.BorderRadius = 5;
            this.sataSearchBox.BorderSize = 3;
            this.sataSearchBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sataSearchBox.ForeColor = System.Drawing.Color.White;
            this.sataSearchBox.Icon = ((System.Drawing.Image)(resources.GetObject("sataSearchBox.Icon")));
            this.sataSearchBox.IconSize = new System.Drawing.Size(20, 20);
            this.sataSearchBox.Location = new System.Drawing.Point(881, 24);
            this.sataSearchBox.Multiline = false;
            this.sataSearchBox.Name = "sataSearchBox";
            this.sataSearchBox.PasswordChar = false;
            this.sataSearchBox.PlaceholderColor = System.Drawing.Color.White;
            this.sataSearchBox.PlaceholderText = "Pesquisar...";
            this.sataSearchBox.Size = new System.Drawing.Size(250, 39);
            this.sataSearchBox.TabIndex = 2;
            this.sataSearchBox.Texts = "";
            this.sataSearchBox.UnderlinedStyle = false;
            this.sataSearchBox.Click += new System.EventHandler(this.sataSearchBox_Click);
            // 
            // sataPanel1
            // 
            this.sataPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.sataPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.sataPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            borderRadius2.BottomLeft = 20;
            borderRadius2.BottomRight = 20;
            borderRadius2.TopLeft = 20;
            borderRadius2.TopRight = 20;
            this.sataPanel1.BorderRadius = borderRadius2;
            this.sataPanel1.BorderThickness = 0;
            this.sataPanel1.Controls.Add(this.label1);
            this.sataPanel1.Controls.Add(this.sataCircularProgress1);
            this.sataPanel1.Controls.Add(this.label2);
            this.sataPanel1.Controls.Add(this.labelGastoAnt);
            this.sataPanel1.Location = new System.Drawing.Point(446, 122);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(326, 223);
            this.sataPanel1.TabIndex = 4;
            // 
            // sataCircularProgress1
            // 
            this.sataCircularProgress1.AnimationSpeed = 5;
            this.sataCircularProgress1.FilledColor = System.Drawing.Color.LightBlue;
            this.sataCircularProgress1.FilledColorAlpha = 130;
            this.sataCircularProgress1.FilledThickness = 15;
            this.sataCircularProgress1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sataCircularProgress1.IsAnimated = true;
            this.sataCircularProgress1.Location = new System.Drawing.Point(18, 43);
            this.sataCircularProgress1.Name = "sataCircularProgress1";
            this.sataCircularProgress1.Percentage = 17;
            this.sataCircularProgress1.ShowText = true;
            this.sataCircularProgress1.Size = new System.Drawing.Size(105, 106);
            this.sataCircularProgress1.TabIndex = 11;
            this.sataCircularProgress1.TextColor = System.Drawing.Color.White;
            this.sataCircularProgress1.TextSize = 20;
            this.sataCircularProgress1.UnFilledColor = System.Drawing.Color.Crimson;
            this.sataCircularProgress1.UnfilledThickness = 15;
            this.sataCircularProgress1.Click += new System.EventHandler(this.sataBarraEconomia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.label2.Location = new System.Drawing.Point(192, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "semana passada";
            this.label2.Click += new System.EventHandler(this.labelSemanaAtual_Click);
            // 
            // labelGastoAnt
            // 
            this.labelGastoAnt.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGastoAnt.ForeColor = System.Drawing.Color.White;
            this.labelGastoAnt.Location = new System.Drawing.Point(146, 58);
            this.labelGastoAnt.Name = "labelGastoAnt";
            this.labelGastoAnt.Size = new System.Drawing.Size(155, 42);
            this.labelGastoAnt.TabIndex = 5;
            this.labelGastoAnt.Text = "147 kWh";
            this.labelGastoAnt.Click += new System.EventHandler(this.labelGastoAnt_Click);
            // 
            // sataPanel3
            // 
            this.sataPanel3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.sataPanel3.BorderColor = System.Drawing.Color.Black;
            borderRadius3.BottomLeft = 10;
            borderRadius3.BottomRight = 10;
            borderRadius3.TopLeft = 10;
            borderRadius3.TopRight = 10;
            this.sataPanel3.BorderRadius = borderRadius3;
            this.sataPanel3.BorderThickness = 0;
            this.sataPanel3.Controls.Add(this.sataSearchBox);
            this.sataPanel3.Controls.Add(this.label6);
            this.sataPanel3.Location = new System.Drawing.Point(0, 0);
            this.sataPanel3.Name = "sataPanel3";
            this.sataPanel3.Size = new System.Drawing.Size(1313, 76);
            this.sataPanel3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(31, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 42);
            this.label6.TabIndex = 5;
            this.label6.Text = "Geral";
            // 
            // sataGraficoBarra
            // 
            this.sataGraficoBarra.AutoMaxValue = false;
            this.sataGraficoBarra.AxisColor = System.Drawing.Color.White;
            this.sataGraficoBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.sataGraficoBarra.ChartPadding = 55;
            this.sataGraficoBarra.CustomXAxis = new string[0];
            dataSet1.Label = "Gastou";
            dataSet1.LineColor = System.Drawing.Color.RoyalBlue;
            dataSet1.PointColor = System.Drawing.Color.Coral;
            dataSet1.Points = new float[] {
        105F,
        65F,
        80F,
        120F,
        135F,
        65F,
        30F};
            dataSet2.Label = "Economizou";
            dataSet2.LineColor = System.Drawing.Color.Firebrick;
            dataSet2.PointColor = System.Drawing.Color.SpringGreen;
            dataSet2.Points = new float[] {
        80F,
        90F,
        70F,
        100F,
        110F,
        50F,
        40F};
            this.sataGraficoBarra.DataSets.Add(dataSet1);
            this.sataGraficoBarra.DataSets.Add(dataSet2);
            this.sataGraficoBarra.DayColor = System.Drawing.Color.DarkGray;
            this.sataGraficoBarra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sataGraficoBarra.ForeColor = System.Drawing.Color.White;
            this.sataGraficoBarra.GradientBackground = true;
            this.sataGraficoBarra.GridColor = System.Drawing.Color.LightGray;
            this.sataGraficoBarra.Location = new System.Drawing.Point(50, 365);
            this.sataGraficoBarra.Margin = new System.Windows.Forms.Padding(4);
            this.sataGraficoBarra.MaxValue = 200F;
            this.sataGraficoBarra.Name = "sataGraficoBarra";
            this.sataGraficoBarra.ShortDates = true;
            this.sataGraficoBarra.Size = new System.Drawing.Size(1053, 367);
            this.sataGraficoBarra.TabIndex = 13;
            this.sataGraficoBarra.UseBezier = true;
            this.sataGraficoBarra.UsePercent = false;
            // 
            // sataEllipseControl1
            // 
            this.sataEllipseControl1.CornerRadius = 45;
            this.sataEllipseControl1.TargetControl = this.sataGraficoBarra;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(152, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gasto";
            // 
            // UcHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.sataGraficoBarra);
            this.Controls.Add(this.sataPanel3);
            this.Controls.Add(this.sataPanel1);
            this.Controls.Add(this.sataPanelEconomia);
            this.Name = "UcHome";
            this.Size = new System.Drawing.Size(1144, 779);
            this.Load += new System.EventHandler(this.UcHome_Load);
            this.sataPanelEconomia.ResumeLayout(false);
            this.sataPanelEconomia.PerformLayout();
            this.sataPanel1.ResumeLayout(false);
            this.sataPanel1.PerformLayout();
            this.sataPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void chartConsumo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        // O erro ocorre porque o método sataGraficoBarra_Load não está implementado na classe UcHome.
        // Para corrigir, adicione o método no code-behind (provavelmente em UcHome.cs):

        #endregion

        private SATAUiFramework.SATAPanel sataPanelEconomia;
        private SATATextBox sataSearchBox;
        private SATAUiFramework.Controls.SATACircularProgress teste;
        private System.Windows.Forms.Label label4;
        private SATAUiFramework.SATAPanel sataPanel1;
        private SATAUiFramework.Controls.SATACircularProgress sataCircularProgress1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelGastoAnt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private SATAUiFramework.SATAPanel sataPanel3;
        private FrameworkTest.Charts.SATALineChart sataGraficoBarra;
        private SATAUiFramework.Controls.SATAEllipseControl sataEllipseControl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}
