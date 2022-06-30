using System;
using System.Windows.Forms;

namespace Practica_Calificada_Nro3_JYOPLC_CI_IIIB_D
{
    public partial class Formulario_02 : Form
    {
        public Formulario_02()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtNum1.Text, out int num1) && Int32.TryParse(txtNum2.Text, out int num2) && Int32.TryParse(txtNum3.Text, out int num3))
            {
                int mayor = num1;

                if (mayor < num2)
                    mayor = num2;
                if (mayor < num3)
                    mayor = num3;

                txtResultado.Text = "El numero mayor es " + mayor;

                if (num1 == num2 && num2 == num3)
                    txtResultado.Text = "Los numeros ingresados son iguales";
            }
            else
                MessageBox.Show("Por favor ingrese los valores correctamente");
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum3.Clear();
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
