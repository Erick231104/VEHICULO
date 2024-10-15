public class Mamifero : Animal
{
    public double Peso { get; set; }

    // Implementación del método CalcularAlimento
    public override double CalcularAlimento()
    {
        return 5; // 5 kg de comida por día
    }

    public override string ToString()
    {
        return base.ToString() + $", Peso: {Peso} kg, Comida Diaria: {CalcularAlimento()} kg";
    }
}

