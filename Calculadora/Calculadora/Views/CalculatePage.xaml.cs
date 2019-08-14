using CalculatePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalculatePage : ContentPage
	{
		public CalculatePage ()
		{
			InitializeComponent ();
		}

        private double num1 = 0;
        private double num2 = 0;
        private string operador = null;
        private double resultado = 0;
     
        private void btnC_clicked(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btn0_clicked(object sender, EventArgs e)
        {
            if(txtResult.Text != "0")
            {
                txtResult.Text += "0";
            }
            
        }

        private void btn1_clicked(object sender, EventArgs e)
        {
            limpiar();
            txtResult.Text += "1";
        }

        private void btn2_clicked(object sender, EventArgs e)
        {
            limpiar();
            txtResult.Text += "2";
        }

        private void btn3_clicked(object sender, EventArgs e)
        {
            limpiar();
            txtResult.Text += "3";
        }

        private void btn4_clicked(object sender, EventArgs e)
        {
            limpiar();
            txtResult.Text += "4";
        }

        private void btn5_clicked(object sender, EventArgs e)
        {
            limpiar();
            txtResult.Text += "5";
        }

        private void btn6_clicked(object sender, EventArgs e)
        {
            limpiar();
            txtResult.Text += "6";
        }

        private void btn7_clicked(object sender, EventArgs e)
        {
            limpiar();
            txtResult.Text += "7";
        }

        private void btn8_clicked(object sender, EventArgs e)
        {
            limpiar();
            txtResult.Text += "8";
        }

        private void btn9_clicked(object sender, EventArgs e)
        {
            limpiar();
            txtResult.Text += "9";
        }

        private void btnSuma_clicked(object sender, EventArgs e)
        {
            if(txtResult.Text != "")
            {
                num1 = double.Parse(txtResult.Text);
                txtResult.Text = "";
                operador = "+";
            }
   

        }

        private void btnResta_clicked(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                num1 = double.Parse(txtResult.Text);
                txtResult.Text = "";
                operador = "-";
            }

        }

        private void btnMultipli_clicked(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                num1 = double.Parse(txtResult.Text);
                txtResult.Text = "";
                operador = "*";
            }
        }

        private void btnDivision_clicked(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                num1 = double.Parse(txtResult.Text);
                txtResult.Text = "";
                operador = "/";
            }
        }

        private void btnPorcent_clicked(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                num1 = double.Parse(txtResult.Text);
                txtResult.Text = Convert.ToString(num1 / 100);
            }
        }

        private void btnSig_clicked(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                String cambioSigno = "0";
                num1 = double.Parse(txtResult.Text);
                String num1String = Convert.ToString(num1);

                if (num1 > 0)
                {
                    cambioSigno = "-" + num1;
                }
                else if(num1 < 0)
                {
                    cambioSigno = num1String.Substring(1, num1String.Length-1);
                }

                txtResult.Text = cambioSigno;
            }
        }


        private void btnPunto_clicked(object sender, EventArgs e)
        {
            txtResult.Text += ".";
        }

        private void btnIgual_clicked(object sender, EventArgs e)
        {

            String message = "Error, no se puede dividir entre 0";

            if (txtResult.Text != "" && operador != null)
            {
                num2 = double.Parse(txtResult.Text);

                if (num2 == 0 && operador == "/")
                {
                    DependencyService.Get<Message>().LongTime(message);
                }
                else
                {

                    switch (operador)
                    {
                        case "+":
                            resultado = num1 + num2;
                            break;

                        case "-":
                            resultado = num1 - num2;
                            break;

                        case "*":
                            resultado = num1 * num2;
                            break;

                        case "/":
                             resultado = num1 / num2;
                            break;

                        default:
                            resultado = 0;
                            break;
                    }

                    txtResult.Text = Convert.ToString(resultado);

                }

            }
        }

        private void limpiar()
        {
            if(txtResult.Text == "0")
            {
                txtResult.Text = "";
            }
            
        }

    }
}