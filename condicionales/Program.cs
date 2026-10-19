using System;   

Console.WriteLine(CheckNumber(-2));

static string CheckNumber(int numero)
{
    if (numero > 0)
    {
        return "El numero es positivo";
    }
    else if (numero < 0)
    {
        return "El numero es negativo";
    }
    else
    {
        return "El numero es cero";
    }
}

