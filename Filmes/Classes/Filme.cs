using System;


namespace Filmes.Classes
{
    internal class Filme :EntidadeBase
    {
        private Genero genero { get; set;}
        private string Titulo { get; set;}  
        private string Descricao { get; set;}
        private int? Ano { get; set;}
        public bool Excluido { get; set;}
        
        public Filme(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;  
            retorno += "Descr~içõ: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
           


            
        }
        public string retonaTitulo()
        { 
            return this.Titulo; 
        }
        public int retornaId()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluido = true;

        }
    }
}
