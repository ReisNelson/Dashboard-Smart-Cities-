namespace Dashboard_Smart_Cities_Final
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sataEllipseControl1 = new SATAUiFramework.Controls.SATAEllipseControl();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGastos = new FrameworkTest.SATAButton();
            this.btnSeguranca = new FrameworkTest.SATAButton();
            this.btnDashboard = new FrameworkTest.SATAButton();
            this.btnConfig = new FrameworkTest.SATAButton();
            this.btnInfo = new FrameworkTest.SATAButton();
            this.btnMenu = new FrameworkTest.SATAButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sataEllipseControl1
            // 
            this.sataEllipseControl1.CornerRadius = 35;
            this.sataEllipseControl1.TargetControl = this;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelSidebar.Controls.Add(this.label1);
            this.panelSidebar.Controls.Add(this.btnGastos);
            this.panelSidebar.Controls.Add(this.btnSeguranca);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.btnConfig);
            this.panelSidebar.Controls.Add(this.btnInfo);
            this.panelSidebar.Controls.Add(this.btnMenu);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(199, 765);
            this.panelSidebar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smart Cities";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.ButtonText = "Gastos";
            this.btnGastos.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnGastos.CheckedForeColor = System.Drawing.Color.White;
            this.btnGastos.CheckedImageTint = System.Drawing.Color.White;
            this.btnGastos.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnGastos.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGastos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastos.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnGastos.HoverForeColor = System.Drawing.Color.White;
            this.btnGastos.HoverImage = null;
            this.btnGastos.HoverImageTint = System.Drawing.Color.White;
            this.btnGastos.HoverOutline = System.Drawing.Color.Empty;
            this.btnGastos.Image = ((System.Drawing.Image)(resources.GetObject("btnGastos.Image")));
            this.btnGastos.ImageAutoCenter = false;
            this.btnGastos.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnGastos.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnGastos.ImageTint = System.Drawing.Color.White;
            this.btnGastos.IsToggleButton = false;
            this.btnGastos.IsToggled = false;
            this.btnGastos.Location = new System.Drawing.Point(13, 158);
            this.btnGastos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnGastos.NormalForeColor = System.Drawing.Color.White;
            this.btnGastos.NormalOutline = System.Drawing.Color.Empty;
            this.btnGastos.OutlineThickness = 2F;
            this.btnGastos.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnGastos.PressedForeColor = System.Drawing.Color.White;
            this.btnGastos.PressedImageTint = System.Drawing.Color.White;
            this.btnGastos.PressedOutline = System.Drawing.Color.Empty;
            this.btnGastos.Rounding = new System.Windows.Forms.Padding(5);
            this.btnGastos.Size = new System.Drawing.Size(161, 51);
            this.btnGastos.TabIndex = 2;
            this.btnGastos.TextAutoCenter = false;
            this.btnGastos.TextOffset = new System.Drawing.Point(15, 0);
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnSeguranca
            // 
            this.btnSeguranca.ButtonText = "Segurança";
            this.btnSeguranca.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnSeguranca.CheckedForeColor = System.Drawing.Color.White;
            this.btnSeguranca.CheckedImageTint = System.Drawing.Color.White;
            this.btnSeguranca.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnSeguranca.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSeguranca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguranca.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnSeguranca.HoverForeColor = System.Drawing.Color.White;
            this.btnSeguranca.HoverImage = null;
            this.btnSeguranca.HoverImageTint = System.Drawing.Color.White;
            this.btnSeguranca.HoverOutline = System.Drawing.Color.Empty;
            this.btnSeguranca.Image = ((System.Drawing.Image)(resources.GetObject("btnSeguranca.Image")));
            this.btnSeguranca.ImageAutoCenter = false;
            this.btnSeguranca.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSeguranca.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnSeguranca.ImageTint = System.Drawing.Color.White;
            this.btnSeguranca.IsToggleButton = false;
            this.btnSeguranca.IsToggled = false;
            this.btnSeguranca.Location = new System.Drawing.Point(13, 215);
            this.btnSeguranca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSeguranca.Name = "btnSeguranca";
            this.btnSeguranca.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnSeguranca.NormalForeColor = System.Drawing.Color.White;
            this.btnSeguranca.NormalOutline = System.Drawing.Color.Empty;
            this.btnSeguranca.OutlineThickness = 2F;
            this.btnSeguranca.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnSeguranca.PressedForeColor = System.Drawing.Color.White;
            this.btnSeguranca.PressedImageTint = System.Drawing.Color.White;
            this.btnSeguranca.PressedOutline = System.Drawing.Color.Empty;
            this.btnSeguranca.Rounding = new System.Windows.Forms.Padding(5);
            this.btnSeguranca.Size = new System.Drawing.Size(161, 51);
            this.btnSeguranca.TabIndex = 2;
            this.btnSeguranca.TextAutoCenter = false;
            this.btnSeguranca.TextOffset = new System.Drawing.Point(15, 0);
            this.btnSeguranca.Click += new System.EventHandler(this.BtnSeguranca_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonText = "Dashboard";
            this.btnDashboard.CausesValidation = false;
            this.btnDashboard.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(40)))));
            this.btnDashboard.CheckedForeColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedImageTint = System.Drawing.Color.White;
            this.btnDashboard.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(40)))));
            this.btnDashboard.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnDashboard.HoverForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverImage = null;
            this.btnDashboard.HoverImageTint = System.Drawing.Color.White;
            this.btnDashboard.HoverOutline = System.Drawing.Color.Empty;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAutoCenter = false;
            this.btnDashboard.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnDashboard.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnDashboard.ImageTint = System.Drawing.Color.White;
            this.btnDashboard.IsToggleButton = false;
            this.btnDashboard.IsToggled = false;
            this.btnDashboard.Location = new System.Drawing.Point(13, 101);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnDashboard.NormalForeColor = System.Drawing.Color.White;
            this.btnDashboard.NormalOutline = System.Drawing.Color.Empty;
            this.btnDashboard.OutlineThickness = 2F;
            this.btnDashboard.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnDashboard.PressedForeColor = System.Drawing.Color.White;
            this.btnDashboard.PressedImageTint = System.Drawing.Color.White;
            this.btnDashboard.PressedOutline = System.Drawing.Color.Empty;
            this.btnDashboard.Rounding = new System.Windows.Forms.Padding(5);
            this.btnDashboard.Size = new System.Drawing.Size(161, 51);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.TextAutoCenter = false;
            this.btnDashboard.TextOffset = new System.Drawing.Point(15, 0);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.ButtonText = "Configurações";
            this.btnConfig.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnConfig.CheckedForeColor = System.Drawing.Color.White;
            this.btnConfig.CheckedImageTint = System.Drawing.Color.White;
            this.btnConfig.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnConfig.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnConfig.HoverForeColor = System.Drawing.Color.White;
            this.btnConfig.HoverImage = null;
            this.btnConfig.HoverImageTint = System.Drawing.Color.White;
            this.btnConfig.HoverOutline = System.Drawing.Color.Empty;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.ImageAutoCenter = false;
            this.btnConfig.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnConfig.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnConfig.ImageTint = System.Drawing.Color.White;
            this.btnConfig.IsToggleButton = false;
            this.btnConfig.IsToggled = false;
            this.btnConfig.Location = new System.Drawing.Point(13, 653);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnConfig.NormalForeColor = System.Drawing.Color.White;
            this.btnConfig.NormalOutline = System.Drawing.Color.Empty;
            this.btnConfig.OutlineThickness = 2F;
            this.btnConfig.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnConfig.PressedForeColor = System.Drawing.Color.White;
            this.btnConfig.PressedImageTint = System.Drawing.Color.White;
            this.btnConfig.PressedOutline = System.Drawing.Color.Empty;
            this.btnConfig.Rounding = new System.Windows.Forms.Padding(5);
            this.btnConfig.Size = new System.Drawing.Size(161, 51);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.TextAutoCenter = false;
            this.btnConfig.TextOffset = new System.Drawing.Point(15, 0);
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.ButtonText = "Informações";
            this.btnInfo.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnInfo.CheckedForeColor = System.Drawing.Color.White;
            this.btnInfo.CheckedImageTint = System.Drawing.Color.White;
            this.btnInfo.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnInfo.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnInfo.HoverForeColor = System.Drawing.Color.White;
            this.btnInfo.HoverImage = null;
            this.btnInfo.HoverImageTint = System.Drawing.Color.White;
            this.btnInfo.HoverOutline = System.Drawing.Color.Empty;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAutoCenter = false;
            this.btnInfo.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnInfo.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnInfo.ImageTint = System.Drawing.Color.White;
            this.btnInfo.IsToggleButton = false;
            this.btnInfo.IsToggled = false;
            this.btnInfo.Location = new System.Drawing.Point(13, 605);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnInfo.NormalForeColor = System.Drawing.Color.White;
            this.btnInfo.NormalOutline = System.Drawing.Color.Empty;
            this.btnInfo.OutlineThickness = 2F;
            this.btnInfo.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnInfo.PressedForeColor = System.Drawing.Color.White;
            this.btnInfo.PressedImageTint = System.Drawing.Color.White;
            this.btnInfo.PressedOutline = System.Drawing.Color.Empty;
            this.btnInfo.Rounding = new System.Windows.Forms.Padding(5);
            this.btnInfo.Size = new System.Drawing.Size(161, 51);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.TextAutoCenter = false;
            this.btnInfo.TextOffset = new System.Drawing.Point(15, 0);
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.ButtonText = "☰";
            this.btnMenu.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnMenu.CheckedForeColor = System.Drawing.Color.White;
            this.btnMenu.CheckedImageTint = System.Drawing.Color.White;
            this.btnMenu.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnMenu.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.btnMenu.HoverBackground = System.Drawing.Color.Gray;
            this.btnMenu.HoverForeColor = System.Drawing.Color.White;
            this.btnMenu.HoverImage = null;
            this.btnMenu.HoverImageTint = System.Drawing.Color.White;
            this.btnMenu.HoverOutline = System.Drawing.Color.Empty;
            this.btnMenu.Image = null;
            this.btnMenu.ImageAutoCenter = true;
            this.btnMenu.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnMenu.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMenu.ImageTint = System.Drawing.Color.White;
            this.btnMenu.IsToggleButton = false;
            this.btnMenu.IsToggled = false;
            this.btnMenu.Location = new System.Drawing.Point(0, 12);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnMenu.NormalForeColor = System.Drawing.Color.White;
            this.btnMenu.NormalOutline = System.Drawing.Color.Empty;
            this.btnMenu.OutlineThickness = 2F;
            this.btnMenu.PressedBackground = System.Drawing.Color.Snow;
            this.btnMenu.PressedForeColor = System.Drawing.Color.White;
            this.btnMenu.PressedImageTint = System.Drawing.Color.White;
            this.btnMenu.PressedOutline = System.Drawing.Color.Empty;
            this.btnMenu.Rounding = new System.Windows.Forms.Padding(5);
            this.btnMenu.Size = new System.Drawing.Size(50, 40);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.TextAutoCenter = true;
            this.btnMenu.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContent.Location = new System.Drawing.Point(199, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1166, 765);
            this.panelContent.TabIndex = 6;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContent_Paint);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1365, 765);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelContent);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SATAUiFramework.Controls.SATAEllipseControl sataEllipseControl1;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label label1;
        private FrameworkTest.SATAButton btnGastos;
        private FrameworkTest.SATAButton btnSeguranca;
        private FrameworkTest.SATAButton btnDashboard;
        private FrameworkTest.SATAButton btnConfig;
        private FrameworkTest.SATAButton btnInfo;
        private FrameworkTest.SATAButton btnMenu;
        private System.Windows.Forms.Panel panelContent;
    }
}

