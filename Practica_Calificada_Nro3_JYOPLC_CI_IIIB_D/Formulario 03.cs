using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Calificada_Nro3_JYOPLC_CI_IIIB_D
{
    public partial class Formulario_03 : Form
    {
        int? num1;
        public Formulario_03()
        {
            InitializeComponent();
        }

        private void btnCalcular1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNum1.Text, out int a))
            {
                num1 = a;

                if (num1 % 2 == 0)
                    txtEsParImpar.Text = "El numero ingresado es par";
                else
                    txtEsParImpar.Text = "El numero ingresado es impar";
            }   
            else
                MessageBox.Show("Por favor ingrese los valores correctamente");
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            if (num1.HasValue)
            {
                if (int.TryParse(txtNum2.Text, out int num2))
                    if(num2 >= 10 && num2 <= 99)
                    {
                        txtSuma.Text = (num1 + num2).ToString();
                        txtPotencia.Text = Math.Pow(Convert.ToDouble(num1), Convert.ToDouble(num2)).ToString();
                    }
                    else
                        MessageBox.Show("Ingrese numeros desde 10 hasta 99");
                else
                    MessageBox.Show("Por favor ingrese los valores correctamente");
            }
            else
                MessageBox.Show("Por favor primero ejecute el modulo anterior");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEsParImpar.Clear();
            txtNum1.Clear();
            txtNum2.Clear();
            txtPotencia.Clear();
            txtSuma.Clear();
            txtNum1.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir del formulario?",
              "Consulta",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
