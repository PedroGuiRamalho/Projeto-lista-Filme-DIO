using System;
using System.Collections.Generic;
using Filmes.Classes.Interfaces;

namespace Filmes.Classes.Interfaces

{
    public class filme : IRepositorio<Filme>
    {
        private List<Filme> listaFilme =new List<Filme>();
        void IRepositorio<Filme>.Atualiza(int id, Filme objeto)
        {
           listaFilme[id]= objeto;
        }

        void IRepositorio<Filme>.Excluir(int id)
        {
            listaFilme[id].Excluir();
        }

        void IRepositorio<Filme>.Insere(Filme objeto)
        {
            listaFilme.Add(objeto);
        }

        List<Filme> IRepositorio<Filme>.Lista()
        {
            return listaFilme;
        }

        int IRepositorio<Filme>.ProximoId()
        {
            return listaFilme.Count;
        }
        Filme IRepositorio<Filme>.RetornaPorid(int id)
        {
            return listaFilme[id];
        }

        internal object Lista()
        {
            throw new NotImplementedException();
        }
    }
}

        
