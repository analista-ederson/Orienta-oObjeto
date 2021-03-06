using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaPolimorfismoExcessoes
{
    interface IRepositorio<T>
    {
        T ObterPorId(string id);
        IEnumerable<T> ObterTodos();
        void Gravar(T objeto);
        void Remover(T objeto);

    }
}
