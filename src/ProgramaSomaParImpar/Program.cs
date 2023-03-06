int numero, somaPares, somaImpares;
somaPares = 0;
somaImpares = 0;


int NumeroDigitado()
{

    Console.WriteLine("Digite um número inteiro");
    return int.Parse(Console.ReadLine());
}

do
{
    
    numero = NumeroDigitado();

    if((numero<1000) && (numero > 0))
    {
        if (numero % 2 == 0)
        {
            somaPares += numero;
        }
        else
        {
            somaImpares += numero;
        }
    }
} while (numero < 1000);

Console.WriteLine($"A soma dos números pares digitados é: {somaPares}");
Console.WriteLine($"A soma dos números ímpares digitados é: {somaImpares}");
