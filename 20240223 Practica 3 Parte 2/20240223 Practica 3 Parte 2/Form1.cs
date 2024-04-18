using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20240223_Practica_3_Parte_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonSum_Click(object sender, EventArgs e)
        {
            int operandoo1, operandoo2;
            operandoo1 = Convert.ToInt32(operando1.Text);
            //calif = Convert.ToInt32(txtCalif.Text);
            operandoo2 = Convert.ToInt32(operando2.Text);
            int resultado = operandoo1 + operandoo2;
            MessageBox.Show(operandoo1 + " + " + operandoo2 + " = " + resultado);

        }

        private void botonRes_Click(object sender, EventArgs e)
        {
            int operandoo1, operandoo2;
            operandoo1 = Convert.ToInt32(operando1.Text);
            //calif = Convert.ToInt32(txtCalif.Text);
            operandoo2 = Convert.ToInt32(operando2.Text);
            int resultado = operandoo1 - operandoo2;
            MessageBox.Show(operandoo1 + " - " + operandoo2 + " = " + resultado);
        }

        private void botonMul_Click(object sender, EventArgs e)
        {
            int operandoo1, operandoo2;
            operandoo1 = Convert.ToInt32(operando1.Text);
            //calif = Convert.ToInt32(txtCalif.Text);
            operandoo2 = Convert.ToInt32(operando2.Text);
            int resultado = operandoo1 * operandoo2;
            MessageBox.Show(operandoo1 + " * " + operandoo2 + " = " + resultado);
        }

        private void botonDiv_Click(object sender, EventArgs e)
        {
            double operandoo1, operandoo2;
            operandoo1 = Convert.ToDouble(operando1.Text);
            //calif = Convert.ToInt32(txtCalif.Text);
            operandoo2 = Convert.ToDouble(operando2.Text);
            double resultado = operandoo1 / operandoo2;
            MessageBox.Show(operandoo1 + " / " + operandoo2 + " = " + resultado);
        }

        private void operando1_TextChanged(object sender, EventArgs e)
        {

        }

        private void operando2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


/*

int opcion = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine("La suma de {0} y {1} es: {2}", num1, num2, resultado);
                    break;
*/