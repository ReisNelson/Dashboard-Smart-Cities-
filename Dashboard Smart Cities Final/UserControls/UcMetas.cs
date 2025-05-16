using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_Smart_Cities_Final.UserControls
{
    public partial class UcMetas : UserControl
    {
        public UcMetas(MySqlConnector.MySqlConnection conexao)
        {
            InitializeComponent();
        }

        private void UcMetas_Load(object sender, EventArgs e)
        {

        }

        private void labelMetas_Click(object sender, EventArgs e)
        {

        }

        private int metaCount = 0; // Adicione este campo na sua classe, se ainda não existir

        private void btnSetGoal_Click(object sender, EventArgs e)
        {
            string goalName = textGoalName.Text.Trim(); // Corrigido aqui

            if (string.IsNullOrEmpty(goalName))
            {
                MessageBox.Show("Digite um nome para a meta.");
                return;
            }

            // Criação do painel da meta
            Panel panel = new Panel();
            panel.Width = pnlContainer.Width - 40;
            panel.Height = 100;
            panel.BackColor = Color.FromArgb(35, 35, 40);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Top = metaCount * (panel.Height + 15);
            panel.Left = 10;
            panel.Margin = new Padding(10);

            // Label da meta
            Label lbl = new Label();
            lbl.Text = goalName;
            lbl.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lbl.ForeColor = Color.White;
            lbl.AutoSize = true;
            lbl.Top = 10;
            lbl.Left = 15;

            // ProgressBar
            ProgressBar progress = new ProgressBar();
            progress.Width = 300;
            progress.Height = 20;
            progress.Value = 0;
            progress.Top = 45;
            progress.Left = 15;
            progress.ForeColor = Color.Green;

            // Botão de concluir
            Button btnDone = new Button();
            btnDone.Text = "Concluir";
            btnDone.Width = 100;
            btnDone.Height = 30;
            btnDone.Top = 40;
            btnDone.Left = progress.Right + 20;
            btnDone.BackColor = Color.FromArgb(60, 200, 100);
            btnDone.ForeColor = Color.White;
            btnDone.FlatStyle = FlatStyle.Flat;
            btnDone.Click += (s, ev) => progress.Value = 100;

            // Botão de remover
            Button btnRemove = new Button();
            btnRemove.Text = "Remover";
            btnRemove.Width = 100;
            btnRemove.Height = 30;
            btnRemove.Top = 40;
            btnRemove.Left = btnDone.Right + 10;
            btnRemove.BackColor = Color.FromArgb(200, 60, 60);
            btnRemove.ForeColor = Color.White;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Click += (s, ev) =>
            {
                pnlContainer.Controls.Remove(panel);
                metaCount--;
                ReorganizarMetas();
            };

            // Adiciona os controles ao painel
            panel.Controls.Add(lbl);
            panel.Controls.Add(progress);
            panel.Controls.Add(btnDone);
            panel.Controls.Add(btnRemove);

            // Adiciona o painel ao container
            pnlContainer.Controls.Add(panel);

            metaCount++;
            textGoalName.Text = ""; // Corrigido aqui
        }

        // Método para reorganizar as metas após remoção
        private void ReorganizarMetas()
        {
            int y = 0;
            foreach (Control ctrl in pnlContainer.Controls)
            {
                if (ctrl is Panel panel)
                {
                    panel.Top = y;
                    y += panel.Height + 15;
                }
            }
        }
    }
}