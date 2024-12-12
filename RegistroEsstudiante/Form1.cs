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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Estudiante> listaEstudiantes = new List<Estudiante>();


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var formulario = new FormEstudiante();
            if (formulario.ShowDialog() == DialogResult.OK)
            {
                listaEstudiantes.Add(formulario.Estudiante);
                ActualizarDataGridView();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListaEstudiantes.SelectedRows.Count > 0)
            {
                int indice = dgvListaEstudiantes.SelectedRows[0].Index;
                var estudiante = listaEstudiantes[indice];
                var formulario = new FormEstudiante(estudiante);

                if (formulario.ShowDialog() == DialogResult.OK)
                {
                    listaEstudiantes[indice] = formulario.Estudiante;
                    ActualizarDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un estudiante para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListaEstudiantes.SelectedRows.Count > 0)
            {
                int indice = dgvListaEstudiantes.SelectedRows[0].Index;
                listaEstudiantes.RemoveAt(indice);
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Selecciona un estudiante para eliminar.");
            }
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            if (listaEstudiantes.Count > 0)
            {
                var promedioEdad = listaEstudiantes.Average(estuadiante => estuadiante.Edad);
                var totalPorGrado = listaEstudiantes.GroupBy(estudiante => estudiante.Grado)
                                                   .Select(g => $"{g.Key}: {g.Count()} estudiantes")
                                                   .ToList();
                var porcentajeBecados = listaEstudiantes.Count(estudiante => estudiante.Estado == "Becado") * 100.0 / listaEstudiantes.Count;

                MessageBox.Show($"Promedio de Edad: {promedioEdad:F1}\n" +
                                $"Total por Grado:\n{string.Join("\n", totalPorGrado)}\n" +
                                $"Porcentaje de Becados: {porcentajeBecados:F2}%");
            }
            else
            {
                MessageBox.Show("No hay estudiantes registrados.");
            }
        }

        private void ActualizarDataGridView()
        {
            dgvListaEstudiantes.DataSource = null;
            dgvListaEstudiantes.DataSource = listaEstudiantes;
        }


    }
}
