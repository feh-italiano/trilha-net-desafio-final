using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Menu
    {
        public string MenuInicial()
        {
            return "--------CALCULADORA--------\n1. Somar\n2. Subtrair\n3. Multiplicar\n4. Dividir\n5. Histórico\n6. Sair\nSua opção => ";
        }

        public string OpcaoInvalida()
        {
            return "Opção inálida!\nSua opção => ";
        }
    }
}