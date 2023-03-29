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
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int parametro) : this()
        {
            txtbIdPartida.Items.Add(parametro);
        }

        private void btnMostrarMao_Click(object sender, EventArgs e)
        {

            string idJogador1 = idJogador.Text;
            string senhaJogador1 = senhaJogador.Text;
           int idJogador2 = Convert.ToInt32(idJogador1);

          txtbMao.Items.Add(Jogo.ConsultarMao(idJogador2, senhaJogador1));
            

        }




        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarMesa_Click(object sender, EventArgs e)
        {

            string idPartida1 = txtbIdPartida.SelectedItem.ToString();
            int idPartida = Convert.ToInt32(idPartida1);
            txtbTabuleiro.Items.Add(Jogo.ExibirTabuleiro(idPartida));

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string idJogadorForm1 = idJogador.Text;
            string senhaJogador1 = senhaJogador.Text;
            int idJogador1 = Convert.ToInt32(idJogadorForm1);

            txtbTabuleiro.Items.Add(Jogo.Jogar(idJogador1, senhaJogador1));
          
        }
    }
}
