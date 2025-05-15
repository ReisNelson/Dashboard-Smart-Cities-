using System;
using System.Windows.Forms;

namespace Dashboard_Smart_Cities_Final.UserControls
{
    partial class UcControleAmbiente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcControleAmbiente));
            SATAUiFramework.BorderRadius borderRadius2 = new SATAUiFramework.BorderRadius();
            this.sataButtonLuz = new FrameworkTest.SATAButton();
            this.sataButtonUmi = new FrameworkTest.SATAButton();
            this.labelLuz = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelControleAmbi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCombobox = new System.Windows.Forms.Label();
            this.sataPanel1 = new SATAUiFramework.SATAPanel();
            this.labelUmi = new System.Windows.Forms.Label();
            this.ComboBoxAmbientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.sataPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sataButtonLuz
            // 
            this.sataButtonLuz.ButtonText = "Ligar/Desligar";
            this.sataButtonLuz.CheckedBackground = System.Drawing.Color.Silver;
            this.sataButtonLuz.CheckedForeColor = System.Drawing.Color.Transparent;
            this.sataButtonLuz.CheckedImageTint = System.Drawing.Color.Transparent;
            this.sataButtonLuz.CheckedOutline = System.Drawing.Color.Transparent;
            this.sataButtonLuz.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.sataButtonLuz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sataButtonLuz.HoverBackground = System.Drawing.Color.Silver;
            this.sataButtonLuz.HoverForeColor = System.Drawing.Color.White;
            this.sataButtonLuz.HoverImage = null;
            this.sataButtonLuz.HoverImageTint = System.Drawing.Color.White;
            this.sataButtonLuz.HoverOutline = System.Drawing.Color.Empty;
            this.sataButtonLuz.Image = ((System.Drawing.Image)(resources.GetObject("sataButtonLuz.Image")));
            this.sataButtonLuz.ImageAutoCenter = false;
            this.sataButtonLuz.ImageExpand = new System.Drawing.Point(0, 0);
            this.sataButtonLuz.ImageOffset = new System.Drawing.Point(15, 0);
            this.sataButtonLuz.ImageTint = System.Drawing.Color.White;
            this.sataButtonLuz.IsToggleButton = false;
            this.sataButtonLuz.IsToggled = false;
            this.sataButtonLuz.Location = new System.Drawing.Point(73, 342);
            this.sataButtonLuz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sataButtonLuz.Name = "sataButtonLuz";
            this.sataButtonLuz.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.sataButtonLuz.NormalForeColor = System.Drawing.Color.White;
            this.sataButtonLuz.NormalOutline = System.Drawing.Color.Empty;
            this.sataButtonLuz.OutlineThickness = 2F;
            this.sataButtonLuz.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.sataButtonLuz.PressedForeColor = System.Drawing.Color.White;
            this.sataButtonLuz.PressedImageTint = System.Drawing.Color.White;
            this.sataButtonLuz.PressedOutline = System.Drawing.Color.Empty;
            this.sataButtonLuz.Rounding = new System.Windows.Forms.Padding(5);
            this.sataButtonLuz.Size = new System.Drawing.Size(190, 48);
            this.sataButtonLuz.TabIndex = 0;
            this.sataButtonLuz.TextAutoCenter = true;
            this.sataButtonLuz.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // sataButtonUmi
            // 
            this.sataButtonUmi.ButtonText = "Ligar/Desligar";
            this.sataButtonUmi.CheckedBackground = System.Drawing.Color.Silver;
            this.sataButtonUmi.CheckedForeColor = System.Drawing.Color.Transparent;
            this.sataButtonUmi.CheckedImageTint = System.Drawing.Color.Transparent;
            this.sataButtonUmi.CheckedOutline = System.Drawing.Color.Transparent;
            this.sataButtonUmi.CustomDialogResult = System.Windows.Forms.DialogResult.None;
            this.sataButtonUmi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sataButtonUmi.HoverBackground = System.Drawing.Color.Silver;
            this.sataButtonUmi.HoverForeColor = System.Drawing.Color.White;
            this.sataButtonUmi.HoverImage = null;
            this.sataButtonUmi.HoverImageTint = System.Drawing.Color.White;
            this.sataButtonUmi.HoverOutline = System.Drawing.Color.Empty;
            this.sataButtonUmi.Image = ((System.Drawing.Image)(resources.GetObject("sataButtonUmi.Image")));
            this.sataButtonUmi.ImageAutoCenter = false;
            this.sataButtonUmi.ImageExpand = new System.Drawing.Point(0, 0);
            this.sataButtonUmi.ImageOffset = new System.Drawing.Point(15, 0);
            this.sataButtonUmi.ImageTint = System.Drawing.Color.White;
            this.sataButtonUmi.IsToggleButton = false;
            this.sataButtonUmi.IsToggled = false;
            this.sataButtonUmi.Location = new System.Drawing.Point(343, 342);
            this.sataButtonUmi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sataButtonUmi.Name = "sataButtonUmi";
            this.sataButtonUmi.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.sataButtonUmi.NormalForeColor = System.Drawing.Color.White;
            this.sataButtonUmi.NormalOutline = System.Drawing.Color.Empty;
            this.sataButtonUmi.OutlineThickness = 2F;
            this.sataButtonUmi.PressedBackground = System.Drawing.Color.RoyalBlue;
            this.sataButtonUmi.PressedForeColor = System.Drawing.Color.White;
            this.sataButtonUmi.PressedImageTint = System.Drawing.Color.White;
            this.sataButtonUmi.PressedOutline = System.Drawing.Color.Empty;
            this.sataButtonUmi.Rounding = new System.Windows.Forms.Padding(5);
            this.sataButtonUmi.Size = new System.Drawing.Size(190, 48);
            this.sataButtonUmi.TabIndex = 0;
            this.sataButtonUmi.TextAutoCenter = true;
            this.sataButtonUmi.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // labelLuz
            // 
            this.labelLuz.AutoSize = true;
            this.labelLuz.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLuz.ForeColor = System.Drawing.Color.White;
            this.labelLuz.Location = new System.Drawing.Point(151, 309);
            this.labelLuz.Name = "labelLuz";
            this.labelLuz.Size = new System.Drawing.Size(29, 17);
            this.labelLuz.TabIndex = 1;
            this.labelLuz.Text = "Luz";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(13, 12);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 21);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Click += new System.EventHandler(this.LabelStatus_Click);
            // 
            // labelControleAmbi
            // 
            this.labelControleAmbi.AutoSize = true;
            this.labelControleAmbi.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControleAmbi.ForeColor = System.Drawing.Color.White;
            this.labelControleAmbi.Location = new System.Drawing.Point(422, 17);
            this.labelControleAmbi.Name = "labelControleAmbi";
            this.labelControleAmbi.Size = new System.Drawing.Size(351, 45);
            this.labelControleAmbi.TabIndex = 1;
            this.labelControleAmbi.Text = "Controle de Ambiente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControleAmbi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 73);
            this.panel1.TabIndex = 3;
            // 
            // labelCombobox
            // 
            this.labelCombobox.AutoSize = true;
            this.labelCombobox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCombobox.ForeColor = System.Drawing.Color.White;
            this.labelCombobox.Location = new System.Drawing.Point(49, 136);
            this.labelCombobox.Name = "labelCombobox";
            this.labelCombobox.Size = new System.Drawing.Size(195, 25);
            this.labelCombobox.TabIndex = 1;
            this.labelCombobox.Text = "Selecione o ambiente";
            // 
            // sataPanel1
            // 
            this.sataPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.sataPanel1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.sataPanel1.BorderColor = System.Drawing.Color.Black;
            borderRadius2.BottomLeft = 10;
            borderRadius2.BottomRight = 10;
            borderRadius2.TopLeft = 10;
            borderRadius2.TopRight = 10;
            this.sataPanel1.BorderRadius = borderRadius2;
            this.sataPanel1.BorderThickness = 0;
            this.sataPanel1.Controls.Add(this.labelStatus);
            this.sataPanel1.Location = new System.Drawing.Point(250, 209);
            this.sataPanel1.Name = "sataPanel1";
            this.sataPanel1.Size = new System.Drawing.Size(295, 43);
            this.sataPanel1.TabIndex = 5;
            // 
            // labelUmi
            // 
            this.labelUmi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUmi.ForeColor = System.Drawing.Color.White;
            this.labelUmi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelUmi.Location = new System.Drawing.Point(401, 309);
            this.labelUmi.Name = "labelUmi";
            this.labelUmi.Size = new System.Drawing.Size(91, 21);
            this.labelUmi.TabIndex = 1;
            this.labelUmi.Text = "Umidificador";
            // 
            // ComboBoxAmbientes
            // 
            this.ComboBoxAmbientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.ComboBoxAmbientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxAmbientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxAmbientes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxAmbientes.ForeColor = System.Drawing.Color.Transparent;
            this.ComboBoxAmbientes.FormattingEnabled = true;
            this.ComboBoxAmbientes.Items.AddRange(new object[] {
            "Quarto 1",
            "Quarto 2",
            "Sala",
            "Cozinha"});
            this.ComboBoxAmbientes.Location = new System.Drawing.Point(250, 136);
            this.ComboBoxAmbientes.Name = "ComboBoxAmbientes";
            this.ComboBoxAmbientes.Size = new System.Drawing.Size(295, 25);
            this.ComboBoxAmbientes.TabIndex = 6;
            this.ComboBoxAmbientes.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status:";
            // 
            // UcControleAmbiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.ComboBoxAmbientes);
            this.Controls.Add(this.sataPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelLuz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCombobox);
            this.Controls.Add(this.labelUmi);
            this.Controls.Add(this.sataButtonUmi);
            this.Controls.Add(this.sataButtonLuz);
            this.Name = "UcControleAmbiente";
            this.Size = new System.Drawing.Size(1144, 779);
            this.Load += new System.EventHandler(this.UcControleAmbiente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sataPanel1.ResumeLayout(false);
            this.sataPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LabelStatus_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private FrameworkTest.SATAButton sataButtonLuz;
        private FrameworkTest.SATAButton sataButtonUmi;
        private System.Windows.Forms.Label labelLuz;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelControleAmbi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCombobox;
        private SATAUiFramework.SATAPanel sataPanel1;
        private System.Windows.Forms.Label labelUmi;
        private ComboBox ComboBoxAmbientes;
        private Label label1;
    }
}
