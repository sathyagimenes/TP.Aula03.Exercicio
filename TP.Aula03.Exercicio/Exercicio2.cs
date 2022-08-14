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
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNumerosInsert.Clear();
            lblPontuacoesResult.Text = String.Empty;
            lblRankingResult.Text = String.Empty;
            lblError.Text = String.Empty;
        }
        private bool ValidateInput(string[] ArrayInserted)
        {
            int n = 0;
            foreach (string num in ArrayInserted)
            {
                if (!Int32.TryParse(num, out n))
                {
                    lblError.Text = "Insert Inválido\n" +
                        "Exemplo de insert válido: 10, 2, 4";
                    ArrayInserted.DefaultIfEmpty();
                    return false;
                }
            }
            return true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            lblError.Text = String.Empty;
            lblPontuacoesResult.Text = String.Empty;
            lblRankingResult.Text = String.Empty;
            txbNumerosInsert.Text = txbNumerosInsert.Text.Trim(',');
            int sizeOfArray = txbNumerosInsert.Text.Split(',').Length;
            string[] ArrayInserted = new string[sizeOfArray];
            int[] ArrayInsertedInt = new int[sizeOfArray];
            int[] SortedArray = new int[sizeOfArray];
            int[] RankedArray = new int[sizeOfArray];
            ArrayInserted = txbNumerosInsert.Text.Split(',');
            if (ValidateInput(ArrayInserted))
            {
                for (int i = 0; i < ArrayInserted.Length; i++)
                {
                    ArrayInsertedInt[i] = Convert.ToInt32(ArrayInserted[i]);
                }
                for (int n = 0; n < ArrayInsertedInt.Length; n++)
                {
                    SortedArray[n] = ArrayInsertedInt[n];
                    lblPontuacoesResult.Text += (" " + ArrayInsertedInt[n] + ",");
                }
                lblPontuacoesResult.Text = lblPontuacoesResult.Text.Trim(',');
                BubbleSort(SortedArray);
                int j = 0;
                foreach (int n in ArrayInsertedInt)
                {
                    for (int i = 0; i < SortedArray.Length; i++)
                    {
                        if (n == SortedArray[i])
                        {
                            RankedArray[j] = (i + 1);
                            j++;
                            break;
                        }
                    }
                }
                foreach (int n in RankedArray)
                {
                    lblRankingResult.Text += (" " + n + ",");
                }
                lblRankingResult.Text = lblRankingResult.Text.Trim(',');
            }
            ArrayInsertedInt.DefaultIfEmpty();
            ArrayInserted.DefaultIfEmpty();
        }

        static void BubbleSort(int[] arr)
        {
            int tmp = 0;
            int num = arr.Length;
            for (int i = 0; i < num - 1; i++)
            { 
                for (int j = 0; j < num - i - 1; j++) 
                { 
                    if (arr[j] < arr[j + 1])
                    {
                        tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
        }

        private void txbNumerosInsert_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
