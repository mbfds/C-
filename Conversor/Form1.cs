using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtInteiro.Clear();
            txtBinario.Clear();
            txtInteiro2.Clear();
            txtBinario2.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {




			{
				try
				{
					int ValorBinario = Convert.ToInt32(txtBinario.Text);

					txtInteiro.Text = BinarioParaDecimal(ValorBinario);
				}
				catch (Exception)
				{

					MessageBox.Show("Verifique o preenchimento das informações no formulario ! ", "Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
					
					
					
					
					
					}
			


		}

		private string BinarioParaDecimal(int ValorBinario)
		{
			

			double sum = 0;

			int strn = ValorBinario.ToString().Length; //quantos digitos há no binario
			for (int i = 0; i < strn; i++)
			{
				int lastDigit = ValorBinario % 10; // pega o ultimo digito
				sum = sum + lastDigit * (Math.Pow(2, i));
				ValorBinario = ValorBinario / 10; //remove o ultimo digito
			}
			
			return sum.ToString();

		}

        private void btnCalcular2_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    //Armazena o valor em decimal, convertendo o texto em tipo inteiro
                    int ValorDecimal = int.Parse(txtInteiro2.Text);

                    //Realiza a chamada do metodo e armazena resultado na textbox
                    txtBinario2.Text = DecimalParaBinario(ValorDecimal);
                }
                catch (Exception)
                {
                    MessageBox.Show("Verifique o preenchimento das informações no formulario ! ", "Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private string DecimalParaBinario(int ValorDecimal)
        {

            int resto;
            var result = "";
            while (ValorDecimal > 0)
            {
                resto = ValorDecimal % 2;
                ValorDecimal /= 2;
                result = resto.ToString() + result;
            }
            return result.ToString();
           
        }
    }
    

    }

