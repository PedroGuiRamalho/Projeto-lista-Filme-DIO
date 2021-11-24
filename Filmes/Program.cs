using System;
using System.Collections.Generic;
using Filmes.Classes.Interfaces;

using System;
using Filmes.Classes;

namespace Filmes.

{
	class Program
	{
		static filme repositorio = new filme();
		static void Main(string[] args)
		{
			string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "x")
			{
				switch (opcaoUsuario)
				{

					case "1":
						listarFilme();
						break;
					case "2":
						InserirFilme();
						break;
					case "3":
						AtualizarFilmes();
						break;
					case "4":
						ExcluirFilme();
						break;
					case "5":
						VisualizaSerie();
						break;
					case "c":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}
				Console.WriteLine("Obrigado por utilizar o serviço.");
				Console.ReadLine();
			}
			private static void ExcluirFilme()
			{
				Console.Write("Digite o id do Filme: ");
				int indiceFilme = int.Parse(Console.ReadLine());

				repositorio.Exclui(indiceFilme);
			}
			private static void VisualizarFilme()
			{
				Console.Write("Digite o id da série: ");
				int indiceFilme = int.Parse(Console.ReadLine());

				var filme = repositorio.RetornaPorId(indiceFilme);

				Console.WriteLine(filme);
				private static void AtualizarFilmes()
				{

					Console.Write("Digite o id do Filme: ");
					int indiceFilme = int.Parse(Console.ReadLine());


					foreach (int i in Enum.GetValues(typeof(Genero)))
					{
						Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
					}
					Console.Write("Digite o gênero entre as opções acima: ");
					int entradaGenero = int.Parse(Console.ReadLine());

					Console.Write("Digite o Título do Filme: ");
					string entradaTitulo = Console.ReadLine();

					Console.Write("Digite o Ano de Início do Filme: ");
					int entradaAno = int.Parse(Console.ReadLine());

					Console.Write("Digite a Descrição do Filme: ");
					string entradaDescricao = Console.ReadLine();

					Filme atualizaSerie = new Filme(id: indiceFilme,
													genero: (Genero)entradaGenero,
													titulo: entradaTitulo,
													ano: entradaAno,
													descricao: entradaDescricao);

					repositorio.Atualiza(indiceFilme, atualizaFilme);
				}
				private static void listarFilme()
				{
					Console.WriteLine("Listar Filmes");

					var lista = repositorio.Lista();

					if (lista.Count == 0)
					{
						Console.WriteLine("Nenhuma série cadastrada.");
						return;
					}

					foreach (var serie in lista)
					{
						var excluido = filme.retornaExcluido();

						Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "*Excluído*" : ""));
					}
				}
				private static void InserirFilme()
				{
					Console.WriteLine("Inserir novo Filme:");


					foreach (int i in Enum.GetValues(typeof(Genero)))
					{
						Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
					}
					Console.Write("Digite o gênero entre as opções acima: ");
					int entradaGenero = int.Parse(Console.ReadLine());

					Console.Write("Digite o Título do Filme : ");
					string entradaTitulo = Console.ReadLine();

					Console.Write("Digite o Ano de Início do Filme : ");
					int entradaAno = int.Parse(Console.ReadLine());

					Console.Write("Digite a Descrição do Filme: ");
					string entradaDescricao = Console.ReadLine();

					filme novaSerie = new filme(id: repositorio.ProximoId(),
												genero: (Genero)entradaGenero,
												titulo: entradaTitulo,
												ano: entradaAno,
												descricao: entradaDescricao);

					repositorio.Insere(novoFilme);
				}
				Console.WriteLine();
			}
		}