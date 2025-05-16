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

        private System.Windows.Forms.Button btnFechar;


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
            this.btnRanking = new FrameworkTest.SATAButton();
            this.btnComodos = new FrameworkTest.SATAButton();
            this.sataButton1 = new FrameworkTest.SATAButton();
            this.btnSeguranca = new FrameworkTest.SATAButton();
            this.btnDashboard = new FrameworkTest.SATAButton();
            this.btnConfig = new FrameworkTest.SATAButton();
            this.btnInfo = new FrameworkTest.SATAButton();
            this.btnMenu = new FrameworkTest.SATAButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
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
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.panelSidebar.Controls.Add(this.label1);
            this.panelSidebar.Controls.Add(this.btnRanking);
            this.panelSidebar.Controls.Add(this.btnComodos);
            this.panelSidebar.Controls.Add(this.sataButton1);
            this.panelSidebar.Controls.Add(this.btnSeguranca);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.btnConfig);
            this.panelSidebar.Controls.Add(this.btnInfo);
            this.panelSidebar.Controls.Add(this.btnMenu);
            this.panelSidebar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panelSidebar.Location = new System.Drawing.Point(2, 3);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(221, 779);
            this.panelSidebar.TabIndex = 4;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(57, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smart Cities";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.ButtonText = "Ranking de Consumo";
            this.btnRanking.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnRanking.CheckedForeColor = System.Drawing.Color.White;
            this.btnRanking.CheckedImageTint = System.Drawing.Color.White;
            this.btnRanking.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnRanking.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRanking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanking.HoverBackground = System.Drawing.Color.OldLace;
            this.btnRanking.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnRanking.HoverImage = null;
            this.btnRanking.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnRanking.HoverOutline = System.Drawing.Color.Empty;
            this.btnRanking.Image = ((System.Drawing.Image)(resources.GetObject("btnRanking.Image")));
            this.btnRanking.ImageAutoCenter = false;
            this.btnRanking.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnRanking.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnRanking.ImageTint = System.Drawing.Color.White;
            this.btnRanking.IsToggleButton = false;
            this.btnRanking.IsToggled = false;
            this.btnRanking.Location = new System.Drawing.Point(4, 158);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnRanking.NormalForeColor = System.Drawing.Color.White;
            this.btnRanking.NormalOutline = System.Drawing.Color.Empty;
            this.btnRanking.OutlineThickness = 2F;
            this.btnRanking.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnRanking.PressedForeColor = System.Drawing.Color.White;
            this.btnRanking.PressedImageTint = System.Drawing.Color.White;
            this.btnRanking.PressedOutline = System.Drawing.Color.Empty;
            this.btnRanking.Rounding = new System.Windows.Forms.Padding(5);
            this.btnRanking.Size = new System.Drawing.Size(216, 51);
            this.btnRanking.TabIndex = 2;
            this.btnRanking.TextAutoCenter = false;
            this.btnRanking.TextOffset = new System.Drawing.Point(15, 0);
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // btnComodos
            // 
            this.btnComodos.ButtonText = "Cômodos";
            this.btnComodos.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnComodos.CheckedForeColor = System.Drawing.Color.White;
            this.btnComodos.CheckedImageTint = System.Drawing.Color.White;
            this.btnComodos.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnComodos.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnComodos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComodos.HoverBackground = System.Drawing.Color.OldLace;
            this.btnComodos.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnComodos.HoverImage = null;
            this.btnComodos.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnComodos.HoverOutline = System.Drawing.Color.Empty;
            this.btnComodos.Image = ((System.Drawing.Image)(resources.GetObject("btnComodos.Image")));
            this.btnComodos.ImageAutoCenter = false;
            this.btnComodos.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnComodos.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnComodos.ImageTint = System.Drawing.Color.White;
            this.btnComodos.IsToggleButton = false;
            this.btnComodos.IsToggled = false;
            this.btnComodos.Location = new System.Drawing.Point(5, 329);
            this.btnComodos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnComodos.Name = "btnComodos";
            this.btnComodos.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnComodos.NormalForeColor = System.Drawing.Color.White;
            this.btnComodos.NormalOutline = System.Drawing.Color.Empty;
            this.btnComodos.OutlineThickness = 2F;
            this.btnComodos.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnComodos.PressedForeColor = System.Drawing.Color.White;
            this.btnComodos.PressedImageTint = System.Drawing.Color.White;
            this.btnComodos.PressedOutline = System.Drawing.Color.Empty;
            this.btnComodos.Rounding = new System.Windows.Forms.Padding(5);
            this.btnComodos.Size = new System.Drawing.Size(216, 51);
            this.btnComodos.TabIndex = 2;
            this.btnComodos.TextAutoCenter = false;
            this.btnComodos.TextOffset = new System.Drawing.Point(15, 0);
            this.btnComodos.Click += new System.EventHandler(this.btnComodos_Click);
            // 
            // sataButton1
            // 
            this.sataButton1.ButtonText = "Metas e Progresso";
            this.sataButton1.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.sataButton1.CheckedForeColor = System.Drawing.Color.White;
            this.sataButton1.CheckedImageTint = System.Drawing.Color.White;
            this.sataButton1.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.sataButton1.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.sataButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sataButton1.HoverBackground = System.Drawing.Color.OldLace;
            this.sataButton1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.sataButton1.HoverImage = null;
            this.sataButton1.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.sataButton1.HoverOutline = System.Drawing.Color.Empty;
            this.sataButton1.Image = ((System.Drawing.Image)(resources.GetObject("sataButton1.Image")));
            this.sataButton1.ImageAutoCenter = false;
            this.sataButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.sataButton1.ImageOffset = new System.Drawing.Point(15, 0);
            this.sataButton1.ImageTint = System.Drawing.Color.White;
            this.sataButton1.IsToggleButton = false;
            this.sataButton1.IsToggled = false;
            this.sataButton1.Location = new System.Drawing.Point(4, 272);
            this.sataButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sataButton1.Name = "sataButton1";
            this.sataButton1.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.sataButton1.NormalForeColor = System.Drawing.Color.White;
            this.sataButton1.NormalOutline = System.Drawing.Color.Empty;
            this.sataButton1.OutlineThickness = 2F;
            this.sataButton1.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.sataButton1.PressedForeColor = System.Drawing.Color.White;
            this.sataButton1.PressedImageTint = System.Drawing.Color.White;
            this.sataButton1.PressedOutline = System.Drawing.Color.Empty;
            this.sataButton1.Rounding = new System.Windows.Forms.Padding(5);
            this.sataButton1.Size = new System.Drawing.Size(216, 51);
            this.sataButton1.TabIndex = 2;
            this.sataButton1.TextAutoCenter = false;
            this.sataButton1.TextOffset = new System.Drawing.Point(15, 0);
            this.sataButton1.Click += new System.EventHandler(this.BtnSeguranca_Click);
            // 
            // btnSeguranca
            // 
            this.btnSeguranca.ButtonText = "Alertas e Notificações";
            this.btnSeguranca.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnSeguranca.CheckedForeColor = System.Drawing.Color.White;
            this.btnSeguranca.CheckedImageTint = System.Drawing.Color.White;
            this.btnSeguranca.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.btnSeguranca.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSeguranca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguranca.HoverBackground = System.Drawing.Color.OldLace;
            this.btnSeguranca.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnSeguranca.HoverImage = null;
            this.btnSeguranca.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnSeguranca.HoverOutline = System.Drawing.Color.Empty;
            this.btnSeguranca.Image = ((System.Drawing.Image)(resources.GetObject("btnSeguranca.Image")));
            this.btnSeguranca.ImageAutoCenter = false;
            this.btnSeguranca.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnSeguranca.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnSeguranca.ImageTint = System.Drawing.Color.White;
            this.btnSeguranca.IsToggleButton = false;
            this.btnSeguranca.IsToggled = false;
            this.btnSeguranca.Location = new System.Drawing.Point(4, 215);
            this.btnSeguranca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSeguranca.Name = "btnSeguranca";
            this.btnSeguranca.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnSeguranca.NormalForeColor = System.Drawing.Color.White;
            this.btnSeguranca.NormalOutline = System.Drawing.Color.Empty;
            this.btnSeguranca.OutlineThickness = 2F;
            this.btnSeguranca.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnSeguranca.PressedForeColor = System.Drawing.Color.White;
            this.btnSeguranca.PressedImageTint = System.Drawing.Color.White;
            this.btnSeguranca.PressedOutline = System.Drawing.Color.Empty;
            this.btnSeguranca.Rounding = new System.Windows.Forms.Padding(5);
            this.btnSeguranca.Size = new System.Drawing.Size(216, 51);
            this.btnSeguranca.TabIndex = 2;
            this.btnSeguranca.TextAutoCenter = false;
            this.btnSeguranca.TextOffset = new System.Drawing.Point(15, 0);
            this.btnSeguranca.Click += new System.EventHandler(this.BtnSeguranca_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.ButtonText = "Consumo de Energia";
            this.btnDashboard.CausesValidation = false;
            this.btnDashboard.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(40)))));
            this.btnDashboard.CheckedForeColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedImageTint = System.Drawing.Color.White;
            this.btnDashboard.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(19)))), ((int)(((byte)(40)))));
            this.btnDashboard.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.HoverBackground = System.Drawing.Color.OldLace;
            this.btnDashboard.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnDashboard.HoverImage = null;
            this.btnDashboard.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnDashboard.HoverOutline = System.Drawing.Color.Empty;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAutoCenter = false;
            this.btnDashboard.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnDashboard.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnDashboard.ImageTint = System.Drawing.Color.White;
            this.btnDashboard.IsToggleButton = false;
            this.btnDashboard.IsToggled = false;
            this.btnDashboard.Location = new System.Drawing.Point(4, 101);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnDashboard.NormalForeColor = System.Drawing.Color.White;
            this.btnDashboard.NormalOutline = System.Drawing.Color.Empty;
            this.btnDashboard.OutlineThickness = 2F;
            this.btnDashboard.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnDashboard.PressedForeColor = System.Drawing.Color.White;
            this.btnDashboard.PressedImageTint = System.Drawing.Color.White;
            this.btnDashboard.PressedOutline = System.Drawing.Color.Empty;
            this.btnDashboard.Rounding = new System.Windows.Forms.Padding(5);
            this.btnDashboard.Size = new System.Drawing.Size(216, 51);
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
            this.btnConfig.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.HoverBackground = System.Drawing.Color.OldLace;
            this.btnConfig.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnConfig.HoverImage = null;
            this.btnConfig.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnConfig.HoverOutline = System.Drawing.Color.Empty;
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.ImageAutoCenter = false;
            this.btnConfig.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnConfig.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnConfig.ImageTint = System.Drawing.Color.White;
            this.btnConfig.IsToggleButton = false;
            this.btnConfig.IsToggled = false;
            this.btnConfig.Location = new System.Drawing.Point(4, 663);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnConfig.NormalForeColor = System.Drawing.Color.White;
            this.btnConfig.NormalOutline = System.Drawing.Color.Empty;
            this.btnConfig.OutlineThickness = 2F;
            this.btnConfig.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnConfig.PressedForeColor = System.Drawing.Color.White;
            this.btnConfig.PressedImageTint = System.Drawing.Color.White;
            this.btnConfig.PressedOutline = System.Drawing.Color.Empty;
            this.btnConfig.Rounding = new System.Windows.Forms.Padding(5);
            this.btnConfig.Size = new System.Drawing.Size(216, 51);
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
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.HoverBackground = System.Drawing.Color.OldLace;
            this.btnInfo.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnInfo.HoverImage = null;
            this.btnInfo.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnInfo.HoverOutline = System.Drawing.Color.Empty;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAutoCenter = false;
            this.btnInfo.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnInfo.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnInfo.ImageTint = System.Drawing.Color.White;
            this.btnInfo.IsToggleButton = false;
            this.btnInfo.IsToggled = false;
            this.btnInfo.Location = new System.Drawing.Point(4, 606);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnInfo.NormalForeColor = System.Drawing.Color.White;
            this.btnInfo.NormalOutline = System.Drawing.Color.Empty;
            this.btnInfo.OutlineThickness = 2F;
            this.btnInfo.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(46)))), ((int)(((byte)(210)))));
            this.btnInfo.PressedForeColor = System.Drawing.Color.White;
            this.btnInfo.PressedImageTint = System.Drawing.Color.White;
            this.btnInfo.PressedOutline = System.Drawing.Color.Empty;
            this.btnInfo.Rounding = new System.Windows.Forms.Padding(5);
            this.btnInfo.Size = new System.Drawing.Size(216, 51);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.TextAutoCenter = false;
            this.btnInfo.TextOffset = new System.Drawing.Point(15, 0);
            this.btnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.ButtonText = "☰";
            this.btnMenu.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnMenu.CheckedForeColor = System.Drawing.Color.White;
            this.btnMenu.CheckedImageTint = System.Drawing.Color.White;
            this.btnMenu.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnMenu.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.btnMenu.HoverBackground = System.Drawing.Color.OldLace;
            this.btnMenu.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
            this.btnMenu.HoverImage = null;
            this.btnMenu.HoverImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
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
            this.btnMenu.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(24)))));
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
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelContent.Controls.Add(this.btnFechar);
            this.panelContent.Location = new System.Drawing.Point(221, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1114, 779);
            this.panelContent.TabIndex = 6;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContent_Paint);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(1068, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 30);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "x";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1336, 780);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelContent);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SATAUiFramework.Controls.SATAEllipseControl sataEllipseControl1;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label label1;
        private FrameworkTest.SATAButton btnRanking;
        private FrameworkTest.SATAButton btnSeguranca;
        private FrameworkTest.SATAButton btnDashboard;
        private FrameworkTest.SATAButton btnConfig;
        private FrameworkTest.SATAButton btnInfo;
        private FrameworkTest.SATAButton btnMenu;
        private System.Windows.Forms.Panel panelContent;
        private FrameworkTest.SATAButton sataButton1;
        private FrameworkTest.SATAButton btnComodos;
    }
}

