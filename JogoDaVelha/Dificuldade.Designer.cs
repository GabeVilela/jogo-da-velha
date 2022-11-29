namespace JogoDaVelha
{
    partial class Dificuldade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dificuldade));
            this.label1 = new System.Windows.Forms.Label();
            this.rbFacil = new System.Windows.Forms.RadioButton();
            this.rbMedio = new System.Windows.Forms.RadioButton();
            this.rbImpossivel = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btConfirmarDifi = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha a dificuldade da Inteligência Artificial";
            // 
            // rbFacil
            // 
            this.rbFacil.AutoSize = true;
            this.rbFacil.BackColor = System.Drawing.Color.Black;
            this.rbFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFacil.ForeColor = System.Drawing.Color.SeaGreen;
            this.rbFacil.Location = new System.Drawing.Point(12, 75);
            this.rbFacil.Name = "rbFacil";
            this.rbFacil.Size = new System.Drawing.Size(65, 24);
            this.rbFacil.TabIndex = 2;
            this.rbFacil.TabStop = true;
            this.rbFacil.Text = "Fácil";
            this.rbFacil.UseVisualStyleBackColor = false;
            this.rbFacil.CheckedChanged += new System.EventHandler(this.rbFacil_CheckedChanged);
            // 
            // rbMedio
            // 
            this.rbMedio.AutoSize = true;
            this.rbMedio.BackColor = System.Drawing.Color.Black;
            this.rbMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedio.ForeColor = System.Drawing.Color.Teal;
            this.rbMedio.Location = new System.Drawing.Point(198, 75);
            this.rbMedio.Name = "rbMedio";
            this.rbMedio.Size = new System.Drawing.Size(75, 24);
            this.rbMedio.TabIndex = 3;
            this.rbMedio.TabStop = true;
            this.rbMedio.Text = "Médio";
            this.rbMedio.UseVisualStyleBackColor = false;
            this.rbMedio.CheckedChanged += new System.EventHandler(this.rbMedio_CheckedChanged);
            // 
            // rbImpossivel
            // 
            this.rbImpossivel.AutoSize = true;
            this.rbImpossivel.BackColor = System.Drawing.Color.Black;
            this.rbImpossivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbImpossivel.ForeColor = System.Drawing.Color.IndianRed;
            this.rbImpossivel.Location = new System.Drawing.Point(377, 75);
            this.rbImpossivel.Name = "rbImpossivel";
            this.rbImpossivel.Size = new System.Drawing.Size(71, 24);
            this.rbImpossivel.TabIndex = 4;
            this.rbImpossivel.TabStop = true;
            this.rbImpossivel.Text = "Difícil";
            this.rbImpossivel.UseVisualStyleBackColor = false;
            this.rbImpossivel.CheckedChanged += new System.EventHandler(this.rbImpossivel_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "A inteligência cairá na maioria\r\ndas estratégias possíveis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(195, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ela utilizará algumas\r\nestratégias básicas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(374, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "O maior desafio\r\ndisponível";
            // 
            // btConfirmarDifi
            // 
            this.btConfirmarDifi.BackColor = System.Drawing.Color.DimGray;
            this.btConfirmarDifi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btConfirmarDifi.ForeColor = System.Drawing.Color.White;
            this.btConfirmarDifi.Location = new System.Drawing.Point(421, 152);
            this.btConfirmarDifi.Name = "btConfirmarDifi";
            this.btConfirmarDifi.Size = new System.Drawing.Size(75, 23);
            this.btConfirmarDifi.TabIndex = 8;
            this.btConfirmarDifi.Text = "&Confirmar";
            this.btConfirmarDifi.UseVisualStyleBackColor = false;
            this.btConfirmarDifi.Click += new System.EventHandler(this.btConfirmarDifi_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.DimGray;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(15, 152);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 9;
            this.btSair.Text = "&Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // Dificuldade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(508, 190);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btConfirmarDifi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbImpossivel);
            this.Controls.Add(this.rbMedio);
            this.Controls.Add(this.rbFacil);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dificuldade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dificuldade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFacil;
        private System.Windows.Forms.RadioButton rbMedio;
        private System.Windows.Forms.RadioButton rbImpossivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btConfirmarDifi;
        private System.Windows.Forms.Button btSair;
    }
}