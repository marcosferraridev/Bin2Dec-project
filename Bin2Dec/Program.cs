using System;
using System.Globalization;

namespace Bin2Dec;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número binário à ser convertido (max 8 caracteres): ");
        string binario = Console.ReadLine();

        if (binario == null) {

            Console.WriteLine("Digite um número binário válido!!");
            return;

        } else if (binario.Length > 8) {

            Console.WriteLine("Digite no máximo 8 digitos!!");
            return;
        }

        
        //percorre toda a string de binario
        foreach (char c in binario) {

            //não deixa outra entrada que não seja 0 ou 1
            if (c != '0' && c != '1') {

                Console.WriteLine("número invalido, apenas 0 ou 1!");
                return;
            }
        }

        int numeroDecimal = 0;
        int potencia = 0;

        //transforma o char em int, começando pelo ultimo indice da string
        for (int i = binario.Length - 1; i >= 0; i--) {

            //String - '0' converte a string em int, ex ( '9' - '0' == 9 ) 
            int digito = binario[i] - '0';

            //calculo que converte o binario para decimal, multiplicando seu digito pelo valor da potencia de 2 correspondente a sua posição
            numeroDecimal += digito * (int)Math.Pow(2, potencia);

            //aumenta a potencia para o próximo digito
            potencia++;
        }

        Console.WriteLine($"\nConversão de {binario} para Decimal é: {numeroDecimal} ");

        
    }
}
