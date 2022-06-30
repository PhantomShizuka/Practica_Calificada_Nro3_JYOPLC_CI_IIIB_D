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
    public partial class Formulario_05 : Form
    {
        public Formulario_05()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(float.TryParse(txtFinal.Text, out float final) && float.TryParse(txtParcial.Text, out float parcial) &&
               final>=0 && final<=20 && parcial>=0 && parcial <= 20)
            {
                txtPromedio.Text = Math.Round((final + parcial) / 2).ToString();

                if (Math.Round((final + parcial) / 2) >= 13)
                    txtObservacion.Text = "Aprobado";
                else
                    txtObservacion.Text = "Desaprobado";
            }
            else
                MessageBox.Show("Por favor ingrese los valores correctamente");
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "A" + (int.Parse(txtCodigo.Text.Substring(1, 3)) + 1).ToString("D3");
            txtCurso.Clear();
            txtFinal.Clear();
            txtNombre.Clear();
            txtObservacion.Clear();
            txtParcial.Clear();
            txtPromedio.Clear();
            txtNombre.Focus();
        }
    }
}
