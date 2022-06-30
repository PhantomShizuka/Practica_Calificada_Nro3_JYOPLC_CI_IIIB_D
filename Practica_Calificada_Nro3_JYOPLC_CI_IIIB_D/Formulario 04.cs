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
    public partial class Formulario_04 : Form
    {
        public Formulario_04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtNum.Text, out int num))
                if(num>=100 && num<=999)
                {
                    int sum = 0;

                    while (num != 0)
                    {
                        sum += num % 10;
                        num /= 10;
                    }
                    txtSuma.Text = sum.ToString();
                    txtProducto.Text = (Num(txtNum.Text[0]) * Num(txtNum.Text[2])).ToString();
                }
                else
                    MessageBox.Show("Ingrese un numero entre 100 y 999");
            else
                MessageBox.Show("Por favor ingrese los valores correctamente");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtProducto.Clear();
            txtSuma.Clear();
            txtNum.Focus();
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
        private int Num(char cadena)
        {
            return int.Parse(cadena.ToString());
        }
    }
}
