using System;
class Matrices:Calcular{

    public Matrices(int conceptoSeleccionado, string metodoACalcular):base(conceptoSeleccionado, metodoACalcular){ }

    public override float suma()
    {
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
}