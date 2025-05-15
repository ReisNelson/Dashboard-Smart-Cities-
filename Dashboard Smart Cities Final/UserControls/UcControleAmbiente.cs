using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Dashboard_Smart_Cities_Final.UserControls
{
    public partial class UcControleAmbiente : UserControl
    {
        private TcpClient client;
        private NetworkStream stream;
        private string ipServer = "127.0.0.1";
        private int porta = 30000;
        private MySqlConnection conexao;

        private bool luzLigada = false;
        private bool umidificadorLigado = false;

        // Dicionário para armazenar o status de cada ambiente
        private Dictionary<string, (bool luzLigada, bool umidificadorLigado)> statusAmbientes =
            new Dictionary<string, (bool, bool)>();

        public UcControleAmbiente(MySqlConnection conexao)
        {
            this.conexao = conexao;
            InitializeComponent();
            sataButtonLuz.Click += SataButtonLuz_Click;
            sataButtonUmi.Click += SataButtonUmi_Click;
            ComboBoxAmbientes.SelectedIndexChanged += ComboBoxAmbientes_SelectedIndexChanged;
        }

        private void UcControleAmbiente_Load(object sender, EventArgs e)
        {
            // Inicializa o status do ambiente selecionado ao carregar
            RestaurarStatusAmbiente();
            AtualizarLabelStatus();
        }

        private void SataButtonLuz_Click(object sender, EventArgs e)
        {
            AlternarLuz();
            SalvarStatusAmbiente();
            AtualizarLabelStatus();
        }

        private void SataButtonUmi_Click(object sender, EventArgs e)
        {
            AlternarUmidificador();
            SalvarStatusAmbiente();
            AtualizarLabelStatus();
        }

        private void ComboBoxAmbientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            RestaurarStatusAmbiente();
            AtualizarLabelStatus();
        }

        private void AtualizarCoresBotoes()
        {
            // Luz: verde se ligada, cinza se desligada
            sataButtonLuz.BackColor = luzLigada ? Color.LightGreen : Color.LightGray;

            // Umidificador: azul se ligado, cinza se desligado (opcional, pode usar verde também)
            sataButtonUmi.BackColor = umidificadorLigado ? Color.LightBlue : Color.LightGray;
        }

        // Salva o status do ambiente atual no dicionário
        private void SalvarStatusAmbiente()
        {
            var ambiente = AmbienteAtual;
            if (!string.IsNullOrEmpty(ambiente))
                statusAmbientes[ambiente] = (luzLigada, umidificadorLigado);
        }

        // Restaura o status do ambiente selecionado, ou desliga tudo se for novo
        private void RestaurarStatusAmbiente()
        {
            var ambiente = AmbienteAtual;
            if (statusAmbientes.ContainsKey(ambiente))
            {
                (luzLigada, umidificadorLigado) = statusAmbientes[ambiente];
            }
            else
            {
                luzLigada = false;
                umidificadorLigado = false;
            }
        }

        // O erro CS0103 ocorre porque "satacomboBoxAmbientes" não existe no contexto atual.
        // O nome correto do controle, conforme o restante do código, é "comboBoxAmbientes".
        // Para corrigir, altere "satacomboBoxAmbientes" para "comboBoxAmbientes" na propriedade AmbienteAtual:

        private string AmbienteAtual
        {
            get
            {
                return ComboBoxAmbientes.SelectedItem?.ToString() ?? "";
            }
        }

        private void AtualizarLabelStatus()
        {
            labelStatus.Text = ObterStatusAmbiente();
            AtualizarCoresBotoes();
        }

        private string ObterStatusAmbiente()
        {
            return $"Luz: {(luzLigada ? "Ligada" : "Desligada")} | Umidificador: {(umidificadorLigado ? "Ligado" : "Desligado")}";
        }

        private void AlternarLuz()
        {
            luzLigada = !luzLigada;
        }

        private void AlternarUmidificador()
        {
            umidificadorLigado = !umidificadorLigado;
        }

        private void ComboBoxAmbientes_Click(object sender, EventArgs e)
        {

        }
    }
}
