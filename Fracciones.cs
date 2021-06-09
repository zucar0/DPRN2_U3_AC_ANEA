using System;
class Fracciones:Calcular{

    public Fracciones(int conceptoSeleccionado, string metodoACalcular):base(conceptoSeleccionado, metodoACalcular){ }

    public override float suma()
    {
        double dividendo1, dividendo2, divisor1, divisor2, resultado;
        Console.Write("Ingresa el valor del primer dividendo: ");
        dividendo1 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el valor del primer divisor: ");
        divisor1 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el valor del segundo dividendo: ");
        dividendo2 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el valor del segundo divisor: ");
        divisor2 = double.Parse(Console.ReadLine());
        resultado=(divisor1*dividendo2+divisor2*dividendo1)/dividendo2/dividendo1;
        Console.WriteLine("El resultado es: " + resultado);
        return base.concepto;
    }
    public override float resta()
    {
        double dividendo1, dividendo2, divisor1, divisor2, resultado;
        Console.Write("Ingresa el valor del primer dividendo: ");
        dividendo1 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el valor del primer divisor: ");
        divisor1 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el valor del segundo dividendo: ");
        dividendo2 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el valor del segundo divisor: ");
        divisor2 = double.Parse(Console.ReadLine());
        resultado=(divisor1*dividendo2-divisor2*dividendo1)/dividendo2/dividendo1;
        Console.WriteLine("El resultado de restar: {0}/{1}-{2}/{3} es {4}", dividendo1,divisor1, dividendo2,divisor2, resultado);

        return base.concepto;
    }
    public override float multiplicacion()
    {   
        double numerador1, denominador1, numerador2, denominador2, resultado;
        Console.Write("Ingresa el valor del primer numerador: ");
        numerador1 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el valor del primer denominador: ");
        denominador1 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el valor del segundo numerador: ");
        numerador2 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el valor del segundo denominador: ");
        denominador2 = double.Parse(Console.ReadLine());
        double resultadoNumerador = 0;
        double resultadoDenominador=0;
        //Calculo del numerador del resultado
        resultadoNumerador= numerador1*numerador2;
        //Cálculo del denominador del resultado
        resultadoDenominador=denominador1*denominador2;
        resultado=numerador1/denominador1*numerador2/denominador2;
        double comprobacionDeResultado=resultadoNumerador/resultadoDenominador;
        System.Console.WriteLine("El resultado es {0}", resultado);
        System.Console.WriteLine("La comprobación es {0}",comprobacionDeResultado);
        return base.concepto;
    }
    public override float division()
    {
        double dividendo1, dividendo2, divisor1, divisor2, resultado;
        Console.Write("Ingresa el valor del primer dividendo: ");
        dividendo1 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el valor del primer divisor: ");
        divisor1 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el valor del segundo dividendo: ");
        dividendo2 = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el valor del segundo divisor: ");
        divisor2 = double.Parse(Console.ReadLine());
        double resultadoNumerador = 0;
        double resultadoDenominador=0;
        resultadoNumerador=dividendo1*divisor2;
        resultadoDenominador=dividendo2*divisor1;
        resultado=(dividendo1/divisor1)/(dividendo2/divisor2);
        double comprobacionDeResultado=resultadoNumerador/resultadoDenominador;
        System.Console.WriteLine("El resultado es {0}", resultado);
        System.Console.WriteLine("La comprobación es {0}",comprobacionDeResultado);
        return base.concepto;
    }
    public override double alCuadrado()
    {
        System.Console.WriteLine("Por favor ingresa la fracción a elevar al cuadrado. \nDivideno: ");
        double dividendo = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Divisor: ");
        double divisor = double.Parse(Console.ReadLine());
        double resultadoFraccion = dividendo/divisor;
        System.Console.WriteLine("El número ingresado fue {0}/{1}", dividendo, divisor);
        double total = Math.Pow(resultadoFraccion, 2);
        System.Console.WriteLine("El resultado de elevar {0}/{1} al cudrado es {2}", dividendo, divisor, total);
        return base.concepto;
    }
    public override double potencia()
    {
        System.Console.WriteLine("Por favor ingresa la fracción a potenciar. \nDivideno: ");
        double dividendo = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Divisor: ");
        double divisor = double.Parse(Console.ReadLine());
        double resultadoFraccion = dividendo/divisor;
        System.Console.WriteLine("Ahora ingresa la potencia a la que quieres elevar la fracción: ");
        double potencia = double.Parse(Console.ReadLine());
        System.Console.WriteLine("El número ingresado fue {0}/{1}", dividendo, divisor);
        double total = Math.Pow(resultadoFraccion, potencia);
        System.Console.WriteLine("El resultado de elevar {0}/{1} a la potencia {2} es {3}", dividendo, divisor, potencia,total);
        return base.concepto;
    }
}