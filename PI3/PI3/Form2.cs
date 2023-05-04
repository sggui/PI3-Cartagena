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
            int rowCount = 6; // definir o número de linhas do tabuleiro
            int columnCount = 6; // definir o número de colunas do tabuleiro

            // ajustar o tamanho do TableLayoutPanel para caber os botões
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowCount = rowCount;
            tableLayoutPanel1.ColumnCount = columnCount;
            for (int i = 0; i < rowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rowCount));
            }
            for (int j = 0; j < columnCount; j++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnCount));
            }

            // criar um botão para cada célula do tabuleiro
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    var pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile("C:/Users/muril/source/repos/PI3-Cartagena1/PI3/src/images/caveiraa.png"); // defina a imagem que deseja exibir
                    pictureBox.Dock = DockStyle.Fill;
                    tableLayoutPanel1.Controls.Add(pictureBox, j, i);
                }
            }
        }

        private void btnMostrarMesa_Click(object sender, EventArgs e)
        {
            string tabuleiro = Jogo.ExibirTabuleiro(idPartida);
            string[] linhasTabuleiro = tabuleiro.Split('\n');

            // Limpa o layout panel antes de adicionarmos as novas células
            tableLayoutPanel1.Controls.Clear();

            // Define o número de linhas e colunas no layout panel
            tableLayoutPanel1.RowCount = linhasTabuleiro.Length;
            tableLayoutPanel1.ColumnCount = linhasTabuleiro[0].Split(' ').Length;

            // Adiciona as células ao layout panel
            for (int i = 0; i < linhasTabuleiro.Length; i++)
            {
                string[] simbolosLinha = linhasTabuleiro[i].Split(' ');

                for (int j = 0; j < simbolosLinha.Length; j++)
                {
                    // Cria uma nova label para a célula
                    Label label = new Label();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Font = new Font("Arial", 14, FontStyle.Bold);
                    label.Margin = new Padding(0);

                    // Define o fundo da célula de acordo com a cor do símbolo
                    if (simbolosLinha[j] == "O")
                    {
                        label.BackColor = Color.Red;
                        label.ForeColor = Color.White;
                    }
                    else if (simbolosLinha[j] == "X")
                    {
                        label.BackColor = Color.Blue;
                        label.ForeColor = Color.White;
                    }

                    // Define o texto da célula
                    label.Text = simbolosLinha[j];

                    // Adiciona a label ao layout panel
                    tableLayoutPanel1.Controls.Add(label, j, i);
                }
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
