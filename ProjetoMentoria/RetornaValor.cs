using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProjetoMentoria
{
    public class RetornaValor
    {
        public string ReduzString(string caracteres)
        {
            char ultima = default;
            char atual;
            string retorno = caracteres;

            for (int letra = 0; letra < caracteres.Length; letra++)
            {
                char replacement;
                atual = caracteres[letra];
                if (atual != ultima && ultima != default)
                {
                    StringBuilder sb = new StringBuilder(caracteres);
                    if (caracteres.Length == 2)
                    {
                        char[] valida = { 'a', 'b', 'c' };

                        foreach (char i in valida)
                        {
                            if (!caracteres.Contains(i)) return Char.ToString(i);
                        }
                    }
                    else
                    {
                        replacement = EncontraReplacement(caracteres, caracteres[letra + 1]);

                        sb[letra] = replacement;
                        sb.Remove(letra - 1, 1);
                    }
                    return ReduzString(sb.ToString());
                }
                ultima = atual;
            }
            return retorno;
        }

        char EncontraReplacement(string texto, char atual)
        {
            char[] obriga = { 'a', 'b', 'c' };

            foreach (char i in obriga)
            {
                if (!texto.Contains(i)) return i;
            }

            return atual;
        }
    }
}


/// ACIMA CÓDIGO DO QUAL O RESULTADO SAI COMO EU ACHO QUE DEVERIA SAIR: 'aabc' -> 'acc' -> 'bc' -> 'a' 

/// CODIGO DO QUAL O RESULTADO DO EXEMPLO A SEGUIR SAI IDENTICO -> 'aabc' -> 'acc' -> 'bc' -> 'b' 


//public string ReduzString(string caracteres)
//{
//    char ultima = default;
//    char atual;
//    string retorno = caracteres;

//    for (int letra = 0; letra < caracteres.Length; letra++)
//    {
//        char replacement;
//        atual = caracteres[letra];
//        if (atual != ultima && ultima != default)
//        {
//            StringBuilder sb = new StringBuilder(caracteres);
//            if (caracteres.Length == 2)
//                sb.Remove(1, 1);
//            else
//            {
//                replacement = EncontraReplacement(caracteres, caracteres[letra + 1]);

//                sb[letra] = replacement;
//                sb.Remove(letra - 1, 1);
//            }
//            return ReduzString(sb.ToString());
//        }
//        ultima = atual;
//    }
//    return retorno;
//}

//char EncontraReplacement(string texto, char atual)
//{

//    char[] obriga = { 'a', 'b', 'c' };

//    foreach (char i in obriga)
//        if (!texto.Contains(i)) return i;

//    return atual;
//}

