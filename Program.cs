using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;


            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            //igualdade de tipo de referencia. (False) Objeto guarda em endereço de mem
            //memoria diferente dos tipos
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);
            

            
            
            Console.ReadLine();

        }
    }
}
