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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mtbLinhas.Clear();
            mtbColunas.Clear();
            lblMatriz.Text = String.Empty;
        }

        private void gpxMatriz_Enter(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            lblMatriz.Text = String.Empty;
            int linhas = Convert.ToInt32(mtbLinhas.Text);
            int colunas = Convert.ToInt32(mtbColunas.Text);
            int[,] myMatrix = new int[linhas, colunas];
            int populateMatrix = 1;
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int n = 0; n < myMatrix.GetLength(1); n++)
                {
                    myMatrix[i, n] = populateMatrix++;
                }
            }
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int n = 0; n < myMatrix.GetLength(1); n++)
                {
                    lblMatriz.Text += (myMatrix[i,n] + " ");
                }
                lblMatriz.Text += "\n";
            }
        }
    }
}
