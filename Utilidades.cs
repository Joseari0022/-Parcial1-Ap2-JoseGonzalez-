using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _Parcial1_Ap2_JoseGonzalez_
{
    public class Utilidades
    {
        public static int ToInt(string texto)
        {
            int numero;
            int.TryParse(texto, out numero);
            return numero;
        }
    }
}