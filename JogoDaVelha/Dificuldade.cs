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
    public partial class Dificuldade : Form
    {
        public static int Dificuldade_AI;
        public Dificuldade()
        {
            InitializeComponent();
        }

        private void rbFacil_CheckedChanged(object sender, EventArgs e)
        {
            Dificuldade_AI = 0;
        }

        private void btConfirmarDifi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbMedio_CheckedChanged(object sender, EventArgs e)
        {
            Dificuldade_AI = 1;
        }

        private void rbImpossivel_CheckedChanged(object sender, EventArgs e)
        {
            Dificuldade_AI = 2;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Tem certeza que deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
    }
}
