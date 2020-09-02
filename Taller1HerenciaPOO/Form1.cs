using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller1HerenciaPOO
{
    public partial class Form1 : Form
    {
        Factorial factorial = new Factorial();
        Fibonacci fibonacci = new Fibonacci(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularFactorial_Click(object sender, EventArgs e)
        {
            factorial.setNumero(int.Parse(txtNumero.Text));
            lblFactorial.Visible = true;
            factorial.calcularFactorial();
            lblFactorial.Text = Convert.ToString(factorial.getFactorial()); 
        }

        private void btnCalcularFibonacci_Click(object sender, EventArgs e)
        {
            lb1.Visible = true;
            fibonacci.setNumero(int.Parse(txtNumero.Text));
             

            foreach (int valores in fibonacci.calcularFibonacci())
            {
                lb1.Items.Add(valores);
            }


        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
            lblFactorial.Visible = false;
            lb1.Visible = false;
            txtNumero.Text = String.Empty;
            lb1.Items.Clear();
        }
    }
}
