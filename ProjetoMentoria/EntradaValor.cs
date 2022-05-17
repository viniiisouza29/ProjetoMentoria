using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProjetoMentoria
{
    public class EntradaValor : RetornaValor
    {
        public void Entrada()
        {
            while (true)
            {
                var cki = Console.ReadKey(true);

                Console.WriteLine("Insira a entrada de caracteres com valores de 'a','b' e 'c'.");
                Console.WriteLine();
                Console.WriteLine("Caso deseje sair do programa pressione 'EsSQ' logo depois qualquer outra tecla!");

                if (cki.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                
                string caracteres = Console.ReadLine();

                char[] valida = { 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'y', 'z' };

                foreach (char i in valida)
                {
                    if (Char.ToString(i).Contains(caracteres))
                    {
                        Console.Clear();
                        Console.WriteLine("Valor Inválido!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Valor Original da String: " + caracteres);
                        Console.WriteLine("Valor Reduzido da String: " + ReduzString(caracteres));
                        Console.WriteLine("Tamanho da String: " + caracteres.Length);
                    }
                }
            }
        }
    }
}
