using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEsstudiante
{
    public partial class FormEstudiante : Form
    {

        public Estudiante Estudiante
        {
            get
            {
                return new Estudiante
                {
                    Nombre = txtNombre.Text,
                    Edad = (int)Edad.Value,
                    Grado = cmbGrado.SelectedItem.ToString(),
                    Estado = radioButtonBecado.Checked ? "Becado" : "Regular"
                };
            }
        }

        public FormEstudiante()
        {
            InitializeComponent();
        }

       

        public FormEstudiante(Estudiante estudiante) : this()
        {
            txtNombre.Text = estudiante.Nombre;
            Edad.Value = estudiante.Edad;
            cmbGrado.SelectedItem = estudiante.Grado;
            if (estudiante.Estado == "Becado")
                radioButtonBecado.Checked = true;
            else
                radioButtonRegular.Checked = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            Estudiante estudiante = new Estudiante
            {
                Nombre = txtNombre.Text,
                Edad = (int)Edad.Value,
                Grado = cmbGrado.SelectedItem.ToString(),
                Estado = radioButtonBecado.Checked ? "Becado" : "Regular"
            };

            DialogResult = DialogResult.OK;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void gbEstado_Enter(object sender, EventArgs e)
        {

        }
    }
}
