using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP.Aula03.Exercicio
{
    public partial class Exercicio4 : Form
    {
        private string[,] board;
        string jogadorDaVez;
        public Exercicio4()
        {
            InitializeComponent();
            board = new string[3, 3];
            jogadorDaVez = "X";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecomecar_Click(object sender, EventArgs e)
        {
            board = new string[3, 3];
            mtbLinha.Clear();
            mtbColuna.Clear();
            lbl00.Text = String.Empty;
            lbl01.Text = String.Empty;
            lbl02.Text = String.Empty;
            lbl10.Text = String.Empty;
            lbl11.Text = String.Empty;
            lbl12.Text = String.Empty;
            lbl20.Text = String.Empty;
            lbl21.Text = String.Empty;
            lbl22.Text = String.Empty;
            lblError.Text = String.Empty;
            jogadorDaVez = "X";
            lblJogador.Text = "É a vez do Jogador 1 (X)";
            mtbLinha.Visible = true;
            mtbColuna.Visible = true;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lblError.Text = String.Empty;
            int linha = Convert.ToInt32(mtbLinha.Text) - 1;
            int coluna = Convert.ToInt32(mtbColuna.Text) - 1;
            if (ValidateInput(linha, coluna) && ValidatePosition(linha, coluna))
            {
                AlterBoard(linha, coluna, jogadorDaVez);
                FindWinner();
                jogadorDaVez = AlterPlayer(jogadorDaVez);
                mtbLinha.Clear();
                mtbColuna.Clear();
                mtbLinha.Focus();
            }
        }
        private bool ValidateInput(int linha, int coluna)
        {
                if (linha > 2 || linha < 0 || coluna > 2 || coluna < 0)
                {
                    lblError.Text = "Insert Inválido\n" +
                        "Insira um número entre 1 e 3";
                    return false;
                }
            return true;
        }
        private bool ValidatePosition(int linha, int coluna)
        {
            if (board[linha, coluna] == "X" || board[linha, coluna] == "O")
            {
                lblError.Text = "Insert Inválido\n" +
                       "Esta posição já está ocupada";
                return false;
            }
            return true;
        }
        private void AlterBoard(int linha, int coluna, string jogador)
        {
            board[linha, coluna] = jogador;
            if (linha == 0 && coluna == 0)
                lbl00.Text = jogador;
            else if (linha == 0 && coluna == 1)
                lbl01.Text = jogador;
            else if (linha == 0 && coluna == 2)
                lbl02.Text = jogador;
            else if (linha == 1 && coluna == 0)
                lbl10.Text = jogador;
            else if (linha == 1 && coluna == 1)
                lbl11.Text = jogador;
            else if (linha == 1 && coluna == 2)
                lbl12.Text = jogador;
            else if (linha == 2 && coluna == 0)
                lbl20.Text = jogador;
            else if (linha == 2 && coluna == 1)
                lbl21.Text = jogador;
            else if (linha == 2 && coluna == 2)
                lbl22.Text = jogador;
        }

        private string AlterPlayer(string player)
        {
            if (player == "X")
            {
                player = "O";
                lblJogador.Text = "É a vez do Jogador 2 (O)";
            }
            else if (player == "O")
            {
                player = "X";
                lblJogador.Text = "É a vez do Jogador 1 (X)";
            }
            return player;
        }

        private void FindWinner()
        {
            int i = 0;
            for (int j = 0; j < board.GetLength(0); j++)
            {
                if (board[j, i] == board[j, i + 1] 
                    && board[j, i] == board[j, i + 2]
                        && (board[j, i] == "X" || board[j, i] == "O"))
                {
                    MessageBox.Show($"O vencedor é o {board[j, i]}", "O Jogo acabou", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mtbLinha.Visible = false;
                    mtbColuna.Visible = false;
                }
            }
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] == board[i + 1, j]
                        && board[i, j] == board[i + 2, j]
                            && (board[i, j] == "X" || board[i, j] == "O"))
                {
                    MessageBox.Show($"O vencedor é o {board[i, j]}", "O Jogo acabou", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mtbLinha.Visible = false;
                    mtbColuna.Visible = false;
                }
            }
            if (board[i, i] == board[i + 1, i + 1]
                && board[i, i] == board[i + 2, i + 2]
                    && (board[i, i] == "X" || board[i, i] == "O"))
            {
                MessageBox.Show($"O vencedor é o {board[i, i]}", "O Jogo acabou", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbLinha.Visible = false;
                mtbColuna.Visible = false;
            }
            else if (board[i, i + 2] == board[i + 1, i + 1]
                && board[i + 1, i + 1] == board[i + 2, i]
                    && (board[i + 1, i + 1] == "X" || board[i + 1, i + 1] == "O"))
            {
                MessageBox.Show($"O vencedor é o {board[i + 1, i + 1]}", "O Jogo acabou", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbLinha.Visible = false;
                mtbColuna.Visible = false;
            }
        }

    }
}
