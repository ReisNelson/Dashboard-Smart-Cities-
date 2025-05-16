using System.Drawing;

namespace Dashboard_Smart_Cities_Final.UserControls
{
    partial class UcMetas
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
            SATAUiFramework.BorderRadius borderRadius2 = new SATAUiFramework.BorderRadius();
            this.sataPanel3 = new SATAUiFramework.SATAPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.LabelGoalName = new System.Windows.Forms.Label();
            this.textGoalName = new System.Windows.Forms.TextBox();
            this.btnSetGoal = new FrameworkTest.SATAButton();
            this.pnlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.sataPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sataPanel3
            // 
            this.sataPanel3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.sataPanel3.BorderColor = System.Drawing.Color.Black;
            borderRadius2.BottomLeft = 10;
            borderRadius2.BottomRight = 10;
            borderRadius2.TopLeft = 10;
            borderRadius2.TopRight = 10;
            this.sataPanel3.BorderRadius = borderRadius2;
            this.sataPanel3.BorderThickness = 0;
            this.sataPanel3.Controls.Add(this.lblTitulo);
            this.sataPanel3.Location = new System.Drawing.Point(3, 3);
            this.sataPanel3.Name = "sataPanel3";
            this.sataPanel3.Size = new System.Drawing.Size(1141, 76);
            this.sataPanel3.TabIndex = 12;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(46, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(229, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Minhas Metas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.labelMetas_Click);
            // 
            // LabelGoalName
            // 
            this.LabelGoalName.AutoSize = true;
            this.LabelGoalName.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGoalName.ForeColor = System.Drawing.Color.White;
            this.LabelGoalName.Location = new System.Drawing.Point(22, 123);
            this.LabelGoalName.Name = "LabelGoalName";
            this.LabelGoalName.Size = new System.Drawing.Size(104, 45);
            this.LabelGoalName.TabIndex = 0;
            this.LabelGoalName.Text = "Meta:";
            this.LabelGoalName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelGoalName.Click += new System.EventHandler(this.labelMetas_Click);
            // 
            // textGoalName
            // 
            this.textGoalName.Location = new System.Drawing.Point(142, 144);
            this.textGoalName.Name = "textGoalName";
            this.textGoalName.Size = new System.Drawing.Size(236, 20);
            this.textGoalName.TabIndex = 14;
            // 
            // btnSetGoal
            // 
            this.btnSetGoal.ButtonText = "Adicionar nova meta";
            this.btnSetGoal.CheckedBackground = System.Drawing.Color.DodgerBlue;
            this.btnSetGoal.CheckedForeColor = System.Drawing.Color.White;
            this.btnSetGoal.CheckedImageTint = System.Drawing.Color.White;
            this.btnSetGoal.CheckedOutline = System.Drawing.Color.DodgerBlue;
            this.btnSetGoal.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSetGoal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetGoal.ForeColor = System.Drawing.Color.Black;
            this.btnSetGoal.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSetGoal.HoverForeColor = System.Drawing.Color.White;
            this.btnSetGoal.HoverImage = null;
            this.btnSetGoal.HoverImageTint = System.Drawing.Color.White;
            this.btnSetGoal.HoverOutline = System.Drawing.Color.Empty;
            this.btnSetGoal.Image = null;
            this.btnSetGoal.ImageAutoCenter = true;
            this.btnSetGoal.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSetGoal.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSetGoal.ImageTint = System.Drawing.Color.White;
            this.btnSetGoal.IsToggleButton = false;
            this.btnSetGoal.IsToggled = false;
            this.btnSetGoal.Location = new System.Drawing.Point(402, 140);
            this.btnSetGoal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSetGoal.Name = "btnSetGoal";
            this.btnSetGoal.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSetGoal.NormalForeColor = System.Drawing.Color.Black;
            this.btnSetGoal.NormalOutline = System.Drawing.Color.Empty;
            this.btnSetGoal.OutlineThickness = 2F;
            this.btnSetGoal.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.btnSetGoal.PressedForeColor = System.Drawing.Color.White;
            this.btnSetGoal.PressedImageTint = System.Drawing.Color.White;
            this.btnSetGoal.PressedOutline = System.Drawing.Color.Empty;
            this.btnSetGoal.Rounding = new System.Windows.Forms.Padding(5);
            this.btnSetGoal.Size = new System.Drawing.Size(141, 28);
            this.btnSetGoal.TabIndex = 13;
            this.btnSetGoal.TextAutoCenter = true;
            this.btnSetGoal.TextOffset = new System.Drawing.Point(0, 0);
            this.btnSetGoal.Click += new System.EventHandler(this.btnSetGoal_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlContainer.Location = new System.Drawing.Point(40, 260);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1101, 519);
            this.pnlContainer.TabIndex = 16;
            this.pnlContainer.WrapContents = false;
            // 
            // UcMetas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.textGoalName);
            this.Controls.Add(this.btnSetGoal);
            this.Controls.Add(this.LabelGoalName);
            this.Controls.Add(this.sataPanel3);
            this.Name = "UcMetas";
            this.Size = new System.Drawing.Size(1144, 779);
            this.Load += new System.EventHandler(this.UcMetas_Load);
            this.sataPanel3.ResumeLayout(false);
            this.sataPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SATAUiFramework.SATAPanel sataPanel3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label LabelGoalName;
        private System.Windows.Forms.TextBox textGoalName;
        private FrameworkTest.SATAButton btnSetGoal;
        private System.Windows.Forms.FlowLayoutPanel pnlContainer;
    }
}
