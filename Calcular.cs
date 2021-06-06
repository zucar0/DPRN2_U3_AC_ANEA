abstract class Calcular{
    //Datos miembro.
    protected int concepto;
    protected string metodo;
    //Método Pais con parámetros
    public Calcular(int conceptoSeleccionado, string metodoACalcular){
        concepto=conceptoSeleccionado;
        metodo=metodoACalcular;
    }
    //Método para mostrar país elegido
    public void mostrarSeleccion()
    {
        if(concepto==1)
        {
            System.Console.WriteLine("{0}. Concepto Número Reales", concepto);
        }
        else if(concepto==2)
        {
            System.Console.WriteLine("{0}. Concepto Fracciones", concepto);
        }
        else if(concepto==3)
        {
            System.Console.WriteLine("{0}. Concepto Matrices", concepto);
        }
    }
    public abstract string suma();
    public abstract string resta();
    public abstract string multiplicacion();
    public abstract string division();
    public abstract string alCuadrado();
    public abstract string potencia();
    //Interfaz para el pais
    public int DatoConcepto{
        get{
            return concepto;
        }set{
            concepto = value;
        }
    }
    public string DatoMetodo{
        get
        {
            return metodo;
        }
        set
        {
            metodo = value;
        }
    }
    //Destructor
    ~Calcular() {
        concepto=0; 
        metodo="";
        // Console.Write("Este es el destructor ejecutándose para destruir el objeto de la clase Factura");
    } 
}