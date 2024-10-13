using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehiculo2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbmTipoVehiculo.Items.Add("Vehículo Eléctrico");
            cbmTipoVehiculo.Items.Add("Vehículo de Gasolina");
            cbmTipoVehiculo.Items.Add("Vehículo Híbrido");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbmTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostramos y ocultamos campos dinámicamente según el tipo de vehículo
            if (cbmTipoVehiculo.SelectedItem.ToString() == "Vehículo Eléctrico")
            {
                lblCilindrada.Visible = false;
                txtCilindrada.Visible = false;
                lblCapacidadBateria.Visible = true;
                txtCapacidadBateria.Visible = true;
            }
            else if (cbmTipoVehiculo.SelectedItem.ToString() == "Vehículo de Gasolina")
            {
                lblCapacidadBateria.Visible = false;
                txtCapacidadBateria.Visible = false;
                lblCilindrada.Visible = true;
                txtCilindrada.Visible = true;
            }
            else if (cbmTipoVehiculo.SelectedItem.ToString() == "Vehículo Híbrido")
            {
                lblCapacidadBateria.Visible = true;
                txtCapacidadBateria.Visible = true;
                lblCilindrada.Visible = true;
                txtCilindrada.Visible = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Crear el objeto del vehículo según la selección
            Vehiculo vehiculo = null;

            if (cbmTipoVehiculo.SelectedItem.ToString() == "Vehículo Eléctrico")
            {
                vehiculo = new VehiculoElectrico
                {
                    Modelo = txtModelo.Text,
                    Anio = int.Parse(txtAnio.Text),
                    CapacidadBateria = double.Parse(txtCapacidadBateria.Text)
                };
            }
            else if (cbmTipoVehiculo.SelectedItem.ToString() == "Vehículo de Gasolina")
            {
                vehiculo = new VehiculoGasolina
                {
                    Modelo = txtModelo.Text,
                    Anio = int.Parse(txtAnio.Text),
                    Cilindrada = double.Parse(txtCilindrada.Text)
                };
            }
            else if (cbmTipoVehiculo.SelectedItem.ToString() == "Vehículo Híbrido")
            {
                vehiculo = new VehiculoHibrido
                {
                    Modelo = txtModelo.Text,
                    Anio = int.Parse(txtAnio.Text),
                    CapacidadBateria = double.Parse(txtCapacidadBateria.Text),
                    Cilindrada = double.Parse(txtCilindrada.Text)
                };
            }

            // Calcular la velocidad máxima y mostrar el resultado
            if (vehiculo != null)
            {
                lblResultado.Text = $"Velocidad Máxima: {vehiculo.CalcularVelocidadMaxima()} km/h";
                lblCombustible.Text = $"Tipo de Combustible: {vehiculo.TipoCombustible()}";

            }
        }

        private void lblAño_Click(object sender, EventArgs e)
        {

        }

        private void txtAño_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
