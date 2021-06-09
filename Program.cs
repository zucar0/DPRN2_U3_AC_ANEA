using System;

namespace DPRN2_U3_AC_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string suma = "1.- Suma";
            string resta = "2.- Resta";
            string multiplicacion = "3.- Multiplicación";
            string division = "4.- División";
            string alCuadrado = "5.- Al Cuadrado";
            string potencia="6.- Potencia";
            string elegirMetodo ="Por favor elige el método que deseas calcular:\n";

            System.Console.WriteLine("Bienvenido. Por favor ingresa el concepto a calcular.");  
            System.Console.WriteLine("1.- Números Reales\n2.- Fracciones\n3.- Matrices");
            var opcion = Console.ReadLine();
            int elegirConcepto = int.Parse(opcion);
            switch(elegirConcepto)
            {
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

                    }
                    catch(Exception ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                }
                break;
                case 3 when (elegirConcepto==3):
                //Se abre un nuevo menú para elegir el método
                System.Console.WriteLine(elegirMetodo);
                System.Console.WriteLine(suma+resta+multiplicacion+division+alCuadrado+potencia);
                var opcionMetodo3 = Console.ReadLine();
                int metodoElegido3 = int.Parse(opcionMetodo3);
                if(metodoElegido3==1)
                {
                    try
                    {

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
                break;
            }
        }
    }
}
