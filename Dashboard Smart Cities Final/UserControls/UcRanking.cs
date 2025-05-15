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
    public partial class UcRanking : UserControl
    {
        private MySqlConnection conexao;

        public UcRanking()
        {
        }

        public UcRanking(MySqlConnection conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }

        private void sataPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UcRanking_Load(object sender, EventArgs e)
        {

        }
    }
}
