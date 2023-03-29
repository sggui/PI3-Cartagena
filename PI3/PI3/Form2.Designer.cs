namespace PI3
{
    partial class Form2
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
            this.txtbIdJogadorPartida = new System.Windows.Forms.ListBox();
            this.btnMostrarMao = new System.Windows.Forms.Button();
            this.txtbMao = new System.Windows.Forms.ListBox();
            this.idJogador = new System.Windows.Forms.TextBox();
            this.senhaJogador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrarMesa = new System.Windows.Forms.Button();
            this.txtbTabuleiro = new System.Windows.Forms.ListBox();
            this.txtbIdPartida = new System.Windows.Forms.ListBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbIdJogadorPartida
            // 
            this.txtbIdJogadorPartida.FormattingEnabled = true;
            this.txtbIdJogadorPartida.Location = new System.Drawing.Point(12, 12);
            this.txtbIdJogadorPartida.Name = "txtbIdJogadorPartida";
            this.txtbIdJogadorPartida.Size = new System.Drawing.Size(288, 30);
            this.txtbIdJogadorPartida.TabIndex = 0;
            // 
            // btnMostrarMao
            // 
            this.btnMostrarMao.Location = new System.Drawing.Point(12, 48);
            this.btnMostrarMao.Name = "btnMostrarMao";
            this.btnMostrarMao.Size = new System.Drawing.Size(134, 37);
            this.btnMostrarMao.TabIndex = 1;
            this.btnMostrarMao.Text = "Mostrar Mao";
            this.btnMostrarMao.UseVisualStyleBackColor = true;
            this.btnMostrarMao.Click += new System.EventHandler(this.btnMostrarMao_Click);
            // 
            // txtbMao
            // 
            this.txtbMao.FormattingEnabled = true;
            this.txtbMao.Location = new System.Drawing.Point(12, 91);
            this.txtbMao.Name = "txtbMao";
            this.txtbMao.Size = new System.Drawing.Size(328, 95);
            this.txtbMao.TabIndex = 2;
            // 
            // idJogador
            // 
            this.idJogador.Location = new System.Drawing.Point(359, 91);
            this.idJogador.Name = "idJogador";
            this.idJogador.Size = new System.Drawing.Size(100, 20);
            this.idJogador.TabIndex = 3;
            // 
            // senhaJogador
            // 
            this.senhaJogador.Location = new System.Drawing.Point(359, 144);
            this.senhaJogador.Name = "senhaJogador";
            this.senhaJogador.Size = new System.Drawing.Size(100, 20);
            this.senhaJogador.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha Jogador";
            // 
            // btnMostrarMesa
            // 
            this.btnMostrarMesa.Location = new System.Drawing.Point(12, 192);
            this.btnMostrarMesa.Name = "btnMostrarMesa";
            this.btnMostrarMesa.Size = new System.Drawing.Size(123, 32);
            this.btnMostrarMesa.TabIndex = 7;
            this.btnMostrarMesa.Text = "Mostrar Mesa";
            this.btnMostrarMesa.UseVisualStyleBackColor = true;
            this.btnMostrarMesa.Click += new System.EventHandler(this.btnMostrarMesa_Click);
            // 
            // txtbTabuleiro
            // 
            this.txtbTabuleiro.FormattingEnabled = true;
            this.txtbTabuleiro.Location = new System.Drawing.Point(12, 230);
            this.txtbTabuleiro.Name = "txtbTabuleiro";
            this.txtbTabuleiro.Size = new System.Drawing.Size(759, 134);
            this.txtbTabuleiro.TabIndex = 8;
            // 
            // txtbIdPartida
            // 
            this.txtbIdPartida.FormattingEnabled = true;
            this.txtbIdPartida.Location = new System.Drawing.Point(318, 12);
            this.txtbIdPartida.Name = "txtbIdPartida";
            this.txtbIdPartida.Size = new System.Drawing.Size(66, 30);
            this.txtbIdPartida.TabIndex = 9;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(505, 91);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(140, 37);
            this.btnJogar.TabIndex = 10;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.txtbIdPartida);
            this.Controls.Add(this.txtbTabuleiro);
            this.Controls.Add(this.btnMostrarMesa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senhaJogador);
            this.Controls.Add(this.idJogador);
            this.Controls.Add(this.txtbMao);
            this.Controls.Add(this.btnMostrarMao);
            this.Controls.Add(this.txtbIdJogadorPartida);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox txtbIdJogadorPartida;
        private System.Windows.Forms.Button btnMostrarMao;
        private System.Windows.Forms.ListBox txtbMao;
        private System.Windows.Forms.TextBox idJogador;
        private System.Windows.Forms.TextBox senhaJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMostrarMesa;
        private System.Windows.Forms.ListBox txtbTabuleiro;
        private System.Windows.Forms.ListBox txtbIdPartida;
        private System.Windows.Forms.Button btnJogar;
    }
}