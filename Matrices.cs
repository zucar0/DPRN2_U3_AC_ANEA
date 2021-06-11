using System;
class Matrices:Calcular{

    public string impimir = "¿Quiéres imprimir la matriz";
    public string opcionImprimir = "1.- Sí. 2.- No.";
    public Matrices(int conceptoSeleccionado, string metodoACalcular):base(conceptoSeleccionado, metodoACalcular){ }

    public override float suma()
    {
        System.Console.WriteLine("Ingresar el número de filas: ");  
        var numeroDeFilas = System.Console.ReadLine();
        int numFilas = int.Parse(numeroDeFilas);
        System.Console.WriteLine("Ingresar el número de columnas: ");
        var numeroDeColumnas = System.Console.ReadLine();
        int numColumnas = int.Parse(numeroDeColumnas);
        int[,] matrizSuma=new int[numFilas,numColumnas];
        //(Rellenar matriz) Almacenar en cada posición (i,j)
        //El primer for entra a la fila
        Random random = new Random();
        for(int filas=0; filas<matrizSuma.GetLength(0);filas++)
            {
                //El segundo for va a leer cada una de las columnas
                for( int columnas = 0; columnas<matrizSuma.GetLength(1); columnas++)
                {
                    int numero = random.Next(1, 11);
                    // var chars = "CMYWGB";
                    // var stringEnteros = new int[1];
                    // var random = new Random();
                    // for (int i = 0; i < stringEnteros.Length; i++)
                    // {
                        // stringEnteros[i] = chars[random.Next(chars.Length)];
                    //     stringEnteros[i]=numero;
                    // }
                    // var finalInt = new Int(stringEnteros);
                    // System.Console.WriteLine(finalString);
                    matrizSuma[filas,columnas] = numero;
                    // System.Console.Write(finalString);
                }
                // System.Console.WriteLine(separacion);
            }
        //Imprimir suma
        
        return base.concepto;
    }
    public override float resta()
    {
        return base.concepto;
    }
    public override float multiplicacion()
    {
        return base.concepto;
    }
    public override float division()
    {
        return base.concepto;
    }
    public override double alCuadrado()
    {
        return base.concepto;
    }
    public override double potencia()
    {
        return base.concepto;
    }

    public void matrizTranspuesta(){
        System.Console.WriteLine("La matriz transpuesta");
    }

    public void matrizCuadrada()
    {
        System.Console.WriteLine("Vamos a generar una matriz cuadrada.");
        System.Console.WriteLine("Indícamos el número de filas: ");
        var opcionFilas = Console.ReadLine();
        int numeroDeFilas = int.Parse(opcionFilas);
        System.Console.WriteLine("Indícamos el número de columnas: ");
        var opcionColumnas = Console.ReadLine();
        int numeroDeColumnas = int.Parse(opcionFilas);
        //Casificar la matriz dependiendo el tipo de matriz creada. 
        //(Matriz triangular superior, Matriz triangular inferior, Matriz diagonal ó Matriz unidad).

        //Imprimir la matriz
        System.Console.WriteLine(impimir);
        System.Console.WriteLine(opcionImprimir);
        var respuestaImprimir = Console.ReadLine();
        double imprimirSelect = double.Parse(respuestaImprimir);
        if(imprimirSelect==1)
        {
            System.Console.WriteLine("Impresión");
        }
        else if (imprimirSelect==2)
        {
            Environment.Exit(0);
        }
        else
        {
            System.Console.WriteLine("Haz elegido una opción inválidad. Se cerrará el programa.");
            Environment.Exit(0);
        }
    }
    public void matrizCuadradaAutomatica()
    {
        //b) Generar una matriz cuadrada automáticamente y de forma aleatoria
        System.Console.WriteLine("Vamos a generar una matriz cuadrada de forma aleatoria.");
        //Generarla de prueba de 5x5.

        //el usuario elegirá el tipo de matriz cuadrada a crear. 
        //(Matriz triangular superior, Matriz triangular inferior, Matriz diagonal ó Matriz unidad)
        System.Console.WriteLine("Elige la matriz cuadrada a crear");
        System.Console.WriteLine("1.- Matriz triangular superior");
        System.Console.WriteLine("2.- Matriz triangular inferior");
        System.Console.WriteLine("3.- Matriz diagonal");
        System.Console.WriteLine("4.- Matriz unidad");
        var respuestaMatriz = Console.ReadLine();
        double matrizElegida = double.Parse(respuestaMatriz);

        //Imprimir la matriz
        System.Console.WriteLine(impimir);
        System.Console.WriteLine(opcionImprimir);
        var respuestaImprimir = Console.ReadLine();
        double imprimirSelect = double.Parse(respuestaImprimir);
        if(imprimirSelect==1)
        {
            System.Console.WriteLine("Impresión");
        }
        else if (imprimirSelect==2)
        {
            Environment.Exit(0);
        }
        else
        {
            System.Console.WriteLine("Haz elegido una opción inválidad. Se cerrará el programa.");
            Environment.Exit(0);
        }
    }

    public void imprimirMatriz(int[,] matriz)
    {
        foreach(int i in matriz)
        {
            System.Console.Write("{0}",i);
        }
    }
}