public class Ave : Animal
{
    public double TamañoAlas { get; set; }

    // Implementación del método CalcularAlimento
    public override double CalcularAlimento()
    {
        return 1; // 1 kg de comida por día
    }

    public override string ToString()
    {
        return base.ToString() + $", Tamaño de Alas: {TamañoAlas} cm, Comida Diaria: {CalcularAlimento()} kg";
    }
}
