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
        int suma = 0;
        for(int filas=0; filas<matrizSuma.GetLength(0);filas++)
            {
                //El segundo for va a leer cada una de las columnas
                for( int columnas = 0; columnas<matrizSuma.GetLength(1); columnas++)
                {
                    int numero = random.Next(1, 11);
                    matrizSuma[filas,columnas] = numero;
                    suma=suma+numero;
                }
            }
        //Imprimir suma
        System.Console.WriteLine("La suma de la matriz es {0}", suma);
        System.Console.WriteLine("¿Imprimir matriz?\n1. Sí. 2. No.");
        var impresion = System.Console.ReadLine();
        int decideImprimir = int.Parse(impresion);
        if(decideImprimir==1)
        {
            imprimirMatriz(matrizSuma);
        }
        else if(decideImprimir==2)
        {
            System.Console.WriteLine("Se cerrará el programa");
            Environment.Exit(0);
        }
        return base.concepto;
    }
    public override float resta()
    {
        System.Console.WriteLine("Ingresar el número de filas: ");  
        var numeroDeFilas = System.Console.ReadLine();
        int numFilas = int.Parse(numeroDeFilas);
        System.Console.WriteLine("Ingresar el número de columnas: ");
        var numeroDeColumnas = System.Console.ReadLine();
        int numColumnas = int.Parse(numeroDeColumnas);
        int[,] matrizResta=new int[numFilas,numColumnas];
        //(Rellenar matriz) Almacenar en cada posición (i,j)
        //El primer for entra a la fila
        Random random = new Random();
        int resta = 0;
        for(int filas=0; filas<matrizResta.GetLength(0);filas++)
            {
                //El segundo for va a leer cada una de las columnas
                for( int columnas = 0; columnas<matrizResta.GetLength(1); columnas++)
                {
                    int numero = random.Next(1, 11);
                    matrizResta[filas,columnas] = numero;
                    resta=resta-numero;
                }
            }
        //Imprimir resta
        System.Console.WriteLine("La resta de todos los elementos de la matriz es {0}", resta);
        System.Console.WriteLine("¿Imprimir matriz?\n1. Sí. 2. No.");
        var impresion = System.Console.ReadLine();
        int decideImprimir = int.Parse(impresion);
        if(decideImprimir==1)
        {
            imprimirMatriz(matrizResta);
        }
        else if(decideImprimir==2)
        {
            System.Console.WriteLine("Se cerrará el programa");
            Environment.Exit(0);
        }
        return base.concepto;
    }
    public override float multiplicacion()
    {
        System.Console.WriteLine("Ingresar el número de filas: ");  
        var numeroDeFilas = System.Console.ReadLine();
        int numFilas = int.Parse(numeroDeFilas);
        System.Console.WriteLine("Ingresar el número de columnas: ");
        var numeroDeColumnas = System.Console.ReadLine();
        int numColumnas = int.Parse(numeroDeColumnas);
        int[,] matrizMultiplicacion=new int[numFilas,numColumnas];
        //(Rellenar matriz) Almacenar en cada posición (i,j)
        //El primer for entra a la fila
        Random random = new Random();
        int producto=1;
        for(int filas=0; filas<matrizMultiplicacion.GetLength(0);filas++)
            {
                //El segundo for va a leer cada una de las columnas
                for( int columnas = 0; columnas<matrizMultiplicacion.GetLength(1); columnas++)
                {
                    int numero = random.Next(1, 11);
                    matrizMultiplicacion[filas,columnas] = numero;
                    producto*=matrizMultiplicacion[filas,columnas];
                }
            }
        //Imprimir multiplicación
        System.Console.WriteLine("La multiplicación de todos los elementos de la matriz es {0}", producto);
        System.Console.WriteLine("¿Imprimir matriz?\n1. Sí. 2. No.");
        var impresion = System.Console.ReadLine();
        int decideImprimir = int.Parse(impresion);
        if(decideImprimir==1)
        {
            imprimirMatriz(matrizMultiplicacion);
        }
        else if(decideImprimir==2)
        {
            System.Console.WriteLine("Se cerrará el programa");
            Environment.Exit(0);
        }
        return base.concepto;
    }
    public override float division()
    {
        System.Console.WriteLine("Ingresar el número de filas: ");  
        var numeroDeFilas = System.Console.ReadLine();
        int numFilas = int.Parse(numeroDeFilas);
        System.Console.WriteLine("Ingresar el número de columnas: ");
        var numeroDeColumnas = System.Console.ReadLine();
        int numColumnas = int.Parse(numeroDeColumnas);
        float[,] matrizDivision=new float[numFilas,numColumnas];
        //(Rellenar matriz) Almacenar en cada posición (i,j)
        //El primer for entra a la fila
        Random random = new Random();
        float producto=1;
        for(int filas=0; filas<matrizDivision.GetLength(0);filas++)
            {
                //El segundo for va a leer cada una de las columnas
                for( int columnas = 0; columnas<matrizDivision.GetLength(1); columnas++)
                {
                    float numero = random.Next(1, 11);
                    matrizDivision[filas,columnas] = numero;
                    producto/=matrizDivision[filas,columnas];
                }
            }
        //Imprimir resta
        System.Console.WriteLine("La división de todos los elementos de la matriz es {0}", producto);
        System.Console.WriteLine("¿Imprimir matriz?\n1. Sí. 2. No.");
        var impresion = System.Console.ReadLine();
        int decideImprimir = int.Parse(impresion);
        if(decideImprimir==1)
        {
            imprimirMatrizFloat(matrizDivision);
        }
        else if(decideImprimir==2)
        {
            System.Console.WriteLine("Se cerrará el programa");
            Environment.Exit(0);
        }
        return base.concepto;
    }
    public override double alCuadrado()
    {
        System.Console.WriteLine("Ingresar el número de filas: ");  
        var numeroDeFilas = System.Console.ReadLine();
        int numFilas = int.Parse(numeroDeFilas);
        System.Console.WriteLine("Ingresar el número de columnas: ");
        var numeroDeColumnas = System.Console.ReadLine();
        int numColumnas = int.Parse(numeroDeColumnas);
        float[,] matrizAlCuadrado=new float[numFilas,numColumnas];
        float[,] matrizAlCuadrado2=new float[numFilas,numColumnas];
        //(Rellenar matriz) Almacenar en cada posición (i,j)
        //El primer for entra a la fila
        Random random = new Random();
        for(int filas=0; filas<matrizAlCuadrado.GetLength(0);filas++)
        {
            //El segundo for va a leer cada una de las columnas
            for( int columnas = 0; columnas<matrizAlCuadrado.GetLength(1); columnas++)
            {
                float numero = random.Next(1, 11);
                matrizAlCuadrado[filas,columnas] = numero;
            }
        }
        //Operación para obtener el cuadrado.
        for(int i = 0; i < matrizAlCuadrado.GetLength(0); i++){
            for (int j = 0; j < matrizAlCuadrado.GetLength(1); j++){
                matrizAlCuadrado2 [i,j] = matrizAlCuadrado[i,j] * matrizAlCuadrado[i,j];
            }
        }
        //Impresión
        System.Console.WriteLine("Matriz inicial");
        imprimirMatrizFloat(matrizAlCuadrado);
        System.Console.WriteLine("\n");
        System.Console.WriteLine("Resultado de cada elemento de la matriz al cuadrado");
        imprimirMatrizFloat(matrizAlCuadrado2);
        System.Console.WriteLine("\n");
        // System.Console.WriteLine("-----RESULTADO-----");
        // for(int i = 0; i < matrizAlCuadrado2.GetLength(0); i++) {
        //     for(int j = 0; j < matrizAlCuadrado2.GetLength(1); j++) {
        //         System.Console.WriteLine("Valor en la posicion ["+i+"]["+j+"]: " + matrizAlCuadrado2[i,j] + " \n");
        //     }
        // }
        return base.concepto;
    }
    public override double potencia()
    {
        System.Console.WriteLine("Ingresar el número de filas: ");  
        var numeroDeFilas = System.Console.ReadLine();
        int numFilas = int.Parse(numeroDeFilas);
        System.Console.WriteLine("Ingresar el número de columnas: ");
        var numeroDeColumnas = System.Console.ReadLine();
        int numColumnas = int.Parse(numeroDeColumnas);
        double[,] matrizPotencia=new double[numFilas,numColumnas];
        double[,] matrizPotenciada=new double[numFilas,numColumnas];
        //(Rellenar matriz) Almacenar en cada posición (i,j)
        //El primer for entra a la fila
        Random random = new Random();
        for(int filas=0; filas<matrizPotencia.GetLength(0);filas++)
        {
            //El segundo for va a leer cada una de las columnas
            for( int columnas = 0; columnas<matrizPotencia.GetLength(1); columnas++)
            {
                double numero = random.Next(1, 11);
                matrizPotencia[filas,columnas] = numero;
            }
        }
        //Impresión
        System.Console.WriteLine("Esta es la matriz generada.");
        imprimirMatrizDouble(matrizPotencia);
        System.Console.WriteLine("Por favor ingresa el número de la potencia: ");
        var ingreso2 = Console.ReadLine();
        float segundoNumero = float.Parse(ingreso2);

        //Operación para obtener la potencia.
        for(int i = 0; i < matrizPotencia.GetLength(0); i++){
            for (int j = 0; j < matrizPotencia.GetLength(1); j++){
                matrizPotenciada [i,j] = Math.Pow(matrizPotencia[i,j], segundoNumero);
            }
        }
        
        System.Console.WriteLine("Resultado de cada elemento de la matriz a la potencia {0}", segundoNumero);
        imprimirMatrizDouble(matrizPotenciada);

        return base.concepto;
    }

    public void matrizTranspuesta(){
        int Filas = 0;
        int Columnas = 0;
        int numero = 0;
        string texto;
        System.Console.WriteLine("Ingresar el tamaño de la matriz: ");  
        texto = Console.ReadLine();
        numero = int.Parse(texto);
        int[,] MatrizOrigin = new int[100,100];
        int[,] MatrizTrans = new int[numero+1,numero+1];
        Random random = new Random();
        System.Console.WriteLine("Matriz original");
        for(Filas=1; Filas<=numero; Filas++)
        {
            for(Columnas=1;Columnas<=numero;Columnas++)
            {
                MatrizOrigin[Filas, Columnas]=random.Next(0,100);
                // Console.SetCursorPosition(Columnas*4, Filas+1);
                Console.Write(MatrizOrigin[Filas,Columnas]+" ");
            }
            Console.WriteLine();
        }
        //Proceso de transpuesta
        for(Filas=1;Filas<=numero;Filas++)
        {
            for(Columnas=1;Columnas<=numero;Columnas++)
            {
                MatrizTrans[Filas,Columnas]=MatrizOrigin[Columnas,Filas];
            }
        } 
        //Impresión de matriz transpuesta
        System.Console.WriteLine("Matriz Transpuesta: ");
        for(Filas=1;Filas<=numero;Filas++)
        {
            for(Columnas=1;Columnas<=numero;Columnas++)
            {
                // Console.SetCursorPosition(Columnas*4, Filas+10);
                Console.Write(MatrizTrans[Filas, Columnas]+" ");
            }
            Console.WriteLine();
        }
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
        for(int i=0; i<matriz.GetLength(0);i++)
        {
            for(int j=0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
    public void imprimirMatrizFloat(float[,] matriz)
    {
        for(int i=0; i<matriz.GetLength(0);i++)
        {
            for(int j=0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
    public void imprimirMatrizDouble(double[,] matriz)
    {
        for(int i=0; i<matriz.GetLength(0);i++)
        {
            for(int j=0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i,j]+" ");
            }
            Console.WriteLine();
        }
    }

}