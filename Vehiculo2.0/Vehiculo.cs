using System;

namespace Vehiculo2
{
    // Clase abstracta base para Vehículos
    public abstract class Vehiculo
    {
        public string Modelo { get; set; }
        public int Anio { get; set; }

        // Método abstracto para calcular la velocidad máxima
        public abstract double CalcularVelocidadMaxima();

        // Método abstracto para obtener el tipo de combustible
        public abstract string TipoCombustible();
    }

    // Clase para Vehículo Eléctrico
    public class VehiculoElectrico : Vehiculo
    {
        public double CapacidadBateria { get; set; }

        // Implementación del cálculo de la velocidad para vehículos eléctricos
        public override double CalcularVelocidadMaxima()
        {
            return CapacidadBateria * 3; // 3 km/h por kWh
        }

        public override string TipoCombustible()
        {
            return "Eléctrico";
        }
    }

    // Clase para Vehículo de Gasolina
    public class VehiculoGasolina : Vehiculo
    {
        public double Cilindrada { get; set; }

        // Implementación del cálculo de la velocidad para vehículos de gasolina
        public override double CalcularVelocidadMaxima()
        {
            return Cilindrada / 10; // 10 cm³
        }

        public override string TipoCombustible()
        {
            return "Gasolina";
        }
    }

    // Clase sellada para Vehículo Híbrido
    public sealed class VehiculoHibrido : Vehiculo
    {
        public double CapacidadBateria { get; set; }
        public double Cilindrada { get; set; }

        // Implementación del cálculo de la velocidad para vehículos híbridos
        public override double CalcularVelocidadMaxima()
        {
            return (CapacidadBateria * 2) + (Cilindrada / 15); // Combinación de ambos
        }

        public override string TipoCombustible()
        {
            return "Híbrido (Eléctrico y Gasolina)";
        }
    }
}

