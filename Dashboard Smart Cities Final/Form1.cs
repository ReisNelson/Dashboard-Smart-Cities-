using Dashboard;
using Dashboard_Smart_Cities_Final.UserControls;
using System;
using System.Windows.Forms;

namespace Dashboard_Smart_Cities_Final
{
    public partial class Form1 : Form
    {
        //SideBar
        bool isSidebarExpanded = true;
        int sidebarMaxWidth = 220;
        int sidebarMinWidth = 60;

        // UserControls
        private UcHome ucDashboard;
        private UcInformacoes ucInformacoes;
        private UcConfiguracoes ucConfiguracoes;
        private UcSeguranca ucSeguranca;
        private UcGastos ucGastos;
        private UserControl currentUc;

      public Form1()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, panelContent, new object[] { true });

            // Inicializa os UserControls
            ucDashboard = new UcHome();
            ucInformacoes = new UcInformacoes();
            ucConfiguracoes = new UcConfiguracoes();
            ucSeguranca = new UcSeguranca();
            ucGastos = new UcGastos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialmente sidebar aberta com texto
            panelSidebar.Width = sidebarMaxWidth;

            // Exibe o UserControl de Dashboard inicialmente
            ExibirUserControl(ucDashboard);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start(); // Inicia a animação
        }
        private void AtualizarTextosSidebar(bool mostrar)
        {
            btnDashboard.Text = mostrar ? "Dashboard" : "";
            btnInfo.Text = mostrar ? "Informações" : "";
            btnConfig.Text = mostrar ? "Configurações" : "";
            btnSeguranca.Text = mostrar ? "Segurança" : "";
            btnGastos.Text = mostrar ? "Gastos" : "";
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
        }
        private void ExibirUserControl(UserControl uc)
        {
            if (currentUc != null)
            {
                panelContent.Controls.Remove(currentUc);
               
            }
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

        private void BtnSeguranca_Click(object sender, EventArgs e)
        {
            ExibirUserControl(ucSeguranca);
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            ExibirUserControl(ucGastos);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PanelHome_Paint(object sender, PaintEventArgs e) { }
        private void SataPanel1_Paint(object sender, PaintEventArgs e) { }
        private void Label1_Click(object sender, EventArgs e) { }
        private void UserControl1_Load(object sender, EventArgs e) { }
        private void PanelContent_Paint(object sender, PaintEventArgs e) { }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}