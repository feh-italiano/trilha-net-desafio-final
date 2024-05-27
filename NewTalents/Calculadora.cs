using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        public List<string> historicoCalculadora;

        public Calculadora()
        {
            historicoCalculadora = new List<string>();
        }

        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;
            historicoCalculadora.Add(val1 + " + " + val2 + " = " + res);
            return res;
        }

        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            historicoCalculadora.Add(val1 + " - " + val2 + " = " + res);
            return res;
        }

        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;
            historicoCalculadora.Add(val1 + " / " + val2 + " = " + res);
            return res;
        }

        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            historicoCalculadora.Add(val1 + " * " + val2 + " = " + res);
            return res;
        }

        public List<string> Historico()
        {
            if(historicoCalculadora.Count >3)
                historicoCalculadora.RemoveRange(0, historicoCalculadora.Count - 3);
            return historicoCalculadora;
        }
    }
}