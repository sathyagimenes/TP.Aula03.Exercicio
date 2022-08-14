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
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            lblError.Text = String.Empty;
            lblArrayOrdenada.Text = String.Empty;
            lblArrayPares.Text = String.Empty;
            lblArrayImpares.Text = String.Empty;
            string[] ArrayInserted = new string[10];
            int[] ArrayInsertedInt = new int[10];
            txbNumerosInsert.Text = txbNumerosInsert.Text.Trim(',');
            ArrayInserted = txbNumerosInsert.Text.Split(',');
            if (ValidateInput(ArrayInserted))
            {
                for (int i = 0; i < ArrayInserted.Length; i++)
                {
                    ArrayInsertedInt[i] = Convert.ToInt32(ArrayInserted[i]);
                }
                SortArray(ArrayInsertedInt);
                SortEvenOdds(ArrayInsertedInt);
            }
            ArrayInsertedInt.DefaultIfEmpty();
            ArrayInserted.DefaultIfEmpty();
        }

        private void SortArray(int[] array)
        {
            BubbleSort(array);
            foreach (int n in array)
            {
                lblArrayOrdenada.Text += (" " + n + ",");
            }
            lblArrayOrdenada.Text = lblArrayOrdenada.Text.Trim(',');
        }
        static void BubbleSort(int[] arr)
        {
            int tmp = 0;
            int num = arr.Length;
            for (int i = 0; i < num - 1; i++)
            {
                for (int j = 0; j < num - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
        }
        private void SortEvenOdds(int[] array)
        {
            int count = 0;
            foreach(int i in array)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }
            int e = 0;
            int o = 0;
            int[] evenNumbers = new int[count];
            int[] oddNumbers = new int[(array.Length - count)];
            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    evenNumbers[e] = i;
                    e++;
                }
                else
                {
                    oddNumbers[o] = i;
                    o++;
                }
            }
            foreach (int n in evenNumbers)
            {
                lblArrayPares.Text += (" " + n + ",");
            }
            lblArrayPares.Text = lblArrayPares.Text.Trim(',');
            foreach (int n in oddNumbers)
            {
                lblArrayImpares.Text += (" " + n + ",");
            }
            lblArrayImpares.Text = lblArrayImpares.Text.Trim(',');
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNumerosInsert.Clear();
            lblArrayOrdenada.Text = String.Empty;
            lblArrayPares.Text = String.Empty;
            lblArrayImpares.Text = String.Empty;
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
                        "Exemplo de insert válido: 10, 2, 4, 5, 7, 1, 9, 8, 3, 6";
                    ArrayInserted.DefaultIfEmpty();
                    return false;
                }
            }
            return true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
