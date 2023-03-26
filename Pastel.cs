namespace Pasteles;

public class Pastel:InterfazPastelitos
{
    public string nombreP;
    public int tamañoP;
    List<Ingrediente> listaIngredientes=new List<Ingrediente>();
    public Pastel(string nombre, int tamaño){
        this.nombreP=nombre;
        this.tamañoP=tamaño;
    }
    

    public void agregar_ingrediente(Ingrediente i)
    {
        listaIngredientes.Add(i);
    }

    public double calcular_costo()
    {
        double total=0;
        foreach (var ingrediente in listaIngredientes)
        {
            total+=(ingrediente.precioPastel*ingrediente.cantidadPastel);
        }
        return total;
    }


    public int cantidad_ingredientes()
    {
        return listaIngredientes.Count;
    }

    public string listar_ingredientes()
    {
        string salida="Lista de Ingredientes del pastelito de chocolate\n";
        foreach (var ingrediente in listaIngredientes)
        {
            salida+=ingrediente.nombrePastel+" Cantidad: "+ingrediente.cantidadPastel+"\n";
        }
        return salida;
    }
}
