namespace Pasteles;

public class Ingrediente
{
   public string nombrePastel;
    public int cantidadPastel;
    public double precioPastel;

    public Ingrediente(string nombre, int cantidad, double precio)
    {
        this.nombrePastel = nombre;
        this.cantidadPastel = cantidad;
        this.precioPastel = precio;
    }
}    
