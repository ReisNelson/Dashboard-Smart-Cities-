﻿using Dashboard;
using Dashboard_Smart_Cities_Final.UserControls;
using MySqlConnector;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Consumo;
namespace Dashboard_Smart_Cities_Final
{
    public partial class Form1 : Form
    {
        // Sidebar
        bool isSidebarExpanded = true;
        int sidebarMaxWidth = 220;
        int sidebarMinWidth = 60;

        // UserControls
        private UcHome ucDashboard;
        private UcInformacoes ucInformacoes;
        private UcConfiguracoes ucConfiguracoes;
        private UcRanking ucRanking;
        private UcControleAmbiente ucControleAmbiente;
        private UserControl currentUc;
        private UserControl ucComodos;
        private UserControl ucMetas;

        MySqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
            ProgramConsumo.CalcConsumo(); string connectionString = "server=127.0.0.1;port=3306;database=smartcities_db;uid=root;pwd=Enterprise2006;Allow User Variables=true;";
            try
            {
                conexao = new MySqlConnection(connectionString);
                {
                    conexao.Open();
                    MessageBox.Show("Conectado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }


            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, panelContent, new object[] { true });

            this.Resize += Form1_Resize;

            // Inicializa os UserControls
            ucDashboard = new UcHome(conexao);
            ucInformacoes = new UcInformacoes(conexao);
            ucConfiguracoes = new UcConfiguracoes(conexao);
            ucControleAmbiente = new UcControleAmbiente(conexao);
            ucRanking = new UcRanking(conexao);
            ucMetas = new UcMetas(conexao);
            ucComodos = new UcComodos(conexao);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelSidebar.Width = sidebarMaxWidth;
            AjustarPanelContent(); // Ajusta posição e largura ao iniciar

            // Exibe o UserControl inicial
            ExibirUserControl(ucDashboard);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start(); // Inicia animação
        }

        private void AtualizarTextosSidebar(bool mostrar)
        {
            btnDashboard.Text = mostrar ? "Dashboard" : "";
            btnInfo.Text = mostrar ? "Informações" : "";
            btnConfig.Text = mostrar ? "Configurações" : "";
            btnRanking.Text = mostrar ? "Gastos" : "";
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (isSidebarExpanded)
            {
                // Contraindo
                panelSidebar.Width -= 10;
                if (panelSidebar.Width <= sidebarMinWidth)
                {
                    sidebarTimer.Stop();
                    isSidebarExpanded = false;
                    AtualizarTextosSidebar(false);
                }
            }
            else
            {
                // Expandindo
                panelSidebar.Width += 10;
                if (panelSidebar.Width >= sidebarMaxWidth)
                {
                    sidebarTimer.Stop();
                    isSidebarExpanded = true;
                    AtualizarTextosSidebar(true);
                }
            }

            AjustarPanelContent(); // Reposiciona e redimensiona o painel de conteúdo a cada "tick"
        }

        private void AjustarPanelContent()
        {
            panelContent.Left = panelSidebar.Right;
            panelContent.Width = this.ClientSize.Width - panelContent.Left;
        }

        private void ExibirUserControl(UserControl uc)
        {
            if (uc == currentUc) return;

            if (uc.Parent != null)
                uc.Parent.Controls.Remove(uc);

            if (currentUc != null)
                panelContent.Controls.Remove(currentUc);

            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
            currentUc = uc;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ExibirUserControl(ucDashboard);
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            ExibirUserControl(ucInformacoes);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ExibirUserControl(ucConfiguracoes);
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            ExibirUserControl(ucRanking);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComodos_Click(object sender, EventArgs e)
        {
            ExibirUserControl(ucControleAmbiente); 
        }

        private void btnMetas_Click(object sender, EventArgs e)
        {
            ExibirUserControl(ucMetas); 
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // Renomeando o método para evitar ambiguidade  
            AjustarPanelContentOnResize();
        }

        private void AjustarPanelContentOnResize()
        {
            int minContentWidth = 400; // Defina conforme o mínimo desejado para seu layout  
            panelContent.Left = panelSidebar.Right;
            int newWidth = this.ClientSize.Width - panelContent.Left;
            panelContent.Width = Math.Max(newWidth, minContentWidth);
            panelContent.Height = this.ClientSize.Height; // Garante altura total  
        }

        // Eventos não usados
        private void PanelHome_Paint(object sender, PaintEventArgs e) { }
        private void SataPanel1_Paint(object sender, PaintEventArgs e) { }
        private void Label1_Click(object sender, EventArgs e) { }
        private void UserControl1_Load(object sender, EventArgs e) { }
        private void PanelContent_Paint(object sender, PaintEventArgs e) { }
        private void panelSidebar_Paint(object sender, PaintEventArgs e) { }

        
    }
}
