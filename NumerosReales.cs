using System;
class NumerosReales:Calcular{

    public NumerosReales(int conceptoSeleccionado, string metodoACalcular):base(conceptoSeleccionado, metodoACalcular){ }

    public override float suma()
    {
        System.Console.WriteLine("Por favor ingresa el primer número a sumar: ");
        var ingreso = Console.ReadLine();
        float primerNumero = float.Parse(ingreso);
        System.Console.WriteLine("Por favor ingresa el segundo número a sumar: ");
        var ingreso2 = Console.ReadLine();
        float segundoNumero = float.Parse(ingreso2);
        System.Console.WriteLine("El primer número ingresado fue {0}", primerNumero);
        System.Console.WriteLine("El segundo número ingresado fue {0}", segundoNumero);
        float total = primerNumero + segundoNumero;
        System.Console.WriteLine("El resultado de la suma es {0}", total);
        return base.concepto;
    }
    public override float resta()
    {
        System.Console.WriteLine("Por favor ingresa el primer número de la resta: ");
        var ingreso = Console.ReadLine();
        float primerNumero = float.Parse(ingreso);
        System.Console.WriteLine("Por favor ingresa el segundo número de la resta: ");
        var ingreso2 = Console.ReadLine();
        float segundoNumero = float.Parse(ingreso2);
        System.Console.WriteLine("El primer número ingresado fue {0}", primerNumero);
        System.Console.WriteLine("El segundo número ingresado fue {0}", segundoNumero);
        float total = primerNumero - segundoNumero;
        System.Console.WriteLine("El resultado de la resta es {0}", total);
        return base.concepto;
    }
    public override float multiplicacion()
    {
        System.Console.WriteLine("Por favor ingresa el primer número de la multiplicación: ");
        var ingreso = Console.ReadLine();
        float primerNumero = float.Parse(ingreso);
        System.Console.WriteLine("Por favor ingresa el segundo número de la multiplicación: ");
        var ingreso2 = Console.ReadLine();
        float segundoNumero = float.Parse(ingreso2);
        System.Console.WriteLine("El primer número ingresado fue {0}", primerNumero);
        System.Console.WriteLine("El segundo número ingresado fue {0}", segundoNumero);
        float total = primerNumero * segundoNumero;
        System.Console.WriteLine("El resultado de la multiplicación es {0}", total);
        return base.concepto;
    }
    public override float division()
    {
        System.Console.WriteLine("Por favor ingresa el dividendo: ");
        var ingreso = Console.ReadLine();
        float primerNumero = float.Parse(ingreso);
        System.Console.WriteLine("Por favor ingresa el divisor: ");
        var ingreso2 = Console.ReadLine();
        float segundoNumero = float.Parse(ingreso2);
        System.Console.WriteLine("El dividendo ingresado fue {0}", primerNumero);
        System.Console.WriteLine("El divisor ingresado fue {0}", segundoNumero);
        float total = primerNumero / segundoNumero;
        System.Console.WriteLine("El resultado de la división es {0}", total);
        return base.concepto;
    }
    public override double alCuadrado()
    {
        System.Console.WriteLine("Por favor ingresa el número a elevar al cuadrado: ");
        var ingreso = Console.ReadLine();
        double primerNumero = double.Parse(ingreso);
        System.Console.WriteLine("El número ingresado fue {0}", primerNumero);
        double total = Math.Pow(primerNumero, 2);
        System.Console.WriteLine("El resultado de elevar" + primerNumero + " al cudrado es {0}", total);
        return base.concepto;
    }
    public override double potencia()
    {
        System.Console.WriteLine("Por favor ingresa el número que deseas potenciar: ");
        var ingreso = Console.ReadLine();
        double primerNumero = double.Parse(ingreso);
        System.Console.WriteLine("Por favor ingresa el número de la potencia: ");
        var ingreso2 = Console.ReadLine();
        float segundoNumero = float.Parse(ingreso2);
        System.Console.WriteLine("El número ingresado a potenciar fue {0}", primerNumero);
        System.Console.WriteLine("El número ingresado de la potencia fue {0}", segundoNumero);
        double total = Math.Pow(primerNumero, segundoNumero);
        System.Console.WriteLine("El resultado de elevar" + primerNumero + " a la potencia "+segundoNumero+" es " + total+".");
        return base.concepto;
    }
}