using System;
using System.Collections.Generic;
using System.Text;

namespace RolarDado
{
    class Dado
    {
        public int QuantidadeDeLados;
        public int NumeroRolado;
        public int Roladas;
        
        public void RolarDado()
        {
            Random rd = new Random();
            NumeroRolado = rd.Next(1, QuantidadeDeLados + 1); 
        }
    }
}
