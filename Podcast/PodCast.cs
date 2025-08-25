using System;
using System.Collections.Generic;

class Podcast
{
    private List<Episidio> episodios = new List<Episidio>();
    public Podcast(string host, string nome)
    {
        Nome = nome;
        Host = host;
    }

    public string Host { get; set; }
    public string Nome { get; set; }
    public int TotalEpisodios => episodios.Count;

    

    public void AdicionarEpisodio(Episidio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast >| {Nome} |< Apresentado por [{Host}]\n");
        foreach (Episidio ep in episodios)
        {
            Console.WriteLine(ep.Resumo);
        }

        Console.WriteLine($"\n\n Total de Episodios: {TotalEpisodios}.\n\n");
    }
}