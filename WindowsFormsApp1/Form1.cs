using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Llenar el ComboBox con los tipos de animales
            cbTipoAnimal.Items.Add("Mamífero");
            cbTipoAnimal.Items.Add("Ave");
            cbTipoAnimal.Items.Add("Reptil");
            cbTipoAnimal.SelectedIndex = 0; // Selección predeterminada
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostrar u ocultar los campos según el tipo de animal seleccionado
            if (cbTipoAnimal.SelectedItem.ToString() == "Mamífero")
            {
                lblPeso.Visible = txtPeso.Visible = true;
                lblTamañoAlas.Visible = txtTamañoAlas.Visible = false;
                lblTemperatura.Visible = txtTemperatura.Visible = false;
            }
            else if (cbTipoAnimal.SelectedItem.ToString() == "Ave")
            {
                lblPeso.Visible = txtPeso.Visible = false;
                lblTamañoAlas.Visible = txtTamañoAlas.Visible = true;
                lblTemperatura.Visible = txtTemperatura.Visible = false;
            }
            else if (cbTipoAnimal.SelectedItem.ToString() == "Reptil")
            {
                lblPeso.Visible = txtPeso.Visible = false;
                lblTamañoAlas.Visible = txtTamañoAlas.Visible = false;
                lblTemperatura.Visible = txtTemperatura.Visible = true;
            }
        }

        private void btnMostrarInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = null;

                // Crear el objeto animal según el tipo seleccionado
                if (cbTipoAnimal.SelectedItem.ToString() == "Mamífero")
                {
                    animal = new Mamifero
                    {
                        Nombre = txtNombre.Text,
                        Edad = int.Parse(txtEdad.Text),
                        Habitat = txtHabitat.Text,
                        Peso = double.Parse(txtPeso.Text)
                    };
                }
                else if (cbTipoAnimal.SelectedItem.ToString() == "Ave")
                {
                    animal = new Ave
                    {
                        Nombre = txtNombre.Text,
                        Edad = int.Parse(txtEdad.Text),
                        Habitat = txtHabitat.Text,
                        TamañoAlas = double.Parse(txtTamañoAlas.Text)
                    };
                }
                else if (cbTipoAnimal.SelectedItem.ToString() == "Reptil")
                {
                    animal = new Reptil
                    {
                        Nombre = txtNombre.Text,
                        Edad = int.Parse(txtEdad.Text),
                        Habitat = txtHabitat.Text,
                        TemperaturaIdeal = double.Parse(txtTemperatura.Text)
                    };
                }

                // Mostrar la información completa del animal
                lblResultado.Text = animal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los datos. Verifique los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
