using System;
using System.Collections.Generic;
using System.Text;

namespace MediaFinal
{
    public class Aluno
    {
        public int Nota1;
        public int Nota2;
        public int Nota3;

        public int CalcularMedia()
        {
            int media = ( (Nota1 * 30) +  (Nota2 * 35) + (Nota3 * 35) )/ 100;
            return media;
        }





    }
}
