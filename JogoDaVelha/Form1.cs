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
    public partial class Form1 : Form
    {
        Vars v = new Vars();
        Tabuleiro tabu;
        public Form1()
        {

            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Tem certeza que deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Tem certeza que deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txtNomeX.Clear();
            txtNomeO.Clear();
            rbtO.Checked = false;
            rbtX.Checked = false;
        }

        public void btJogar_Click(object sender, EventArgs e)
        {
            if (txtNomeO.Text == "")
            {
                v.nomeO = "Jogador O";
            }
            else
            {
                v.nomeO = txtNomeO.Text;
            }
            if (txtNomeX.Text == "")
            {
                v.nomeX = "Jogador X";
            }
            else
            {
                v.nomeX = txtNomeX.Text;
            }
            if ((rbtX.Checked == true) || (rbtO.Checked == true))
            {
                if (rbtX.Checked == true)
                {
                    v.vez = true;
                }
                else
                {
                    v.vez = false;
                }
            }
            else
            {
                Random sortear = new Random();
                int resultado_sorteio = sortear.Next(1, 100);
                if ((resultado_sorteio % 2) == 0)
                {
                    v.vez = true;
                }
                else
                {
                    v.vez = false;
                }
            }
            tabu = new Tabuleiro(v.nomeO, v.nomeX, v.vez, 0, 0, 0,false);
            tabu.Show();
            this.Hide();
        }
        private void btJogarAI_Click(object sender, EventArgs e)
        {
            Dificuldade d = new Dificuldade();
            d.ShowDialog();
            if (txtNomeX.Text == "")
            {
                v.nomeX = "Jogador";
            }
            else
            {
                v.nomeX = txtNomeX.Text;
            }
            v.nomeO = "Inteligência Artifical (IA)";
            if ((rbtX.Checked == true) || (rbtO.Checked == true))
            {
                if (rbtX.Checked == true)
                {
                    v.vez = true;
                }
                else
                {
                    v.vez = false;
                }
            }
            else
            {
                Random sortear = new Random();
                int resultado_sorteio = sortear.Next(1, 100);
                if ((resultado_sorteio % 2) == 0)
                {
                    v.vez = true;
                }
                else
                {
                    v.vez = false;
                }
            }
            Hide();
            tabu = new Tabuleiro(v.nomeO, v.nomeX, v.vez, 0, 0, 0, true);
            tabu.Show();
        }
    }
}
