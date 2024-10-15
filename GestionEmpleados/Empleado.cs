using System;

namespace GestionEmpleados
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public int AnioIngreso { get; set; }

        public abstract double CalcularSalarioMensual();
    }

    public class EmpleadoAsalariado : Empleado
    {

        public double SalarioMensual { get; set; }
        public override double CalcularSalarioMensual()
        {
            return SalarioMensual;
        }
    }

    public class EmpleadoPorHoras : Empleado
    {
        public double TarifaPorHora { get; set; }
        public int HorasTrabajadas { get; set; }

        public override double CalcularSalarioMensual()
        {
            return TarifaPorHora * HorasTrabajadas;
        }
    }

    public class EmpleadosPorComision : Empleado
    {
        public double SalarioBase { get; set; }
        public double Ventas { get; set; }
        public double ProcentajeComision { get; set; }

        public override double CalcularSalarioMensual()
        {
            return SalarioBase + (Ventas * (ProcentajeComision / 100));
        }
    } 
}
