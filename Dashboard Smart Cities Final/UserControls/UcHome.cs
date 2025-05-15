using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using MySqlConnector;

namespace Dashboard
{
    public partial class UcHome : UserControl
    {
        private MySqlConnection conexao;
        public UcHome(MySqlConnection conexao)
        {
            InitializeComponent();
            this.conexao = conexao;
        }

        public UcHome()
        {
            
        }

        private void UcHome_Load(object sender, EventArgs e)
        {
            
        }

        private void labelRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void pictureAccount_Click(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void labelSemanaAtual_Click(object sender, EventArgs e)
        {

        }

        private void sataBarraEconomia_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelGastoAnt_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void sataPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sataPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sataSearchBox_Click(object sender, EventArgs e)
        {

        }

        private void labelUserClass_Click(object sender, EventArgs e)
        {

        }
        
        
        }
    }

