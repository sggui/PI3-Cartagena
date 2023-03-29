namespace PI3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListaPartidasAbertas = new System.Windows.Forms.Button();
            this.txtbExibePartidasAbertas = new System.Windows.Forms.ListBox();
            this.btnSelecionaPartida = new System.Windows.Forms.Button();
            this.lblOrganizaPartida = new System.Windows.Forms.Label();
            this.btnCriaPartida = new System.Windows.Forms.Button();
            this.lblExibeIdPartidaCriada = new System.Windows.Forms.Label();
            this.nomeJogador = new System.Windows.Forms.TextBox();
            this.senhaPartida = new System.Windows.Forms.TextBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.lblDadosJogadorPartida = new System.Windows.Forms.Label();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.nomeCriacaoPartida = new System.Windows.Forms.TextBox();
            this.senhaCriacaoPartida = new System.Windows.Forms.TextBox();
            this.lblCriacaoPartidaNome = new System.Windows.Forms.Label();
            this.lblCriacaoPartidaSenha = new System.Windows.Forms.Label();
            this.lblCriarPartidaTitulo = new System.Windows.Forms.Label();
            this.btnListaPartidaJogando = new System.Windows.Forms.Button();
            this.txtbExibePartidasJogando = new System.Windows.Forms.ListBox();
            this.btnListaPartidasEncerradas = new System.Windows.Forms.Button();
            this.txtbExibePartidasEncerradas = new System.Windows.Forms.ListBox();
            this.btnExibeJogadores = new System.Windows.Forms.Button();
            this.txtbListaJogadores = new System.Windows.Forms.ListBox();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.txtbInicio = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListaPartidasAbertas
            // 
            this.btnListaPartidasAbertas.Location = new System.Drawing.Point(12, 75);
            this.btnListaPartidasAbertas.Name = "btnListaPartidasAbertas";
            this.btnListaPartidasAbertas.Size = new System.Drawing.Size(129, 23);
            this.btnListaPartidasAbertas.TabIndex = 2;
            this.btnListaPartidasAbertas.Text = "Listar Partidas Abertas";
            this.btnListaPartidasAbertas.Click += new System.EventHandler(this.btnlistarPartidas_Click);
            // 
            // txtbExibePartidasAbertas
            // 
            this.txtbExibePartidasAbertas.Location = new System.Drawing.Point(12, 120);
            this.txtbExibePartidasAbertas.Name = "txtbExibePartidasAbertas";
            this.txtbExibePartidasAbertas.Size = new System.Drawing.Size(229, 199);
            this.txtbExibePartidasAbertas.TabIndex = 0;
            // 
            // btnSelecionaPartida
            // 
            this.btnSelecionaPartida.Location = new System.Drawing.Point(12, 335);
            this.btnSelecionaPartida.Name = "btnSelecionaPartida";
            this.btnSelecionaPartida.Size = new System.Drawing.Size(108, 23);
            this.btnSelecionaPartida.TabIndex = 3;
            this.btnSelecionaPartida.Text = "Selecionar partida";
            this.btnSelecionaPartida.Click += new System.EventHandler(this.selecionaPartida_Click);
            // 
            // lblOrganizaPartida
            // 
            this.lblOrganizaPartida.AutoSize = true;
            this.lblOrganizaPartida.Location = new System.Drawing.Point(12, 372);
            this.lblOrganizaPartida.Name = "lblOrganizaPartida";
            this.lblOrganizaPartida.Size = new System.Drawing.Size(80, 13);
            this.lblOrganizaPartida.TabIndex = 4;
            this.lblOrganizaPartida.Text = "organizaPartida";
            // 
            // btnCriaPartida
            // 
            this.btnCriaPartida.Location = new System.Drawing.Point(629, 241);
            this.btnCriaPartida.Name = "btnCriaPartida";
            this.btnCriaPartida.Size = new System.Drawing.Size(108, 23);
            this.btnCriaPartida.TabIndex = 5;
            this.btnCriaPartida.Text = "Criar Partida";
            this.btnCriaPartida.Click += new System.EventHandler(this.btnCriaPartida_Click);
            // 
            // lblExibeIdPartidaCriada
            // 
            this.lblExibeIdPartidaCriada.AutoSize = true;
            this.lblExibeIdPartidaCriada.Location = new System.Drawing.Point(626, 279);
            this.lblExibeIdPartidaCriada.Name = "lblExibeIdPartidaCriada";
            this.lblExibeIdPartidaCriada.Size = new System.Drawing.Size(104, 13);
            this.lblExibeIdPartidaCriada.TabIndex = 6;
            this.lblExibeIdPartidaCriada.Text = "exibeIdPartidaCriada";
            // 
            // nomeJogador
            // 
            this.nomeJogador.Location = new System.Drawing.Point(288, 146);
            this.nomeJogador.Name = "nomeJogador";
            this.nomeJogador.Size = new System.Drawing.Size(109, 20);
            this.nomeJogador.TabIndex = 7;
            // 
            // senhaPartida
            // 
            this.senhaPartida.Location = new System.Drawing.Point(288, 205);
            this.senhaPartida.Name = "senhaPartida";
            this.senhaPartida.Size = new System.Drawing.Size(109, 20);
            this.senhaPartida.TabIndex = 8;
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(288, 241);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(108, 23);
            this.btnEntrarPartida.TabIndex = 9;
            this.btnEntrarPartida.Text = "Entrar na partida";
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // lblDadosJogadorPartida
            // 
            this.lblDadosJogadorPartida.Location = new System.Drawing.Point(285, 279);
            this.lblDadosJogadorPartida.Name = "lblDadosJogadorPartida";
            this.lblDadosJogadorPartida.Size = new System.Drawing.Size(112, 23);
            this.lblDadosJogadorPartida.TabIndex = 0;
            this.lblDadosJogadorPartida.Text = "dadosJogadorPartida";
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.Location = new System.Drawing.Point(296, 120);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(112, 23);
            this.lblNomeJogador.TabIndex = 10;
            this.lblNomeJogador.Text = "Digite seu nome";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.Location = new System.Drawing.Point(247, 178);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(198, 23);
            this.lblSenhaPartida.TabIndex = 11;
            this.lblSenhaPartida.Text = "Digite a senha da partida selecionada";
            // 
            // nomeCriacaoPartida
            // 
            this.nomeCriacaoPartida.Location = new System.Drawing.Point(629, 146);
            this.nomeCriacaoPartida.Name = "nomeCriacaoPartida";
            this.nomeCriacaoPartida.Size = new System.Drawing.Size(109, 20);
            this.nomeCriacaoPartida.TabIndex = 12;
            // 
            // senhaCriacaoPartida
            // 
            this.senhaCriacaoPartida.Location = new System.Drawing.Point(629, 205);
            this.senhaCriacaoPartida.Name = "senhaCriacaoPartida";
            this.senhaCriacaoPartida.Size = new System.Drawing.Size(109, 20);
            this.senhaCriacaoPartida.TabIndex = 13;
            // 
            // lblCriacaoPartidaNome
            // 
            this.lblCriacaoPartidaNome.Location = new System.Drawing.Point(626, 114);
            this.lblCriacaoPartidaNome.Name = "lblCriacaoPartidaNome";
            this.lblCriacaoPartidaNome.Size = new System.Drawing.Size(137, 23);
            this.lblCriacaoPartidaNome.TabIndex = 14;
            this.lblCriacaoPartidaNome.Text = "Digite o nome da partida";
            // 
            // lblCriacaoPartidaSenha
            // 
            this.lblCriacaoPartidaSenha.Location = new System.Drawing.Point(626, 178);
            this.lblCriacaoPartidaSenha.Name = "lblCriacaoPartidaSenha";
            this.lblCriacaoPartidaSenha.Size = new System.Drawing.Size(125, 17);
            this.lblCriacaoPartidaSenha.TabIndex = 15;
            this.lblCriacaoPartidaSenha.Text = "Digite a senha da partida";
            // 
            // lblCriarPartidaTitulo
            // 
            this.lblCriarPartidaTitulo.AutoSize = true;
            this.lblCriarPartidaTitulo.Font = new System.Drawing.Font("Arial", 15.25F);
            this.lblCriarPartidaTitulo.Location = new System.Drawing.Point(597, 72);
            this.lblCriarPartidaTitulo.Name = "lblCriarPartidaTitulo";
            this.lblCriarPartidaTitulo.Size = new System.Drawing.Size(166, 24);
            this.lblCriarPartidaTitulo.TabIndex = 16;
            this.lblCriarPartidaTitulo.Text = "CRIAR PARTIDA";
            // 
            // btnListaPartidaJogando
            // 
            this.btnListaPartidaJogando.Location = new System.Drawing.Point(236, 335);
            this.btnListaPartidaJogando.Name = "btnListaPartidaJogando";
            this.btnListaPartidaJogando.Size = new System.Drawing.Size(129, 23);
            this.btnListaPartidaJogando.TabIndex = 17;
            this.btnListaPartidaJogando.Text = "Listar Partidas Jogando";
            this.btnListaPartidaJogando.Click += new System.EventHandler(this.btnlistaPartidaJogando_Click);
            // 
            // txtbExibePartidasJogando
            // 
            this.txtbExibePartidasJogando.Location = new System.Drawing.Point(236, 364);
            this.txtbExibePartidasJogando.Name = "txtbExibePartidasJogando";
            this.txtbExibePartidasJogando.Size = new System.Drawing.Size(209, 82);
            this.txtbExibePartidasJogando.TabIndex = 18;
            // 
            // btnListaPartidasEncerradas
            // 
            this.btnListaPartidasEncerradas.Location = new System.Drawing.Point(473, 335);
            this.btnListaPartidasEncerradas.Name = "btnListaPartidasEncerradas";
            this.btnListaPartidasEncerradas.Size = new System.Drawing.Size(161, 23);
            this.btnListaPartidasEncerradas.TabIndex = 21;
            this.btnListaPartidasEncerradas.Text = "Listar Partidas Encerradas";
            this.btnListaPartidasEncerradas.Click += new System.EventHandler(this.btnPartidasEncerradas_Click);
            // 
            // txtbExibePartidasEncerradas
            // 
            this.txtbExibePartidasEncerradas.Location = new System.Drawing.Point(473, 364);
            this.txtbExibePartidasEncerradas.Name = "txtbExibePartidasEncerradas";
            this.txtbExibePartidasEncerradas.Size = new System.Drawing.Size(229, 82);
            this.txtbExibePartidasEncerradas.TabIndex = 20;
            // 
            // btnExibeJogadores
            // 
            this.btnExibeJogadores.Location = new System.Drawing.Point(472, 3);
            this.btnExibeJogadores.Name = "btnExibeJogadores";
            this.btnExibeJogadores.Size = new System.Drawing.Size(144, 23);
            this.btnExibeJogadores.TabIndex = 22;
            this.btnExibeJogadores.Text = "Listar Jogadores";
            this.btnExibeJogadores.UseVisualStyleBackColor = true;
            this.btnExibeJogadores.Click += new System.EventHandler(this.btnExibeJogadores_Click);
            // 
            // txtbListaJogadores
            // 
            this.txtbListaJogadores.FormattingEnabled = true;
            this.txtbListaJogadores.Location = new System.Drawing.Point(147, 3);
            this.txtbListaJogadores.Name = "txtbListaJogadores";
            this.txtbListaJogadores.Size = new System.Drawing.Size(319, 95);
            this.txtbListaJogadores.TabIndex = 23;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(459, 146);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(113, 49);
            this.btnIniciarPartida.TabIndex = 24;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // txtbInicio
            // 
            this.txtbInicio.FormattingEnabled = true;
            this.txtbInicio.Location = new System.Drawing.Point(427, 205);
            this.txtbInicio.Name = "txtbInicio";
            this.txtbInicio.Size = new System.Drawing.Size(189, 43);
            this.txtbInicio.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 476);
            this.Controls.Add(this.txtbInicio);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.txtbListaJogadores);
            this.Controls.Add(this.btnExibeJogadores);
            this.Controls.Add(this.txtbExibePartidasEncerradas);
            this.Controls.Add(this.btnListaPartidasEncerradas);
            this.Controls.Add(this.txtbExibePartidasJogando);
            this.Controls.Add(this.btnListaPartidaJogando);
            this.Controls.Add(this.lblCriarPartidaTitulo);
            this.Controls.Add(this.lblCriacaoPartidaSenha);
            this.Controls.Add(this.lblCriacaoPartidaNome);
            this.Controls.Add(this.senhaCriacaoPartida);
            this.Controls.Add(this.nomeCriacaoPartida);
            this.Controls.Add(this.lblSenhaPartida);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.lblDadosJogadorPartida);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.senhaPartida);
            this.Controls.Add(this.nomeJogador);
            this.Controls.Add(this.lblExibeIdPartidaCriada);
            this.Controls.Add(this.btnCriaPartida);
            this.Controls.Add(this.lblOrganizaPartida);
            this.Controls.Add(this.btnSelecionaPartida);
            this.Controls.Add(this.txtbExibePartidasAbertas);
            this.Controls.Add(this.btnListaPartidasAbertas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListaPartidasAbertas;
        private System.Windows.Forms.ListBox txtbExibePartidasAbertas;
        private System.Windows.Forms.Button btnSelecionaPartida;
        private System.Windows.Forms.Label lblOrganizaPartida;
        private System.Windows.Forms.Button btnCriaPartida;
        private System.Windows.Forms.Label lblExibeIdPartidaCriada;
        private System.Windows.Forms.TextBox nomeJogador;
        private System.Windows.Forms.TextBox senhaPartida;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Label lblDadosJogadorPartida;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.TextBox nomeCriacaoPartida;
        private System.Windows.Forms.TextBox senhaCriacaoPartida;
        private System.Windows.Forms.Label lblCriacaoPartidaNome;
        private System.Windows.Forms.Label lblCriacaoPartidaSenha;
        private System.Windows.Forms.Label lblCriarPartidaTitulo;
        private System.Windows.Forms.Button btnListaPartidaJogando;
        private System.Windows.Forms.ListBox txtbExibePartidasJogando;
        private System.Windows.Forms.Button btnListaPartidasEncerradas;
        private System.Windows.Forms.ListBox txtbExibePartidasEncerradas;
        private System.Windows.Forms.Button btnExibeJogadores;
        private System.Windows.Forms.ListBox txtbListaJogadores;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.ListBox txtbInicio;
    }
}

