namespace JogoDaVelha
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeX = new System.Windows.Forms.TextBox();
            this.rbtX = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtO = new System.Windows.Forms.RadioButton();
            this.txtNomeO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btJogar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btJogarAI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do jogador X";
            // 
            // txtNomeX
            // 
            this.txtNomeX.BackColor = System.Drawing.Color.DimGray;
            this.txtNomeX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeX.ForeColor = System.Drawing.Color.White;
            this.txtNomeX.Location = new System.Drawing.Point(117, 9);
            this.txtNomeX.MaxLength = 30;
            this.txtNomeX.Name = "txtNomeX";
            this.txtNomeX.Size = new System.Drawing.Size(236, 20);
            this.txtNomeX.TabIndex = 1;
            // 
            // rbtX
            // 
            this.rbtX.AutoSize = true;
            this.rbtX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtX.ForeColor = System.Drawing.Color.White;
            this.rbtX.Location = new System.Drawing.Point(15, 87);
            this.rbtX.Name = "rbtX";
            this.rbtX.Size = new System.Drawing.Size(73, 17);
            this.rbtX.TabIndex = 2;
            this.rbtX.TabStop = true;
            this.rbtX.Text = "Jogador X";
            this.rbtX.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quem começa?";
            // 
            // rbtO
            // 
            this.rbtO.AutoSize = true;
            this.rbtO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtO.ForeColor = System.Drawing.Color.White;
            this.rbtO.Location = new System.Drawing.Point(15, 110);
            this.rbtO.Name = "rbtO";
            this.rbtO.Size = new System.Drawing.Size(172, 17);
            this.rbtO.TabIndex = 4;
            this.rbtO.TabStop = true;
            this.rbtO.Text = "Jogador O/Inteligência Artificial";
            this.rbtO.UseVisualStyleBackColor = true;
            // 
            // txtNomeO
            // 
            this.txtNomeO.BackColor = System.Drawing.Color.DimGray;
            this.txtNomeO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeO.ForeColor = System.Drawing.Color.White;
            this.txtNomeO.Location = new System.Drawing.Point(117, 35);
            this.txtNomeO.MaxLength = 30;
            this.txtNomeO.Name = "txtNomeO";
            this.txtNomeO.Size = new System.Drawing.Size(236, 20);
            this.txtNomeO.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome do jogador O";
            // 
            // btJogar
            // 
            this.btJogar.BackColor = System.Drawing.Color.DimGray;
            this.btJogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJogar.ForeColor = System.Drawing.Color.White;
            this.btJogar.Location = new System.Drawing.Point(15, 133);
            this.btJogar.Name = "btJogar";
            this.btJogar.Size = new System.Drawing.Size(113, 36);
            this.btJogar.TabIndex = 7;
            this.btJogar.Text = "&Jogar";
            this.btJogar.UseVisualStyleBackColor = false;
            this.btJogar.Click += new System.EventHandler(this.btJogar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.DimGray;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.White;
            this.btLimpar.Location = new System.Drawing.Point(292, 64);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(61, 27);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Red;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(292, 100);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(61, 27);
            this.btSair.TabIndex = 9;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btJogarAI
            // 
            this.btJogarAI.BackColor = System.Drawing.Color.DimGray;
            this.btJogarAI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btJogarAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJogarAI.ForeColor = System.Drawing.Color.White;
            this.btJogarAI.Location = new System.Drawing.Point(214, 133);
            this.btJogarAI.Name = "btJogarAI";
            this.btJogarAI.Size = new System.Drawing.Size(139, 36);
            this.btJogarAI.TabIndex = 10;
            this.btJogarAI.Text = "&Jogar contra a IA";
            this.btJogarAI.UseVisualStyleBackColor = false;
            this.btJogarAI.Click += new System.EventHandler(this.btJogarAI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(369, 181);
            this.Controls.Add(this.btJogarAI);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btJogar);
            this.Controls.Add(this.txtNomeO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtX);
            this.Controls.Add(this.txtNomeX);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeX;
        private System.Windows.Forms.RadioButton rbtX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtO;
        private System.Windows.Forms.TextBox txtNomeO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btJogar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btJogarAI;
    }
}

