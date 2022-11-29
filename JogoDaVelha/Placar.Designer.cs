namespace JogoDaVelha
{
    partial class Placar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Placar));
            this.label1 = new System.Windows.Forms.Label();
            this.lbNomeX = new System.Windows.Forms.Label();
            this.lbPX = new System.Windows.Forms.Label();
            this.lbNomeO = new System.Windows.Forms.Label();
            this.lbPO = new System.Windows.Forms.Label();
            this.btNovaRodada = new System.Windows.Forms.Button();
            this.btNovoJogo = new System.Windows.Forms.Button();
            this.lbVelha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btVoltarAoJogo = new System.Windows.Forms.Button();
            this.btSairr = new System.Windows.Forms.Button();
            this.lbTotalPlayed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placar";
            // 
            // lbNomeX
            // 
            this.lbNomeX.AutoSize = true;
            this.lbNomeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(130)))), ((int)(((byte)(189)))));
            this.lbNomeX.Location = new System.Drawing.Point(9, 56);
            this.lbNomeX.Name = "lbNomeX";
            this.lbNomeX.Size = new System.Drawing.Size(15, 13);
            this.lbNomeX.TabIndex = 1;
            this.lbNomeX.Text = "X";
            // 
            // lbPX
            // 
            this.lbPX.AutoSize = true;
            this.lbPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(130)))), ((int)(((byte)(189)))));
            this.lbPX.Location = new System.Drawing.Point(283, 56);
            this.lbPX.Name = "lbPX";
            this.lbPX.Size = new System.Drawing.Size(15, 13);
            this.lbPX.TabIndex = 2;
            this.lbPX.Text = "X";
            // 
            // lbNomeO
            // 
            this.lbNomeO.AutoSize = true;
            this.lbNomeO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(60)))), ((int)(((byte)(107)))));
            this.lbNomeO.Location = new System.Drawing.Point(9, 87);
            this.lbNomeO.Name = "lbNomeO";
            this.lbNomeO.Size = new System.Drawing.Size(15, 13);
            this.lbNomeO.TabIndex = 3;
            this.lbNomeO.Text = "X";
            // 
            // lbPO
            // 
            this.lbPO.AutoSize = true;
            this.lbPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(60)))), ((int)(((byte)(107)))));
            this.lbPO.Location = new System.Drawing.Point(283, 87);
            this.lbPO.Name = "lbPO";
            this.lbPO.Size = new System.Drawing.Size(15, 13);
            this.lbPO.TabIndex = 4;
            this.lbPO.Text = "X";
            // 
            // btNovaRodada
            // 
            this.btNovaRodada.BackColor = System.Drawing.Color.DimGray;
            this.btNovaRodada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btNovaRodada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovaRodada.Location = new System.Drawing.Point(12, 188);
            this.btNovaRodada.Name = "btNovaRodada";
            this.btNovaRodada.Size = new System.Drawing.Size(107, 36);
            this.btNovaRodada.TabIndex = 5;
            this.btNovaRodada.Text = "&Nova Rodada";
            this.btNovaRodada.UseVisualStyleBackColor = false;
            this.btNovaRodada.Visible = false;
            this.btNovaRodada.Click += new System.EventHandler(this.btNovaRodada_Click);
            // 
            // btNovoJogo
            // 
            this.btNovoJogo.BackColor = System.Drawing.Color.DimGray;
            this.btNovoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btNovoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoJogo.Location = new System.Drawing.Point(125, 188);
            this.btNovoJogo.Name = "btNovoJogo";
            this.btNovoJogo.Size = new System.Drawing.Size(107, 36);
            this.btNovoJogo.TabIndex = 6;
            this.btNovoJogo.Text = "&Novo Jogo";
            this.btNovoJogo.UseVisualStyleBackColor = false;
            this.btNovoJogo.Visible = false;
            this.btNovoJogo.Click += new System.EventHandler(this.btNovoJogo_Click);
            // 
            // lbVelha
            // 
            this.lbVelha.AutoSize = true;
            this.lbVelha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVelha.Location = new System.Drawing.Point(283, 122);
            this.lbVelha.Name = "lbVelha";
            this.lbVelha.Size = new System.Drawing.Size(14, 13);
            this.lbVelha.TabIndex = 9;
            this.lbVelha.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantidade de vezes que deu velha";
            // 
            // btVoltarAoJogo
            // 
            this.btVoltarAoJogo.BackColor = System.Drawing.Color.DimGray;
            this.btVoltarAoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btVoltarAoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltarAoJogo.Location = new System.Drawing.Point(286, 188);
            this.btVoltarAoJogo.Name = "btVoltarAoJogo";
            this.btVoltarAoJogo.Size = new System.Drawing.Size(107, 36);
            this.btVoltarAoJogo.TabIndex = 10;
            this.btVoltarAoJogo.Text = "&Voltar Ao Jogo";
            this.btVoltarAoJogo.UseVisualStyleBackColor = false;
            this.btVoltarAoJogo.Visible = false;
            this.btVoltarAoJogo.Click += new System.EventHandler(this.btVoltarAoJogo_Click);
            // 
            // btSairr
            // 
            this.btSairr.BackColor = System.Drawing.Color.Red;
            this.btSairr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSairr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSairr.Location = new System.Drawing.Point(369, 12);
            this.btSairr.Name = "btSairr";
            this.btSairr.Size = new System.Drawing.Size(25, 23);
            this.btSairr.TabIndex = 11;
            this.btSairr.Text = "X";
            this.btSairr.UseVisualStyleBackColor = false;
            this.btSairr.Click += new System.EventHandler(this.btSairr_Click);
            // 
            // lbTotalPlayed
            // 
            this.lbTotalPlayed.AutoSize = true;
            this.lbTotalPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPlayed.Location = new System.Drawing.Point(283, 158);
            this.lbTotalPlayed.Name = "lbTotalPlayed";
            this.lbTotalPlayed.Size = new System.Drawing.Size(14, 13);
            this.lbTotalPlayed.TabIndex = 13;
            this.lbTotalPlayed.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total de partidas jogadas";
            // 
            // Placar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(406, 234);
            this.Controls.Add(this.lbTotalPlayed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSairr);
            this.Controls.Add(this.btVoltarAoJogo);
            this.Controls.Add(this.lbVelha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btNovoJogo);
            this.Controls.Add(this.btNovaRodada);
            this.Controls.Add(this.lbPO);
            this.Controls.Add(this.lbNomeO);
            this.Controls.Add(this.lbPX);
            this.Controls.Add(this.lbNomeX);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Placar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Placar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Placar_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNomeX;
        private System.Windows.Forms.Label lbPX;
        private System.Windows.Forms.Label lbNomeO;
        private System.Windows.Forms.Label lbPO;
        private System.Windows.Forms.Button btNovaRodada;
        private System.Windows.Forms.Button btNovoJogo;
        private System.Windows.Forms.Label lbVelha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btVoltarAoJogo;
        private System.Windows.Forms.Button btSairr;
        private System.Windows.Forms.Label lbTotalPlayed;
        private System.Windows.Forms.Label label4;
    }
}