using System;
using System.Threading.Tasks;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Pessoa pessoa2 = new Objetos.Pessoa("05555555", "Domingos");

            Console.WriteLine(pessoa2.NomeCPF());

             Console.WriteLine("\n\nPressione qualquer tecla para sair");
             Console.ReadKey(true);

        }//fim do metodo main
    }//fim da classe program
}//fim do namespace Objetos
