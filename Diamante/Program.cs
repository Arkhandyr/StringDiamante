using System;

namespace Diamante
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma letra para gerar o diamante: ");
            char letra = (char)Console.Read();
            Console.WriteLine();

            Diamante d1 = new Diamante(letra);

            Console.WriteLine(d1.MontarDiamante());
            Console.ReadKey();
        }
    }
}
