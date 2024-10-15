using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbTipoEmpleado.Items.Add("Empleado Asalariado");
            cbTipoEmpleado.Items.Add("Empleado por Horas");
            cbTipoEmpleado.Items.Add("Empleado por Comisión");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ocultar todos los campos al inicio
            lblSalario.Visible = false;
            txtSalario.Visible = false;
            lblTarifaPorHora.Visible = false;
            txtTarifaPorHora.Visible = false;
            lblHorasTrabajadas.Visible = false;
            txtHorasTrabajadas.Visible = false;
            lblVentas.Visible = false;
            txtVentas.Visible = false;
            lblPorcentajeComision.Visible = false;
            txtPorcentajeComision.Visible = false;

            // Mostrar los campos específicos según el tipo de empleado seleccionado
            if (cbTipoEmpleado.SelectedItem != null)
            {
                string tipoEmpleado = cbTipoEmpleado.SelectedItem.ToString();

                if (tipoEmpleado == "Empleado Asalariado")
                {
                    // Mostrar solo los campos relacionados con Empleado Asalariado
                    lblSalario.Visible = true;
                    txtSalario.Visible = true;
                }
                else if (tipoEmpleado == "Empleado por Horas")
                {
                    // Mostrar solo los campos relacionados con Empleado por Horas
                    lblTarifaPorHora.Visible = true;
                    txtTarifaPorHora.Visible = true;
                    lblHorasTrabajadas.Visible = true;
                    txtHorasTrabajadas.Visible = true;
                }
                else if (tipoEmpleado == "Empleado por Comisión")
                {
                    // Mostrar solo los campos relacionados con Empleado por Comisión
                    lblSalario.Visible = true;
                    txtSalario.Visible = true;
                    lblVentas.Visible = true;
                    txtVentas.Visible = true;
                    lblPorcentajeComision.Visible = true;
                    txtPorcentajeComision.Visible = true;
                }
            }
            if (cbTipoEmpleado.SelectedItem.ToString() == "Empleado Asalariado")
            {
                lblTarifaPorHora.Visible = false;
                txtTarifaPorHora.Visible = false;
                lblHorasTrabajadas.Visible = false;
                txtHorasTrabajadas.Visible = false;
                lblVentas.Visible = false;
                txtVentas.Visible = false;
                lblPorcentajeComision.Visible = false;
                txtPorcentajeComision.Visible = false;

                lblSalario.Visible = true;
                txtSalario.Visible = true;
            }
            else if (cbTipoEmpleado.SelectedItem.ToString() == "Empleado por Hora")
            {
                lblSalario.Visible = false;
                txtSalario.Visible = false;
                lblVentas.Visible = false;
                txtVentas.Visible = false;
                lblPorcentajeComision.Visible = false;
                txtPorcentajeComision.Visible = false;

                lblTarifaPorHora.Visible = true;
                txtTarifaPorHora.Visible = true;
                lblHorasTrabajadas.Visible = true;
                txtHorasTrabajadas.Visible = true;
            }
            else if (cbTipoEmpleado.SelectedItem.ToString() == "Salario Por Comision")
            {
                lblTarifaPorHora.Visible = false;
                txtTarifaPorHora.Visible = false;
                lblHorasTrabajadas.Visible = false;
                txtHorasTrabajadas.Visible = false;

                lblSalario.Visible = true;
                txtSalario.Visible = true;
                lblVentas.Visible = true;
                txtVentas.Visible = true;
                lblPorcentajeComision.Visible = true;
                txtPorcentajeComision.Visible = true;
            }
        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            
            
                try
                {
                    // Verificar que el ComboBox tiene un valor seleccionado
                    if (cbTipoEmpleado.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione un tipo de empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Empleado empleado = null;

                    // Crear el objeto del empleado según la selección
                    if (cbTipoEmpleado.SelectedItem.ToString() == "Empleado Asalariado")
                    {
                        // Verificar que los campos necesarios no estén vacíos y se puedan convertir a los tipos correctos
                        if (string.IsNullOrWhiteSpace(txtSalario.Text) || !double.TryParse(txtSalario.Text, out double salario))
                        {
                            MessageBox.Show("Ingrese un salario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        empleado = new EmpleadoAsalariado
                        {
                            Nombre = txtNombre.Text,
                            AnioIngreso = int.Parse(txtAnioIngreso.Text),
                            SalarioMensual = salario
                        };
                    }
                    else if (cbTipoEmpleado.SelectedItem.ToString() == "Empleado por Horas")
                    {
                        // Verificar los campos necesarios para empleado por horas
                        if (string.IsNullOrWhiteSpace(txtTarifaPorHora.Text) || !double.TryParse(txtTarifaPorHora.Text, out double tarifaPorHora))
                        {
                            MessageBox.Show("Ingrese una tarifa por hora válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(txtHorasTrabajadas.Text) || !int.TryParse(txtHorasTrabajadas.Text, out int horasTrabajadas))
                        {
                            MessageBox.Show("Ingrese horas trabajadas válidas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        empleado = new EmpleadoPorHoras
                        {
                            Nombre = txtNombre.Text,
                            AnioIngreso = int.Parse(txtAnioIngreso.Text),
                            TarifaPorHora = tarifaPorHora,
                            HorasTrabajadas = horasTrabajadas
                        };
                    }
                    else if (cbTipoEmpleado.SelectedItem.ToString() == "Empleado por Comisión")
                    {
                        // Verificar los campos necesarios para empleado por comisión
                        if (string.IsNullOrWhiteSpace(txtSalario.Text) || !double.TryParse(txtSalario.Text, out double salarioBase))
                        {
                            MessageBox.Show("Ingrese un salario base válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(txtVentas.Text) || !double.TryParse(txtVentas.Text, out double ventas))
                        {
                            MessageBox.Show("Ingrese un monto de ventas válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        if (string.IsNullOrWhiteSpace(txtPorcentajeComision.Text) || !double.TryParse(txtPorcentajeComision.Text, out double porcentajeComision))
                        {
                            MessageBox.Show("Ingrese un porcentaje de comisión válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        empleado = new EmpleadosPorComision
                        {
                            Nombre = txtNombre.Text,
                            AnioIngreso = int.Parse(txtAnioIngreso.Text),
                            SalarioBase = salarioBase,
                            Ventas = ventas,
                            ProcentajeComision = porcentajeComision
                        };
                    }

                    // Mostrar el resultado solo si se creó el empleado correctamente
                    if (empleado != null)
                    {
                        double salarioCalculado = empleado.CalcularSalarioMensual();
                        lblResultado.Text = $"Salario Mensual: {salarioCalculado:C}";
                    }
                    else
                    {
                        lblResultado.Text = "Error: No se pudo calcular el salario.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al calcular el salario. Verifique los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }
    }
}
