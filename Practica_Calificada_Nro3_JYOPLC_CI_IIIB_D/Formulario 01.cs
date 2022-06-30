using System;
using System.Windows.Forms;

namespace Practica_Calificada_Nro3_JYOPLC_CI_IIIB_D
{
    public partial class Formulario_01 : Form
    {
        public Formulario_01()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtNum1.Text, out int num1) && Int32.TryParse(txtNum2.Text, out int num2))
            {

                if (num1 > num2)
                    txtResultado.Text = "El numero mayor es " + num1;
                else if (num1 < num2)
                    txtResultado.Text = "El numero mayor es " + num2;
                else
                    txtResultado.Text = "Los numeros son iguales";

                MessageBox.Show(txtResultado.Text);
            }
            else
                MessageBox.Show("Por favor ingrese los valores correctamente");
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
            txtNum1.Focus();
        }

        private void btRegresar_Click(object sender, EventArgs e)
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
