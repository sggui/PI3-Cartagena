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
            this.btnMostrarMesa = new System.Windows.Forms.Button();
            this.txtbTabuleiro = new System.Windows.Forms.ListBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnPularVez = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSimbolo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosicao = new System.Windows.Forms.TextBox();
            this.btnJogarFrente = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.btnVerificarVez = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.txtbMao.Size = new System.Drawing.Size(134, 95);
            this.txtbMao.TabIndex = 2;
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
            this.txtbTabuleiro.Size = new System.Drawing.Size(123, 134);
            this.txtbTabuleiro.TabIndex = 8;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(405, 113);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(140, 37);
            this.btnJogar.TabIndex = 10;
            this.btnJogar.Text = "Jogar Tras";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogarTras_Click);
            // 
            // btnPularVez
            // 
            this.btnPularVez.Location = new System.Drawing.Point(404, 166);
            this.btnPularVez.Name = "btnPularVez";
            this.btnPularVez.Size = new System.Drawing.Size(141, 37);
            this.btnPularVez.TabIndex = 11;
            this.btnPularVez.Text = "Pular Vez";
            this.btnPularVez.UseVisualStyleBackColor = true;
            this.btnPularVez.Click += new System.EventHandler(this.btnPularVez_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Posicao";
            // 
            // cboSimbolo
            // 
            this.cboSimbolo.FormattingEnabled = true;
            this.cboSimbolo.Items.AddRange(new object[] {
            "Esqueleto",
            "Chave",
            "Garrafa",
            "Pistola",
            "Tricórnio",
            "Faca"});
            this.cboSimbolo.Location = new System.Drawing.Point(477, 26);
            this.cboSimbolo.Name = "cboSimbolo";
            this.cboSimbolo.Size = new System.Drawing.Size(121, 21);
            this.cboSimbolo.TabIndex = 14;
            this.cboSimbolo.SelectedIndexChanged += new System.EventHandler(this.cboSimbolo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Simbolo";
            // 
            // txtPosicao
            // 
            this.txtPosicao.Location = new System.Drawing.Point(353, 26);
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.Size = new System.Drawing.Size(100, 20);
            this.txtPosicao.TabIndex = 16;
            this.txtPosicao.TextChanged += new System.EventHandler(this.txtPosicao_TextChanged);
            // 
            // btnJogarFrente
            // 
            this.btnJogarFrente.Location = new System.Drawing.Point(405, 60);
            this.btnJogarFrente.Name = "btnJogarFrente";
            this.btnJogarFrente.Size = new System.Drawing.Size(140, 37);
            this.btnJogarFrente.TabIndex = 17;
            this.btnJogarFrente.Text = "Jogar Frente";
            this.btnJogarFrente.UseVisualStyleBackColor = true;
            this.btnJogarFrente.Click += new System.EventHandler(this.btnJogarFrente_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(676, 19);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(117, 23);
            this.btnHistorico.TabIndex = 18;
            this.btnHistorico.Text = "Exibir Historico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // txtHistorico
            // 
            this.txtHistorico.Location = new System.Drawing.Point(676, 57);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistorico.Size = new System.Drawing.Size(117, 195);
            this.txtHistorico.TabIndex = 19;
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.Location = new System.Drawing.Point(863, 19);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(117, 23);
            this.btnVerificarVez.TabIndex = 20;
            this.btnVerificarVez.Text = "Verificar Vez";
            this.btnVerificarVez.UseVisualStyleBackColor = true;
            this.btnVerificarVez.Click += new System.EventHandler(this.btnVerificarVez_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(853, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 192);
            this.textBox1.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 414);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnVerificarVez);
            this.Controls.Add(this.txtHistorico);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnJogarFrente);
            this.Controls.Add(this.txtPosicao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSimbolo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPularVez);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.txtbTabuleiro);
            this.Controls.Add(this.btnMostrarMesa);
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
        private System.Windows.Forms.Button btnMostrarMesa;
        private System.Windows.Forms.ListBox txtbTabuleiro;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnPularVez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSimbolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPosicao;
        private System.Windows.Forms.Button btnJogarFrente;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.Button btnVerificarVez;
        private System.Windows.Forms.TextBox textBox1;
    }
}