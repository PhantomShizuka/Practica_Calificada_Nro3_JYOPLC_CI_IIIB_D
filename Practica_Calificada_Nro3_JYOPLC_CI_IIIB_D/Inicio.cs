using System;
using System.Windows.Forms;

namespace Practica_Calificada_Nro3_JYOPLC_CI_IIIB_D
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void btEjecutar_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Ejecutar(new Formulario_01());
                    break;
                case 1:
                    Ejecutar(new Formulario_02());
                    break;
                case 2:
                    Ejecutar(new Formulario_03());
                    break;
                case 3:
                    Ejecutar(new Formulario_04());
                    break;
                case 4:
                    Ejecutar(new Formulario_05());
                    break;
                default:
                    MessageBox.Show("Hecho por Joaquin Yoplac");
                    break;
            }
        }

        private void Ejecutar(Form form)
        {
            Hide();
            form.ShowDialog();
            Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?",
              "Consulta",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Creditos xD");
        }
    }
}
