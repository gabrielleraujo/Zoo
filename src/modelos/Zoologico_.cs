using System;
using System.Collections.Generic;
using System.Linq;
using enums;

namespace modelos
{
  public class Zoologico_ : FabricaInstalacao
  { 
    private HashSet<Instalacao> instalacoes = new HashSet<Instalacao>();

    public void adicionarInstalacao(Instalacao instalacao)
    {
      if(jaPussuiInstalacaoNaLocalizacao(instalacao.localizacao))
      {
        Console.WriteLine($"Já existe uma instalação nessa localização, {instalacao.localizacao}. /:\n");        
      }
      else
      {
        instalacoes.Add(instalacao);
        Console.WriteLine($"A instalação foi adicionada com sucesso! c:\n");
      }
    }

    private bool jaPussuiInstalacaoNaLocalizacao(Localizacao localizacao)
    {
      return this.instalacoes
      .Where(i => i.localizacao.Equals(localizacao))
			.Count() > 0 ? true : false;
    }
  }
}