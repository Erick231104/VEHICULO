public abstract class Animal
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Habitat { get; set; }

    // Método abstracto para calcular la cantidad de alimento diaria
    public abstract double CalcularAlimento();

    // Sobrescribir ToString para mostrar la información del animal
    public override string ToString()
    {
        return $"Nombre: {Nombre}, Edad: {Edad}, Habitat: {Habitat}";
    }
}
