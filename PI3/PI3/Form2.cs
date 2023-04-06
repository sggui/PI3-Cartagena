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
          txtbMao.Items.Add(Jogo.ConsultarMao(idJogador, senhaJogador));
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarMesa_Click(object sender, EventArgs e)
        {
            txtbTabuleiro.Items.Add(Jogo.ExibirTabuleiro(idPartida));
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            txtbTabuleiro.Items.Add(Jogo.Jogar(idJogador, senhaJogador));
        }
    }
}
