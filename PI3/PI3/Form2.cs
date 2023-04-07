using CartagenaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI3
{
    public partial class Form2 : Form
    {
        public int idPartida;
        public int idJogador;
        public string senhaJogador;
  

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int idPartida, int idJogador, string senhaJogador) : this()
        {
            this.idPartida = idPartida;
            this.idJogador = idJogador;
            this.senhaJogador = senhaJogador;
        }

        private void btnMostrarMao_Click(object sender, EventArgs e)
        {
            txtbMao.Items.Clear();
            string retornoMao = Jogo.ConsultarMao(idJogador, senhaJogador);
            string[] itens = retornoMao.Split('\n');


            for (int i = 0; i < itens.Length; i++)
            {
                txtbMao.Items.Add(itens[i]);
            }


        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarMesa_Click(object sender, EventArgs e)
        {
            txtbTabuleiro.Items.Clear();
            string tabuleiro = Jogo.ExibirTabuleiro(idPartida);
            string[] itens = tabuleiro.Split('\n');

            for (int i = 0; i < itens.Length; i++)
            {
                txtbTabuleiro.Items.Add(itens[i]);
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string simbolo = txtbMao.SelectedItem.ToString();
            string[] simbolos = simbolo.Split(',');
            int posicao = 0;
       
            txtbTabuleiro.Items.Add(Jogo.Jogar(idJogador, senhaJogador, posicao, simbolos[0]));
        }

        private void btnPularVez_Click(object sender, EventArgs e)
        {
            txtbTabuleiro.Items.Add(Jogo.Jogar(idJogador, senhaJogador));
        }

        private void cboSimbolo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPosicao_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnJogarFrente_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.txtbIdJogadorPartida.Text = Jogo.Jogar(Convert.ToInt32(this.idJogador), this.senhaJogador, Convert.ToInt32(this.txtPosicao.Text), this.cboSimbolo.Text.Substring(0, 1));
            Cursor.Current = Cursors.Default;
        }

        private void btnJogarTras_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.txtbIdJogadorPartida.Text = Jogo.Jogar(Convert.ToInt32(this.idJogador), this.senhaJogador, Convert.ToInt32(this.txtPosicao.Text));
            Cursor.Current = Cursors.Default;
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.txtHistorico.Text = Jogo.ExibirHistorico(Convert.ToInt32(this.idPartida));
            Cursor.Current = Cursors.Default;
        }

     

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.txtbIdJogadorPartida.Text = Jogo.VerificarVez(Convert.ToInt32(this.idPartida));
            Cursor.Current = Cursors.Default;
        }
    }
}
