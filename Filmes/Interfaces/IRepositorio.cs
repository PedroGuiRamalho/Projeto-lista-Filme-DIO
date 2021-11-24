using System;
using System.Collections.Generic;


namespace Filmes.Classes.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorid(int id);
        void Insere(T entidade);
        void Excluir(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}
