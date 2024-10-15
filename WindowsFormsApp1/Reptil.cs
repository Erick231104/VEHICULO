public sealed class Reptil : Animal
{
    public double TemperaturaIdeal { get; set; }

    // Implementación del método CalcularAlimento
    public override double CalcularAlimento()
    {
        return 2; // 2 kg de comida por día
    }

    public override string ToString()
    {
        return base.ToString() + $", Temperatura Ideal: {TemperaturaIdeal} °C, Comida Diaria: {CalcularAlimento()} kg";
    }
}
