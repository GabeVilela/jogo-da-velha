using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Placar : Form
    {
        Vars v = new Vars();
        Form1 f = new Form1();
        Tabuleiro tab;
        string nomeO, nomeX;
        int pontosO, pontosX, velha, open;
        bool vez, AI;

        public Placar(string imp_nomeO, string imp_nomeX, int imp_pontosO, int imp_pontosX, int imp_velha, int imp_open, bool imp_vez, bool imp_AI)
        {
            InitializeComponent();
            this.pontosO = imp_pontosO;
            this.pontosX = imp_pontosX;
            this.nomeO = imp_nomeO;
            this.nomeX = imp_nomeX;
            this.velha = imp_velha;
            this.open = imp_open;
            this.vez = imp_vez;
            this.AI = imp_AI;
            lbNomeO.Text = nomeO;
            lbNomeX.Text = nomeX;
            lbPO.Text = Convert.ToString(pontosO);
            lbPX.Text = Convert.ToString(pontosX);
            lbVelha.Text = Convert.ToString(velha);
            lbTotalPlayed.Text = (pontosO + pontosX + velha).ToString();
            if (open == 1)
            {
                btNovaRodada.Visible = false;
                btNovoJogo.Visible = false;
                btVoltarAoJogo.Visible = true;
            }
            else
            {
                btNovaRodada.Visible = true;
                btNovoJogo.Visible = true;
                btVoltarAoJogo.Visible = false;
            }
        }

        private void btSairr_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Tem certeza que deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void Placar_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btVoltarAoJogo_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btNovoJogo_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("O jogo será reiniciado\nTem certeza que deseja continuar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)) == DialogResult.Yes)
            {
                Hide();
                v.reset = true;
                f.Show();
            }
        }

        private void btNovaRodada_Click(object sender, EventArgs e)
        {
            if (vez == true)
            {
                Hide();
                v.rodada = true;
                tab = new Tabuleiro(nomeO, nomeX, true, pontosX, pontosO, velha, AI);
                tab.Show();
            }
            else
            {
                Hide();
                v.rodada = true;
                tab = new Tabuleiro(nomeO, nomeX, false, pontosX, pontosO, velha, AI);
                tab.Show();
            }
        }
    }
}
