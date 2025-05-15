using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Dashboard_Smart_Cities_Final.UserControls
{
    public partial class UcInformacoes : UserControl
    {
        private MySqlConnection conexao;

        public UcInformacoes()
        {
        }

        public UcInformacoes(MySqlConnection conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }

        private void UcInformacoes_Load(object sender, EventArgs e)
        {

        }
    }
}
