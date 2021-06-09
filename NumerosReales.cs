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
    public override float alCuadrado()
    {
        return base.concepto;
    }
    public override float potencia()
    {
        return base.concepto;
    }
}