using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpTDS.Util
{
    public class AprendendoStrings
    {
        public static string texto = "Sejam Louvados Jesus e Maria!! Para sempre sejam Louvados";
        public static void Main(string[] args)
        {

            Console.WriteLine("Executando Aprendendo Strings!!");

            //To UpperCase
            Console.WriteLine(texto.ToUpper());

            //To Lower
            Console.WriteLine(texto.ToLower());

            //Replace
            Console.WriteLine(texto.Replace("Sejam", "Muito Sejam"));

            Console.WriteLine(texto.Trim());
            Console.WriteLine(texto.TrimStart());
            Console.WriteLine(texto.TrimEnd());
            Console.WriteLine(texto.Substring(texto.Length / 2));
            Console.WriteLine("Texto contém a palavra plano? {0}", texto.Contains("plano"));
            Console.WriteLine("Posição palavra um {0}", texto.IndexOf("um"));
            Console.WriteLine("Quantidade de caracteres: {0}", texto.Length);
            foreach (string txt in texto.Split("ataque"))
            {
                Console.WriteLine(txt);
            }









            Console.ReadKey();
        }
    }
}
