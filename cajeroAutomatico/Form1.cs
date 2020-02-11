using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajeroAutomatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {  
            try
            {       
                double cantidad = double.Parse(txtcantidaingresada.Text),
                       cantcan = double.Parse(txtcancelar.Text), res,  
                j = 0;

                if (cantidad < cantcan)
                {label1.Text = "";
                    res = cantcan - cantidad;
                    label1.Text = " Saldo insuficiente, necesita $ "  +  res ;
                    txtcantidaingresada.Text = "";
                }
                    res = cantcan - cantidad;
                double[] billetes = { 100, 50, 20, 10, 5, 1, 0.25, 0.10, 0.05, 0.01 };
                if (cantidad > cantcan)
                {
                    cantidad = cantidad - cantcan;
                    foreach (double billete in billetes)
                    {
                        while (Math.Round(cantidad, 2) >= billete)
                        {
                            cantidad -= billete;
                            j++;
                        }
                        if (j > 0)
                        {
                            lsbresultado.Items.Add(j + (billete > 1 ? " billetes " : " monedas ") + billete);
                            j = 0;
                           
                        }
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error en cajero automatico", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void txtcantidaingresada_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double cantidad = double.Parse(txtcantidaingresada.Text);
                txtcantidaingresada.BackColor = Color.White;
                erpCajeroAutomatico.SetError(txtcantidaingresada, "");
            }
            catch (Exception ex)
            {
                txtcantidaingresada.BackColor = Color.MistyRose;
                erpCajeroAutomatico.SetError(txtcantidaingresada, "Por favor ingrese un valor numerico.");
            }
        }
        private void txtcancelar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double cantidad = double.Parse(txtcancelar.Text);
                txtcancelar.BackColor = Color.White;
                erpCajeroAutomatico.SetError(txtcancelar, "");
            }
            catch (Exception ex)
            {
                txtcancelar.BackColor = Color.MistyRose;
                erpCajeroAutomatico.SetError(txtcancelar, "Por favor ingrese un valor numerico.");
            }
        }

        private void btnfibo_Click(object sender, EventArgs e)
        {
            
                int n = int.Parse(num.Text), x = 0, y = 1, xy, i;
                string respuesta = "";
                for (i = 0; i < n; i++)
                {
                    xy = x;
                    x = y;
                    y = xy + x;
                    respuesta += " es " + x + " la suma  " + y + "\n";
                    lblresp.Text = respuesta;
                }



            }

        private void btnprimo_Click(object sender, EventArgs e)
        {
            int numero, i, cont;
            string respuesta = "El numero  : \n";
            cont = 0;
            numero = int.Parse(num.Text);
            for (i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                { cont = cont + 1; }
            }

            if (cont > 2)

            { respuesta += numero + (" no primo"); }

            else
            { respuesta += numero + (" es primo"); }

            lblresp.Text = respuesta;
        }
    }
    }
