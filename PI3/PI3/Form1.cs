﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace PI3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private Form2 form2Instance = null;
        public int idPartida;
        private void btnlistarPartidas_Click(object sender, EventArgs e)
        {
            txtbExibePartidasAbertas.Items.Clear();
            string retorno = Jogo.ListarPartidas("A");
            retorno = retorno.Replace("\r", "");

            string[] partidas = retorno.Split('\n');

            for (int i = 0; i < partidas.Length; i++)
            {
                txtbExibePartidasAbertas.Items.Add(partidas[i]);
            }

        }

        private void selecionaPartida_Click(object sender, EventArgs e)
        {
            if (txtbExibePartidasAbertas.SelectedItem == null)
            {
                lblOrganizaPartida.Text = "Selecione uma partida";
            }
            else
            {
                string partida = txtbExibePartidasAbertas.SelectedItem.ToString();
                string[] itens = partida.Split(',');

                idPartida = Convert.ToInt32(itens[0]);
                string nomePartida = (itens[1]);
                string dataPartida = (itens[2]);
                string statusPartida = (itens[3]);

                if (statusPartida == "A")
                {
                    statusPartida = statusPartida.Replace("A", "Aberta");
                }
                lblOrganizaPartida.Text = "Id: " + idPartida.ToString() + "\nNome: " + nomePartida + "\nData da partida: " + dataPartida + "\nStatus da partida: " + statusPartida;
            }

        }

        private void btnCriaPartida_Click(object sender, EventArgs e)
        {
            string nomePartidaCriacao = nomeCriacaoPartida.Text;
            string senhaPartidaCriacao = senhaCriacaoPartida.Text;
            string retorno = Jogo.CriarPartida(nomePartidaCriacao, senhaPartidaCriacao);

            lblExibeIdPartidaCriada.Text = "O ID da sua partida é: " + retorno;
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            string nome = nomeJogador.Text;
            string senha = senhaPartida.Text;
            string retorno = Jogo.EntrarPartida(idPartida, nome, senha);

            lblDadosJogadorPartida.Text = retorno;

        }

        private void btnlistaPartidaJogando_Click(object sender, EventArgs e)
        {
            txtbExibePartidasJogando.Items.Clear();
            string retorno = Jogo.ListarPartidas("J");
            retorno = retorno.Replace("\r", "");

            string[] partidas = retorno.Split('\n');

            for (int i = 0; i < partidas.Length; i++)
            {
                txtbExibePartidasJogando.Items.Add(partidas[i]);
            }
        }

        private void btnPartidasEncerradas_Click(object sender, EventArgs e)
        {

            string retorno = Jogo.ListarPartidas("E");
            retorno = retorno.Replace("\r", "");

            string[] partidas = retorno.Split('\n');

            if (txtbExibePartidasEncerradas == null)
            {
                txtbExibePartidasEncerradas.Items.Add("Não existem partidas encerradas!");
            }

            for (int i = 0; i < partidas.Length; i++)
            {
                txtbExibePartidasEncerradas.Items.Add(partidas[i]);
            }
        }

        private void btnExibeJogadores_Click(object sender, EventArgs e)
        {
            if (txtbExibePartidasAbertas.SelectedItem == null)
            {
                lblOrganizaPartida.Text = "Selecione uma partida";
            }
            else
            {
                txtbListaJogadores.Items.Clear();
                string partida = txtbExibePartidasAbertas.SelectedItem.ToString();
                string[] itens = partida.Split(',');

                idPartida = Convert.ToInt32(itens[0]);
                string nomePartida = (itens[1]);
                string dataPartida = (itens[2]);
                string statusPartida = (itens[3]);

                string listJogadores = Jogo.ListarJogadores(idPartida);
                string[] jogadores = listJogadores.Split(',');


                if (statusPartida == "A")
                {
                    txtbListaJogadores.Items.Add($@"{nomePartida} Jogadores: {Jogo.ListarJogadores(idPartida)}");
                }
            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            string partida = txtbExibePartidasAbertas.SelectedItem.ToString();
            string[] itens = partida.Split(',');

            idPartida = Convert.ToInt32(itens[0]);

            string retorno = lblDadosJogadorPartida.Text;

            string[] retorno2 = retorno.Split(',');

            int idJogador = Convert.ToInt32(retorno2[0]);
            string senhaJogador = (retorno2[1]);

            // verifica se já existe uma instância de Form2 aberta
            if (form2Instance == null || form2Instance.IsDisposed)
            {
                form2Instance = new Form2(idPartida, idJogador, senhaJogador);
                form2Instance.Show();
                form2Instance.txtbIdJogadorPartida.Items.Add($@"Id do Jogador: {(Jogo.IniciarPartida(idJogador, senhaJogador))}, Senha do Jogador: {senhaJogador}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

