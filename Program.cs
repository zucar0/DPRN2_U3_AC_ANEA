using System;

namespace DPRN2_U3_AC_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string suma = "1.- Suma ";
            string resta = "2.- Resta ";
            string multiplicacion = "3.- Multiplicación ";
            string division = "4.- División ";
            string alCuadrado = "5.- Al Cuadrado ";
            string potencia="6.- Potencia ";
            string transpuesta="7.- Transpuesta";
            string elegirMetodo ="Por favor elige el método que deseas calcular:\n";

            System.Console.WriteLine("Bienvenido. Por favor ingresa el concepto a calcular.");  
            System.Console.WriteLine("1.- Números Reales\n2.- Fracciones\n3.- Matrices");
            var opcion = Console.ReadLine();
            int elegirConcepto = int.Parse(opcion);
            switch(elegirConcepto)
            {
                //CONCETO NUMEROS REALES
                case 1 when (elegirConcepto==1):
                //Se abre un nuevo menú para elegir el método
                System.Console.WriteLine(elegirMetodo);
                System.Console.WriteLine(suma+resta+multiplicacion+division+alCuadrado+potencia);
                var opcionMetodo = Console.ReadLine();
                int metodoElegido = int.Parse(opcionMetodo);
                if(metodoElegido==1)
                {
                    try
                    {
                        NumerosReales numerosreales = new NumerosReales(1,"Suma");
                        numerosreales.suma();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                else if (metodoElegido==2)
                {
                    try
                    {
                        NumerosReales numerosreales = new NumerosReales(2,"Resta");
                        numerosreales.resta();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                else if (metodoElegido==3)
                {
                    try
                    {
                        NumerosReales numerosreales = new NumerosReales(3,"Multiplicación");
                        numerosreales.multiplicacion();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                else if (metodoElegido==4)
                {
                    try
                    {
                        NumerosReales numerosreales = new NumerosReales(4,"División");
                        numerosreales.division();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                else if (metodoElegido==5)
                {
                    try
                    {
                        NumerosReales numerosreales = new NumerosReales(5,"Al Cuadrado");
                        numerosreales.alCuadrado();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                else if(metodoElegido==6)
                {
                    try
                    {
                        NumerosReales numerosreales = new NumerosReales(6,"Potencia");
                        numerosreales.potencia();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                break;
                //CONCETO FRACCIONES
                case 2 when (elegirConcepto==2):
                //Se abre un nuevo menú para elegir el método
                System.Console.WriteLine(elegirMetodo);
                System.Console.WriteLine(suma+resta+multiplicacion+division+alCuadrado+potencia);
                var opcionMetodo2 = Console.ReadLine();
                int metodoElegido2 = int.Parse(opcionMetodo2);
                if(metodoElegido2==1)
                {
                    try
                    {
                        Fracciones fracciones = new Fracciones(1,"Suma");
                        fracciones.suma();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                else if (metodoElegido2==2)
                {
                    try
                    {
                        Fracciones fracciones = new Fracciones(2,"Resta");
                        fracciones.resta();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                else if (metodoElegido2==3)
                {
                    try
                    {
                        Fracciones fracciones = new Fracciones(3,"Multiplicación");
                        fracciones.multiplicacion();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                else if (metodoElegido2==4)
                {
                    try
                    {
                        Fracciones fracciones = new Fracciones(4,"División");
                        fracciones.division();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                else if (metodoElegido2==5)
                {
                    try
                    {
                        Fracciones fracciones = new Fracciones(5,"Al Cuadrado");
                        fracciones.alCuadrado();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                else if(metodoElegido2==6)
                {
                    try
                    {
                        Fracciones fracciones = new Fracciones(6,"Potencia");
                        fracciones.potencia();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                break;
                //CONCETO MATRICES
                case 3 when (elegirConcepto==3):
                //Se abre un nuevo menú para elegir el método
                System.Console.WriteLine(elegirMetodo);
                System.Console.WriteLine(suma+resta+multiplicacion+division+alCuadrado+potencia+transpuesta);
                var opcionMetodo3 = Console.ReadLine();
                int metodoElegido3 = int.Parse(opcionMetodo3);
                if(metodoElegido3==1)
                {
                    try
                    {
                        Matrices matrices = new Matrices(1,"Suma");
                        matrices.suma();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                else if (metodoElegido3==2)
                {
                    try
                    {
                        Matrices matrices = new Matrices(2,"Resta");
                        matrices.resta();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                else if (metodoElegido3==3)
                {
                    try
                    {
                        Matrices matrices = new Matrices(3,"Multiplicación");
                        matrices.multiplicacion();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                else if (metodoElegido3==4)
                {
                    try
                    {
                        Matrices matrices = new Matrices(4,"División");
                        matrices.division();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                else if (metodoElegido3==5)
                {
                    try
                    {
                        Matrices matrices = new Matrices(5,"Al Cuadrado");
                        matrices.alCuadrado();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                else if(metodoElegido3==6)
                {
                    try
                    {
                        Matrices matrices = new Matrices(6,"Potencia");
                        matrices.potencia();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                else if(metodoElegido3==7)
                {
                    try
                    {
                        Matrices matrices = new Matrices(7, "Matriz transpuesta");
                        matrices.matrizTranspuesta();
                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                //Segunda opción del menú.
                System.Console.WriteLine("***Generación de matriz cuadrada***");
                System.Console.WriteLine("Elige una opción para crearla:\n1.- Manual\n2.Automática");
                var opcionGeneracion = Console.ReadLine();
                int eleccionGeneracion = int.Parse(opcionGeneracion);
                //a.
                if(eleccionGeneracion==1)
                {
                    Matrices matrizCuadrada = new Matrices(8,"Matriz cuadrada");
                    matrizCuadrada.matrizCuadrada();
                    System.Console.WriteLine("Se imprimirá la matriz cuadrada generada por el usuario: ");
                    System.Console.WriteLine(matrizCuadrada);
                }
                //b.
                else if(eleccionGeneracion==2)
                {
                    Matrices matrizcuadradaautomatica = new Matrices(9, "Matriz cuadrada automática");
                    matrizcuadradaautomatica.matrizCuadradaAutomatica();
                    System.Console.WriteLine("Se imprimirá la matriz cuadrada generada automáticamente: ");
                    System.Console.WriteLine(matrizcuadradaautomatica);
                }
                break;
            }
        }
    }
}
