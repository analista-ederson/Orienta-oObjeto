using OrientacaoObjeto;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaPolimorfismoExcessoes
{
    abstract class PosGraduacao : Curso 
    {
        public int Creditos { get; set; }
    }
}
