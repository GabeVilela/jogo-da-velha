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
    public partial class Tabuleiro : Form
    {
        Vars v = new Vars();
        Form1 f = new Form1();
        Placar p;
        Dificuldade d = new Dificuldade();
        public bool PlaystationTheme = true;
        private Object thislock = new Object();
        public string nomeO, nomeX;
        int contador = 0, open, pontosX, pontosO, velha;
        public bool vez, AI;
        public int cont = 0;
        public Tabuleiro(string imp_nomeO, string imp_nomeX, bool imp_vez, int imp_pontosX, int imp_pontosO, int imp_velha, bool imp_AI)
        {
            InitializeComponent();
            if (v.reset == true)
            {
                v.reset = false;
                Reset(this);
            }
            if (v.rodada == true)
            {
                v.rodada = false;
                Clear(this);
            }
            this.vez = imp_vez;
            this.nomeO = imp_nomeO;
            this.nomeX = imp_nomeX;
            this.pontosX = imp_pontosX;
            this.pontosO = imp_pontosO;
            this.velha = imp_velha;
            this.AI = imp_AI;
            if((AI == true)&&(vez == false))
            {
                LookAI();
            }
            Indicador_de_Vez();
        }

        private void btT11_Click(object sender, EventArgs e)
        {
            btT11.Text = If1();
            btT11.Enabled = false;
            SomaVez();
        }
        public string If1()
        {
            if (vez)
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }

        private void btT12_Click(object sender, EventArgs e)
        {
            btT12.Text = If1();
            btT12.Enabled = false;
            SomaVez();
        }

        private void btT13_Click(object sender, EventArgs e)
        {
            btT13.Text = If1();
            btT13.Enabled = false;
            SomaVez();
        }

        private void btT21_Click(object sender, EventArgs e)
        {
            btT21.Text = If1();
            btT21.Enabled = false;
            SomaVez();
        }

        private void btT22_Click(object sender, EventArgs e)
        {
            btT22.Text = If1();
            btT22.Enabled = false;
            SomaVez();
        }

        private void btT23_Click(object sender, EventArgs e)
        {
            btT23.Text = If1();
            btT23.Enabled = false;
            SomaVez();
        }

        private void btT31_Click(object sender, EventArgs e)
        {
            btT31.Text = If1();
            btT31.Enabled = false;
            SomaVez();
        }

        private void btT32_Click(object sender, EventArgs e)
        {
            btT32.Text = If1();
            btT32.Enabled = false;
            SomaVez();
        }
        private void novaPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Esta partida será contada como velha e você perderá a sua vez.", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)) == DialogResult.Yes)
            {
                velha++;
                Clear(this);
                if (vez == true)
                {
                    vez = false;
                    if (AI == true)
                    {
                        LookAI();
                    }
                }
                else
                {
                    vez = true;
                }
                Indicador_de_Vez();
            }
        }

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("O jogo será reiniciado\nTem certeza que deseja continuar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)) == DialogResult.Yes)
            {
                Reset(this);
            }
        }

        private void btT33_Click(object sender, EventArgs e)
        {
            btT33.Text = If1();
            btT33.Enabled = false;
            SomaVez();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Tem certeza que deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void Tabuleiro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Tem certeza que deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
        public void TrocarCor(Control c)
        {
            foreach (Control v in c.Controls)
            {
                if (v is Button)
                {
                    if (v.Text == "X")
                    {
                        v.BackColor = Color.FromArgb(74,130,189);
                    }
                    else if (v.Text == "O")
                    {
                        v.BackColor = Color.FromArgb(239,60,107);
                    }
                    else
                    {
                        v.BackColor = Color.DimGray;
                    }
                    
                }
            }
        }
        private void placarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Enquanto o placar estiver aberto, o tabuleiro será bloqueado.", "Lembre-se!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)) == DialogResult.OK)
            {
                Lock(this);
            }
        }
        public void SomaVez()
        {
            TrocarCor(this);
            contador++;
            menuStrip1.Focus();
            //horizontal
            if ((btT11.Text != "") && (btT11.Text == btT12.Text) && (btT12.Text == btT13.Text))
            {
                Mensagem();
            }
            else if ((btT21.Text != "") && (btT21.Text == btT22.Text) && (btT22.Text == btT23.Text))
            {
                Mensagem();
            }
            else if ((btT31.Text != "") && (btT31.Text == btT32.Text) && (btT32.Text == btT33.Text))
            {
                Mensagem();
            }
            //vertical
            else if ((btT11.Text != "") && (btT11.Text == btT21.Text) && (btT21.Text == btT31.Text))
            {
                Mensagem();
            }
            else if ((btT12.Text != "") && (btT12.Text == btT22.Text) && (btT22.Text == btT32.Text))
            {
                Mensagem();
            }
            else if ((btT13.Text != "") && (btT13.Text == btT23.Text) && (btT23.Text == btT33.Text))
            {
                Mensagem();
            }
            //diagonal
            else if ((btT11.Text != "") && (btT11.Text == btT22.Text) && (btT22.Text == btT33.Text))
            {
                Mensagem();
            }
            else if ((btT13.Text != "") && (btT13.Text == btT22.Text) && (btT22.Text == btT31.Text))
            {
                Mensagem();
            }
            else if (contador == 9)
            {
                velha++;
                MessageBox.Show("Deu velha!", "Empate", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (vez == true)
                {
                    vez = false;
                }
                else if (vez == false)
                {
                    vez = true;
                }
                Hide();
                open = 0;
                p = new Placar(nomeO, nomeX, pontosO, pontosX, velha, open, vez,AI);
                p.Show();
            }
            else if (vez)
            {
                vez = false;
                if (AI == true)
                {
                    IA();
                }
                else if (AI == true)
                {
                    LookAI();
                    cont++;
                }
            }
            else if (vez == false)
            {
                vez = true;
            }
            Indicador_de_Vez();
        }
        public void Indicador_de_Vez()
        {
            if (vez)
            {
                lbVez.Text = ((nomeX.ToString()) + ", X");
                lbVez.ForeColor = Color.FromArgb(74, 130, 189);
            }
            else
            {
                lbVez.Text = ((nomeO.ToString()) + ", O");
                lbVez.ForeColor = Color.FromArgb(239, 60, 107);
            }
        }
        public void Mensagem()
        {
            if (vez == true)
            {
                pontosX++;
                MessageBox.Show(nomeX + " ganhou!\nTotalizando " + pontosX + " pontos.", "Fim da partida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pontosO++;
                MessageBox.Show(nomeO + " ganhou!\nTotalizando " + pontosO + " pontos.", "Fim da partida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Hide();
            open = 0;
            p = new Placar(nomeO, nomeX, pontosO, pontosX, velha, open, vez, AI);
            p.Show();
        }
        public void Clear(Control v)
        {
            foreach (Control c in v.Controls)
            {
                if (c is Button)
                {
                    c.Text = "";
                    c.Enabled = true;
                }
            }
            contador = 0;
            TrocarCor(this);
        }
        public void Reset(Control c)
        {
            foreach (Control v in c.Controls)
            {
                if (v is Button)
                {
                    v.Text = "";
                    v.BackColor = Color.DimGray;
                    v.Enabled = true;
                }
            }
            contador = 0;
            pontosO = 0;
            pontosX = 0;
            velha = 0;
            nomeO = "";
            nomeX = "";
            Hide();
            f.Show();
        }
        public void Lock(Control c)
        {
            open = 1;
            p = new Placar(nomeO, nomeX, pontosO, pontosX, velha, open, vez,AI);
            p.ShowDialog();
        }
        public void IA()
        {
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //Escolhendo dificuldade
            //caso não seja facil nem medio, ele inicia a verdadeira IA
            if (Dificuldade.Dificuldade_AI == 0)
            {
                IAFacil();
            }
            else if (Dificuldade.Dificuldade_AI == 1)
            {
                IAMedia();
            }
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //PROCURANDO POR POSSIBILIDADES DE VENCER
            //Primeira linha
            else if ((btT11.Text == "") && (btT12.Text == "O") && (btT12.Text == btT13.Text))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT12.Text == "") && (btT11.Text == "O") && (btT11.Text == btT13.Text))
            {
                btT12.Text = If1();
                btT12.Enabled = false;
                SomaVez();
            }
            else if ((btT13.Text == "") && (btT12.Text == "O") && (btT12.Text == btT11.Text))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            //segunda linha
            else if ((btT21.Text == "") && (btT22.Text == "O") && (btT22.Text == btT23.Text))
            {
                btT21.Text = If1();
                btT21.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT21.Text == "O") && (btT21.Text == btT23.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT23.Text == "") && (btT22.Text == "O") && (btT22.Text == btT21.Text))
            {
                btT23.Text = If1();
                btT23.Enabled = false;
                SomaVez();
            }
            //terceira linha
            else if ((btT31.Text == "") && (btT32.Text == "O") && (btT32.Text == btT33.Text))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if ((btT32.Text == "") && (btT31.Text == "O") && (btT31.Text == btT33.Text))
            {
                btT32.Text = If1();
                btT32.Enabled = false;
                SomaVez();
            }
            else if ((btT33.Text == "") && (btT32.Text == "O") && (btT32.Text == btT31.Text))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            //primeira coluna
            else if ((btT11.Text == "") && (btT21.Text == "O") && (btT21.Text == btT31.Text))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT21.Text == "") && (btT11.Text == "O") && (btT11.Text == btT31.Text))
            {
                btT21.Text = If1();
                btT21.Enabled = false;
                SomaVez();
            }
            else if ((btT31.Text == "") && (btT11.Text == "O") && (btT11.Text == btT21.Text))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            //segunda coluna
            else if ((btT12.Text == "") && (btT22.Text == "O") && (btT22.Text == btT32.Text))
            {
                btT12.Text = If1();
                btT12.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT12.Text == "O") && (btT12.Text == btT32.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT32.Text == "") && (btT12.Text == "O") && (btT12.Text == btT22.Text))
            {
                btT32.Text = If1();
                btT32.Enabled = false;
                SomaVez();
            }
            //terceira coluna
            else if ((btT13.Text == "") && (btT23.Text == "O") && (btT23.Text == btT33.Text))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            else if ((btT23.Text == "") && (btT13.Text == "O") && (btT13.Text == btT33.Text))
            {
                btT23.Text = If1();
                btT23.Enabled = false;
                SomaVez();
            }
            else if ((btT33.Text == "") && (btT13.Text == "O") && (btT13.Text == btT23.Text))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            //diagonal cima esq. à baixo dir.
            else if ((btT11.Text == "") && (btT22.Text == "O") && (btT22.Text == btT33.Text))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT11.Text == "O") && (btT11.Text == btT33.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT33.Text == "") && (btT11.Text == "O") && (btT11.Text == btT22.Text))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            //diagonal baixo esq. à cima dir.
            else if ((btT31.Text == "") && (btT22.Text == "O") && (btT22.Text == btT13.Text))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT31.Text == "O") && (btT31.Text == btT13.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT13.Text == "") && (btT31.Text == "O") && (btT31.Text == btT22.Text))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //PROCURANDO POR POSSIBILIDADES DE BLOQUEAR O USUARIO
            //Primeira linha
            else if ((btT11.Text == "") && (btT12.Text == "X") && (btT12.Text == btT13.Text))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT12.Text == "") && (btT11.Text == "X") && (btT11.Text == btT13.Text))
            {
                btT12.Text = If1();
                btT12.Enabled = false;
                SomaVez();
            }
            else if ((btT13.Text == "") && (btT12.Text == "X") && (btT12.Text == btT11.Text))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            //segunda linha
            else if ((btT21.Text == "") && (btT22.Text == "X") && (btT22.Text == btT23.Text))
            {
                btT21.Text = If1();
                btT21.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT21.Text == "X") && (btT21.Text == btT23.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT23.Text == "") && (btT22.Text == "X") && (btT22.Text == btT21.Text))
            {
                btT23.Text = If1();
                btT23.Enabled = false;
                SomaVez();
            }
            //terceira linha
            else if ((btT31.Text == "") && (btT32.Text == "X") && (btT32.Text == btT33.Text))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if ((btT32.Text == "") && (btT31.Text == "X") && (btT31.Text == btT33.Text))
            {
                btT32.Text = If1();
                btT32.Enabled = false;
                SomaVez();
            }
            else if ((btT33.Text == "") && (btT32.Text == "X") && (btT32.Text == btT31.Text))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            //primeira coluna
            else if ((btT11.Text == "") && (btT21.Text == "X") && (btT21.Text == btT31.Text))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT21.Text == "") && (btT11.Text == "X") && (btT11.Text == btT31.Text))
            {
                btT21.Text = If1();
                btT21.Enabled = false;
                SomaVez();
            }
            else if ((btT31.Text == "") && (btT11.Text == "X") && (btT11.Text == btT21.Text))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            //segunda coluna
            else if ((btT12.Text == "") && (btT22.Text == "X") && (btT22.Text == btT32.Text))
            {
                btT12.Text = If1();
                btT12.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT12.Text == "X") && (btT12.Text == btT32.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT32.Text == "") && (btT12.Text == "X") && (btT12.Text == btT22.Text))
            {
                btT32.Text = If1();
                btT32.Enabled = false;
                SomaVez();
            }
            //terceira coluna
            else if ((btT13.Text == "") && (btT23.Text == "X") && (btT23.Text == btT33.Text))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            else if ((btT23.Text == "") && (btT13.Text == "X") && (btT13.Text == btT33.Text))
            {
                btT23.Text = If1();
                btT23.Enabled = false;
                SomaVez();
            }
            else if ((btT33.Text == "") && (btT13.Text == "X") && (btT13.Text == btT23.Text))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            //diagonal cima esq. à baixo dir.
            else if ((btT11.Text == "") && (btT22.Text == "X") && (btT22.Text == btT33.Text))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT11.Text == "X") && (btT11.Text == btT33.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT33.Text == "") && (btT11.Text == "X") && (btT11.Text == btT22.Text))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            //diagonal baixo esq. à cima dir.
            else if ((btT31.Text == "") && (btT22.Text == "X") && (btT22.Text == btT13.Text))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT31.Text == "X") && (btT31.Text == btT13.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT13.Text == "") && (btT31.Text == "X") && (btT31.Text == btT22.Text))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //TRECHO EXTRA 
            //Evitando cair em algumas BAITS
            else if ((btT11.Text == "") && (btT12.Text == "") && (btT13.Text == "") && (btT21.Text == "") && (btT22.Text == "X") && (btT23.Text == "") && (btT31.Text == "") && (btT32.Text == "") && (btT33.Text == ""))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "X") && (btT12.Text == "") && (btT13.Text == "O") && (btT21.Text == "") && (btT22.Text == "X") && (btT23.Text == "") && (btT31.Text == "") && (btT32.Text == "") && (btT33.Text == ""))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "") && (btT12.Text == "") && (btT13.Text == "O") && (btT21.Text == "") && (btT22.Text == "X") && (btT23.Text == "") && (btT31.Text == "") && (btT32.Text == "") && (btT33.Text == "X"))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "") && (btT12.Text == "") && (btT13.Text == "O") && (btT21.Text == "") && (btT22.Text == "X") && (btT23.Text == "") && (btT31.Text == "X") && (btT32.Text == "") && (btT33.Text == ""))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "") && (btT12.Text == "X") && (btT13.Text == "") && (btT21.Text == "") && (btT22.Text == "O") && (btT23.Text == "") && (btT31.Text == "") && (btT32.Text == "") && (btT33.Text == "X"))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "X") && (btT12.Text == "") && (btT13.Text == "") && (btT21.Text == "") && (btT22.Text == "O") && (btT23.Text == "X") && (btT31.Text == "") && (btT32.Text == "") && (btT33.Text == ""))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();

            }
            else if ((btT11.Text == "") && (btT12.Text == "") && (btT13.Text == "") && (btT21.Text == "") && (btT22.Text == "O") && (btT23.Text == "") && (btT31.Text == "X") && (btT32.Text == "") && (btT33.Text == ""))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "X") && (btT12.Text == "") && (btT13.Text == "") && (btT21.Text == "") && (btT22.Text == "O") && (btT23.Text == "") && (btT31.Text == "") && (btT32.Text == "") && (btT33.Text == ""))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "") && (btT12.Text == "") && (btT13.Text == "X") && (btT21.Text == "") && (btT22.Text == "O") && (btT23.Text == "") && (btT31.Text == "") && (btT32.Text == "") && (btT33.Text == ""))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "") && (btT12.Text == "") && (btT13.Text == "") && (btT21.Text == "X") && (btT22.Text == "O") && (btT23.Text == "") && (btT31.Text == "") && (btT32.Text == "") && (btT33.Text == ""))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "") && (btT12.Text == "") && (btT13.Text == "") && (btT21.Text == "") && (btT22.Text == "O") && (btT23.Text == "X") && (btT31.Text == "") && (btT32.Text == "") && (btT33.Text == ""))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "") && (btT12.Text == "") && (btT13.Text == "") && (btT21.Text == "") && (btT22.Text == "O") && (btT23.Text == "") && (btT31.Text == "") && (btT32.Text == "") && (btT33.Text == "X"))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "") && (btT12.Text == "") && (btT13.Text == "") && (btT21.Text == "") && (btT22.Text == "O") && (btT23.Text == "X") && (btT31.Text == "X") && (btT32.Text == "") && (btT33.Text == ""))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "") && (btT12.Text == "X") && (btT13.Text == "") && (btT21.Text == "") && (btT22.Text == "O") && (btT23.Text == "") && (btT31.Text == "X") && (btT32.Text == "") && (btT33.Text == ""))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "") && (btT12.Text == "X") && (btT13.Text == "") && (btT21.Text == "") && (btT22.Text == "O") && (btT23.Text == "") && (btT31.Text == "") && (btT32.Text == "") && (btT33.Text == ""))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "X") && (btT33.Text == "X") && (btT13.Text == ""))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            else if ((btT21.Text == "X") && (btT12.Text == "X") && (btT22.Text == ""))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "O") && (btT22.Text == "X") && (btT32.Text == ""))
            {
                btT32.Text = If1();
                btT32.Enabled = false;
                SomaVez();
            }
            else if (((btT11.Text == "X") || (btT13.Text == "X") || (btT31.Text == "X") || (btT33.Text == "X")) && (btT22.Text == ""))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "") && (btT12.Text == "X") && (btT13.Text == "") && (btT21.Text == "X") && (btT22.Text == "O") && (btT23.Text == "") && (btT31.Text == "") && (btT32.Text == "") && (btT33.Text == ""))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "") && (btT12.Text == "X") && (btT13.Text == "") && (btT21.Text == "") && (btT22.Text == "O") && (btT23.Text == "X") && (btT31.Text == "") && (btT32.Text == "") && (btT33.Text == ""))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "") && (btT12.Text == "") && (btT13.Text == "") && (btT21.Text == "") && (btT22.Text == "O") && (btT23.Text == "X") && (btT31.Text == "") && (btT32.Text == "X") && (btT33.Text == ""))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "") && (btT12.Text == "") && (btT13.Text == "") && (btT21.Text == "X") && (btT22.Text == "O") && (btT23.Text == "") && (btT31.Text == "") && (btT32.Text == "X") && (btT33.Text == ""))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "O") && (btT12.Text == "") && (btT13.Text == "X") && (btT21.Text == "") && (btT22.Text == "O") && (btT23.Text == "") && (btT31.Text == "") && (btT32.Text == "X") && (btT33.Text == "X"))
            {
                btT23.Text = If1();
                btT23.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "") && (btT12.Text == "") && (btT13.Text == "X") && (btT21.Text == "") && (btT22.Text == "O") && (btT23.Text == "") && (btT31.Text == "") && (btT32.Text == "X") && (btT33.Text == ""))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "X") && (btT12.Text == "") && (btT13.Text == "") && (btT21.Text == "") && (btT22.Text == "O") && (btT23.Text == "") && (btT31.Text == "") && (btT32.Text == "X") && (btT33.Text == ""))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if ((btT11.Text == "") && (btT12.Text == "X") && (btT13.Text == "") && (btT21.Text == "") && (btT22.Text == "O") && (btT23.Text == "") && (btT31.Text == "X") && (btT32.Text == "") && (btT33.Text == ""))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            //else if ((btT11.Text == "") && (btT12.Text == "") && (btT13.Text == "") && (btT21.Text == "") && (btT22.Text == "") && (btT23.Text == "") && (btT31.Text == "") && (btT32.Text == "") && (btT33.Text == ""))
            //{
            //    btT.Text = If1();
            //    btT.Enabled = false;
            //    SomaVez();
            //}
            else
            {
                LookAI();
            }
        }
        public void LookAI()
        {
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //Escolhendo dificuldade
            //caso não seja facil nem medio, ele inicia a verdadeira IA
            if (Dificuldade.Dificuldade_AI == 0)
            {
                IAFacil();
            }
            else if (Dificuldade.Dificuldade_AI == 1)
            {
                IAMedia();
            }
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------
            //PROCURANDO POR LUGARES LIVRES
            else if (btT22.Text == "")
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if (btT32.Text == "")
            {
                btT32.Text = If1();
                btT32.Enabled = false;
                SomaVez();
            }
            else if (btT11.Text == "")
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if (btT13.Text == "")
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            else if (btT31.Text == "")
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if (btT33.Text == "")
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            else if (btT12.Text == "")
            {
                btT12.Text = If1();
                btT12.Enabled = false;
                SomaVez();
            }
            else if (btT23.Text == "")
            {
                btT23.Text = If1();
                btT23.Enabled = false;
                SomaVez();
            }
            else if (btT21.Text == "")
            {
                btT21.Text = If1();
                btT21.Enabled = false;
                SomaVez();
            }
        }
        public void IAMedia()
        {
            //FAMOSO CHECKMATE (COPIADO DA IA IMPOSSIVEL)
            //Primeira linha
            if ((btT11.Text == "") && (btT12.Text == "O") && (btT12.Text == btT13.Text))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT12.Text == "") && (btT11.Text == "O") && (btT11.Text == btT13.Text))
            {
                btT12.Text = If1();
                btT12.Enabled = false;
                SomaVez();
            }
            else if ((btT13.Text == "") && (btT12.Text == "O") && (btT12.Text == btT11.Text))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            //segunda linha
            else if ((btT21.Text == "") && (btT22.Text == "O") && (btT22.Text == btT23.Text))
            {
                btT21.Text = If1();
                btT21.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT21.Text == "O") && (btT21.Text == btT23.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT23.Text == "") && (btT22.Text == "O") && (btT22.Text == btT21.Text))
            {
                btT23.Text = If1();
                btT23.Enabled = false;
                SomaVez();
            }
            //terceira linha
            else if ((btT31.Text == "") && (btT32.Text == "O") && (btT32.Text == btT33.Text))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if ((btT32.Text == "") && (btT31.Text == "O") && (btT31.Text == btT33.Text))
            {
                btT32.Text = If1();
                btT32.Enabled = false;
                SomaVez();
            }
            else if ((btT33.Text == "") && (btT32.Text == "O") && (btT32.Text == btT31.Text))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            //primeira coluna
            else if ((btT11.Text == "") && (btT21.Text == "O") && (btT21.Text == btT31.Text))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT21.Text == "") && (btT11.Text == "O") && (btT11.Text == btT31.Text))
            {
                btT21.Text = If1();
                btT21.Enabled = false;
                SomaVez();
            }
            else if ((btT31.Text == "") && (btT11.Text == "O") && (btT11.Text == btT21.Text))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            //segunda coluna
            else if ((btT12.Text == "") && (btT22.Text == "O") && (btT22.Text == btT32.Text))
            {
                btT12.Text = If1();
                btT12.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT12.Text == "O") && (btT12.Text == btT32.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT32.Text == "") && (btT12.Text == "O") && (btT12.Text == btT22.Text))
            {
                btT32.Text = If1();
                btT32.Enabled = false;
                SomaVez();
            }
            //terceira coluna
            else if ((btT13.Text == "") && (btT23.Text == "O") && (btT23.Text == btT33.Text))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            else if ((btT23.Text == "") && (btT13.Text == "O") && (btT13.Text == btT33.Text))
            {
                btT23.Text = If1();
                btT23.Enabled = false;
                SomaVez();
            }
            else if ((btT33.Text == "") && (btT13.Text == "O") && (btT13.Text == btT23.Text))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            //diagonal cima esq. à baixo dir.
            else if ((btT11.Text == "") && (btT22.Text == "O") && (btT22.Text == btT33.Text))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT11.Text == "O") && (btT11.Text == btT33.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT33.Text == "") && (btT11.Text == "O") && (btT11.Text == btT22.Text))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            //diagonal baixo esq. à cima dir.
            else if ((btT31.Text == "") && (btT22.Text == "O") && (btT22.Text == btT13.Text))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT31.Text == "O") && (btT31.Text == btT13.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT13.Text == "") && (btT31.Text == "O") && (btT31.Text == btT22.Text))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            //--------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------
            //--------------------------------------------------------------------------------
            //AQUI COMEÇA O ROTEIRO PARA COMETER ERROS
            else if (((contador == 3)||(contador == 4))&&(vez == false))
            {
                IAMedia_Bloquear();
            }
            else if (btT11.Text == "")
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if (btT13.Text == "")
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            else if (btT22.Text == "")
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if (btT31.Text == "")
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if (btT33.Text == "")
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            else if (btT12.Text == "")
            {
                btT12.Text = If1();
                btT12.Enabled = false;
                SomaVez();
            }
            else if (btT23.Text == "")
            {
                btT23.Text = If1();
                btT23.Enabled = false;
                SomaVez();
            }
            else if (btT32.Text == "")
            {
                btT32.Text = If1();
                btT32.Enabled = false;
                SomaVez();
            }
            else if (btT21.Text == "")
            {
                btT21.Text = If1();
                btT21.Enabled = false;
                SomaVez();
            }
        }
        public void IAMedia_Bloquear()
        {
            //FAMOSO NÃO-NÃO-NÃO (Copiado da IA Impossivel)
            //Ele vem aqui pois a preferencia de te bloquear é a ultima coisa
            //Primeira linha
            if ((btT11.Text == "") && (btT12.Text == "X") && (btT12.Text == btT13.Text))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT12.Text == "") && (btT11.Text == "X") && (btT11.Text == btT13.Text))
            {
                btT12.Text = If1();
                btT12.Enabled = false;
                SomaVez();
            }
            else if ((btT13.Text == "") && (btT12.Text == "X") && (btT12.Text == btT11.Text))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            //segunda linha
            else if ((btT21.Text == "") && (btT22.Text == "X") && (btT22.Text == btT23.Text))
            {
                btT21.Text = If1();
                btT21.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT21.Text == "X") && (btT21.Text == btT23.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT23.Text == "") && (btT22.Text == "X") && (btT22.Text == btT21.Text))
            {
                btT23.Text = If1();
                btT23.Enabled = false;
                SomaVez();
            }
            //terceira linha
            else if ((btT31.Text == "") && (btT32.Text == "X") && (btT32.Text == btT33.Text))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if ((btT32.Text == "") && (btT31.Text == "X") && (btT31.Text == btT33.Text))
            {
                btT32.Text = If1();
                btT32.Enabled = false;
                SomaVez();
            }
            else if ((btT33.Text == "") && (btT32.Text == "X") && (btT32.Text == btT31.Text))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            //primeira coluna
            else if ((btT11.Text == "") && (btT21.Text == "X") && (btT21.Text == btT31.Text))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT21.Text == "") && (btT11.Text == "X") && (btT11.Text == btT31.Text))
            {
                btT21.Text = If1();
                btT21.Enabled = false;
                SomaVez();
            }
            else if ((btT31.Text == "") && (btT11.Text == "X") && (btT11.Text == btT21.Text))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            //segunda coluna
            else if ((btT12.Text == "") && (btT22.Text == "X") && (btT22.Text == btT32.Text))
            {
                btT12.Text = If1();
                btT12.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT12.Text == "X") && (btT12.Text == btT32.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT32.Text == "") && (btT12.Text == "X") && (btT12.Text == btT22.Text))
            {
                btT32.Text = If1();
                btT32.Enabled = false;
                SomaVez();
            }
            //terceira coluna
            else if ((btT13.Text == "") && (btT23.Text == "X") && (btT23.Text == btT33.Text))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            else if ((btT23.Text == "") && (btT13.Text == "X") && (btT13.Text == btT33.Text))
            {
                btT23.Text = If1();
                btT23.Enabled = false;
                SomaVez();
            }
            else if ((btT33.Text == "") && (btT13.Text == "X") && (btT13.Text == btT23.Text))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            //diagonal cima esq. à baixo dir.
            else if ((btT11.Text == "") && (btT22.Text == "X") && (btT22.Text == btT33.Text))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT11.Text == "X") && (btT11.Text == btT33.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT33.Text == "") && (btT11.Text == "X") && (btT11.Text == btT22.Text))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            //diagonal baixo esq. à cima dir.
            else if ((btT31.Text == "") && (btT22.Text == "X") && (btT22.Text == btT13.Text))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT31.Text == "X") && (btT31.Text == btT13.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT13.Text == "") && (btT31.Text == "X") && (btT31.Text == btT22.Text))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            //----------------------------------------------
            //----------------------------------------------
            //----------------------------------------------
            //----------------------------------------------
            else if (btT11.Text == "")
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if (btT13.Text == "")
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            else if (btT22.Text == "")
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if (btT31.Text == "")
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if (btT33.Text == "")
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            else if (btT12.Text == "")
            {
                btT12.Text = If1();
                btT12.Enabled = false;
                SomaVez();
            }
            else if (btT23.Text == "")
            {
                btT23.Text = If1();
                btT23.Enabled = false;
                SomaVez();
            }
            else if (btT32.Text == "")
            {
                btT32.Text = If1();
                btT32.Enabled = false;
                SomaVez();
            }
            else if (btT21.Text == "")
            {
                btT21.Text = If1();
                btT21.Enabled = false;
                SomaVez();
            }
        }
        public void IAFacil()
        {
            //FAMOSO CHECKMATE (COPIADO DA IA IMPOSSIVEL)
            //Primeira linha
            if ((btT11.Text == "") && (btT12.Text == "O") && (btT12.Text == btT13.Text))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT12.Text == "") && (btT11.Text == "O") && (btT11.Text == btT13.Text))
            {
                btT12.Text = If1();
                btT12.Enabled = false;
                SomaVez();
            }
            else if ((btT13.Text == "") && (btT12.Text == "O") && (btT12.Text == btT11.Text))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            //segunda linha
            else if ((btT21.Text == "") && (btT22.Text == "O") && (btT22.Text == btT23.Text))
            {
                btT21.Text = If1();
                btT21.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT21.Text == "O") && (btT21.Text == btT23.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT23.Text == "") && (btT22.Text == "O") && (btT22.Text == btT21.Text))
            {
                btT23.Text = If1();
                btT23.Enabled = false;
                SomaVez();
            }
            //terceira linha
            else if ((btT31.Text == "") && (btT32.Text == "O") && (btT32.Text == btT33.Text))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if ((btT32.Text == "") && (btT31.Text == "O") && (btT31.Text == btT33.Text))
            {
                btT32.Text = If1();
                btT32.Enabled = false;
                SomaVez();
            }
            else if ((btT33.Text == "") && (btT32.Text == "O") && (btT32.Text == btT31.Text))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            //primeira coluna
            else if ((btT11.Text == "") && (btT21.Text == "O") && (btT21.Text == btT31.Text))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT21.Text == "") && (btT11.Text == "O") && (btT11.Text == btT31.Text))
            {
                btT21.Text = If1();
                btT21.Enabled = false;
                SomaVez();
            }
            else if ((btT31.Text == "") && (btT11.Text == "O") && (btT11.Text == btT21.Text))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            //segunda coluna
            else if ((btT12.Text == "") && (btT22.Text == "O") && (btT22.Text == btT32.Text))
            {
                btT12.Text = If1();
                btT12.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT12.Text == "O") && (btT12.Text == btT32.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT32.Text == "") && (btT12.Text == "O") && (btT12.Text == btT22.Text))
            {
                btT32.Text = If1();
                btT32.Enabled = false;
                SomaVez();
            }
            //terceira coluna
            else if ((btT13.Text == "") && (btT23.Text == "O") && (btT23.Text == btT33.Text))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            else if ((btT23.Text == "") && (btT13.Text == "O") && (btT13.Text == btT33.Text))
            {
                btT23.Text = If1();
                btT23.Enabled = false;
                SomaVez();
            }
            else if ((btT33.Text == "") && (btT13.Text == "O") && (btT13.Text == btT23.Text))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            //diagonal cima esq. à baixo dir.
            else if ((btT11.Text == "") && (btT22.Text == "O") && (btT22.Text == btT33.Text))
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT11.Text == "O") && (btT11.Text == btT33.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT33.Text == "") && (btT11.Text == "O") && (btT11.Text == btT22.Text))
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            //diagonal baixo esq. à cima dir.
            else if ((btT31.Text == "") && (btT22.Text == "O") && (btT22.Text == btT13.Text))
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if ((btT22.Text == "") && (btT31.Text == "O") && (btT31.Text == btT13.Text))
            {
                btT22.Text = If1();
                btT22.Enabled = false;
                SomaVez();
            }
            else if ((btT13.Text == "") && (btT31.Text == "O") && (btT31.Text == btT22.Text))
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            //COMEÇA AQUI A "INGENUIDADE" DA IA
            //Primeiro canto
            else if (btT11.Text == "")
            {
                btT11.Text = If1();
                btT11.Enabled = false;
                SomaVez();
            }
            else if ((btT12.Text == "")&&(btT11.Text == "O"))
            {
                btT12.Text = If1();
                btT12.Enabled = false;
                SomaVez();
            }
            else if ((btT21.Text == "")&&(btT11.Text == "O"))
            {
                btT21.Text = If1();
                btT21.Enabled = false;
                SomaVez();
            }
            //Segundo canto
            else if (btT13.Text == "")
            {
                btT13.Text = If1();
                btT13.Enabled = false;
                SomaVez();
            }
            else if ((btT12.Text == "")&&(btT13.Text == "O"))
            {
                btT12.Text = If1();
                btT12.Enabled = false;
                SomaVez();
            }
            else if ((btT23.Text == "")&&(btT13.Text == "O"))
            {
                btT23.Text = If1();
                btT23.Enabled = false;
                SomaVez();
            }
            //Terceiro canto
            else if (btT31.Text == "")
            {
                btT31.Text = If1();
                btT31.Enabled = false;
                SomaVez();
            }
            else if ((btT21.Text == "")&&(btT31.Text == "O"))
            {
                btT21.Text = If1();
                btT21.Enabled = false;
                SomaVez();
            }
            else if ((btT32.Text == "") && (btT31.Text == "O"))
            {
                btT32.Text = If1();
                btT32.Enabled = false;
                SomaVez();
            }
            //Ultimo canto
            else if (btT33.Text == "")
            {
                btT33.Text = If1();
                btT33.Enabled = false;
                SomaVez();
            }
            else if ((btT32.Text == "") && (btT31.Text == "O"))
            {
                btT32.Text = If1();
                btT32.Enabled = false;
                SomaVez();
            }
            else if ((btT23.Text == "") && (btT31.Text == "O"))
            {
                btT23.Text = If1();
                btT23.Enabled = false;
                SomaVez();
            }
        }
    }
}
