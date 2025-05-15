using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;

public partial class ControleAmbiente : UserControl
{
    private TcpClient client;
    private NetworkStream stream;
    private string ipServer = "127.0.0.1";
    private int porta = 30000;

    private string ambienteAtual = "";
    private bool luzLigada = false;
    private bool umidificadorLigado = false;

    private ComboBox comboBoxAmbientes;
    private Label lblStatus;
    private Button btnEnviar, btnToggleLuz, btnToggleUmidificador;

    private MySqlConnection conexao;

    public ControleAmbiente(MySqlConnection conexao)
    {
        this.conexao = conexao;
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        // ComboBox para escolha do ambiente
        this.comboBoxAmbientes = new ComboBox();
        this.comboBoxAmbientes.Items.AddRange(new string[] { "QUARTO_1", "QUARTO_2", "SALA", "COZINHA" });
        this.comboBoxAmbientes.SelectedIndex = 0;
        this.ambienteAtual = comboBoxAmbientes.SelectedItem.ToString();
        this.comboBoxAmbientes.Location = new System.Drawing.Point(10, 10);
        this.comboBoxAmbientes.DropDownStyle = ComboBoxStyle.DropDownList;
        this.comboBoxAmbientes.Width = 150;

        // Label para status
        this.lblStatus = new Label();
        this.lblStatus.Text = "Status: Luz e Umidificador desligados";
        this.lblStatus.Location = new System.Drawing.Point(10, 40);
        this.lblStatus.AutoSize = true;

        // Botão Enviar comando para o servidor
        this.btnEnviar = new Button();
        this.btnEnviar.Text = "Enviar comando";
        this.btnEnviar.Location = new System.Drawing.Point(10, 70);
        this.btnEnviar.Click += btnEnviar_Click;

        // Botão para ligar/desligar a luz
        this.btnToggleLuz = new Button();
        this.btnToggleLuz.Text = "Ligar/Desligar Luz";
        this.btnToggleLuz.Location = new System.Drawing.Point(10, 100);
        this.btnToggleLuz.Click += btnToggleLuz_Click;

        // Botão para ligar/desligar o umidificador
        this.btnToggleUmidificador = new Button();
        this.btnToggleUmidificador.Text = "Ligar/Desligar Umidificador";
        this.btnToggleUmidificador.Location = new System.Drawing.Point(10, 130);
        this.btnToggleUmidificador.Click += btnToggleUmidificador_Click;

        // Adiciona controles ao UserControl
        this.Controls.Add(comboBoxAmbientes);
        this.Controls.Add(lblStatus);
        this.Controls.Add(btnEnviar);
        this.Controls.Add(btnToggleLuz);
        this.Controls.Add(btnToggleUmidificador);

        // Define o tamanho do UserControl
        this.Size = new System.Drawing.Size(200, 170);
    }

    private void btnEnviar_Click(object sender, EventArgs e)
    {
        ambienteAtual = comboBoxAmbientes.SelectedItem.ToString();
        EnviarMensagem("GET AMBIENTE " + ambienteAtual);
    }

    private void btnToggleLuz_Click(object sender, EventArgs e)
    {
        luzLigada = !luzLigada;
        AtualizaStatus();
    }

    private void btnToggleUmidificador_Click(object sender, EventArgs e)
    {
        umidificadorLigado = !umidificadorLigado;
        AtualizaStatus();
    }

    private void ControleAmbiente_Load_1(object sender, EventArgs e)
    {

    }

    private void ControleAmbiente_Load_2(object sender, EventArgs e)
    {

    }

    private void ControleAmbiente_Load_3(object sender, EventArgs e)
    {

    }

    private void AtualizaStatus()
    {
        lblStatus.Text = $"Luz: {(luzLigada ? "Ligada" : "Desligada")} | Umidificador: {(umidificadorLigado ? "Ligado" : "Desligado")}";
    }

    private void EnviarMensagem(string mensagem)
    {
        try
        {
            client = new TcpClient();
            client.Connect(ipServer, porta);
            stream = client.GetStream();

            byte[] dados = Encoding.UTF8.GetBytes(mensagem);
            stream.Write(dados, 0, dados.Length);

            // Leitura da resposta do servidor
            byte[] buffer = new byte[client.ReceiveBufferSize];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string resposta = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            MessageBox.Show("Resposta recebida: " + resposta, "Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);

            stream.Close();
            client.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
