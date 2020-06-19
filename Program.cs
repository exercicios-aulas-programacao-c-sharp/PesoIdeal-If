using System;
/*
[console: PesoIdeal] Solicite que o usuário digite sua altura e o seu sexo ('M' para masculino, 'F' para feminino). Calcule e exiba seu peso ideal.
*/
namespace PesoIdeal_If
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Declarar variáveis
            decimal alturaUsuario, pesoIdeal;
            string sexoUsuario;
            bool alturaEhValida;

            //2 - Solicitação de valores para o usuário
            Console.Write("Digite sua altura em m..........: ");

            alturaEhValida = Decimal.TryParse(Console.ReadLine(), out alturaUsuario);

            if (!alturaEhValida)
            {
                Console.WriteLine("O valor digitado não corresponde a um valor numérico.");
                Environment.Exit(1);
            }

            Console.Write("Sexo [M]asculino / [F]eminino...: ");

            sexoUsuario = Console.ReadKey().KeyChar.ToString().ToUpper();           

            //3 - Usar estrutura de decisão, para calcular o peso ideal a partir do sexo
            if (sexoUsuario.Equals("M"))
            {
                //4 - Realizar os cálculos, conforme a situação
                pesoIdeal = alturaUsuario * 72.7m - 58m;
                //5 - Exibir o peso ideal.
                Console.WriteLine($"\n\nSeu peso ideal é {pesoIdeal:N1}kg.");
            }
            else if (sexoUsuario.Equals("F"))
            {
                //4 - Realizar os cálculos, conforme a situação
                pesoIdeal = alturaUsuario * 62.1m - 44.7m;
                //5 - Exibir o peso ideal.
                Console.WriteLine($"\n\nSeu peso ideal é {pesoIdeal:N1}kg.");
            }
            else
            {
                Console.WriteLine($"O valor digitado ({sexoUsuario}) não é um sexo válido");
            }
            
        }
    }
}
