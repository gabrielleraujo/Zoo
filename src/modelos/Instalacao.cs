using System;
using System.Collections.Generic;
using System.Linq;

using enums;
using interfaces;

namespace modelos
{ 
  public abstract class Instalacao
  {
    protected internal int capacidadeMaxima;
    protected internal double temperatura;
    protected internal Localizacao localizacao;
    protected internal IAnimal [] animaisInstalados;
    protected internal int animaisAlocados = 0;
    protected internal List<ElementoInstalacao> listaElementoIntalacao = new List<ElementoInstalacao>();

    public bool instalarAnimal(IAnimal animal)
    {
      Console.WriteLine($"\n----- EM {tipoDeInstalacao.ToUpper()}");
            
      if(this.temCapacidade() && this.permiteInstalacaoDoAnimal(animal))
      {
        for(int i = 0; i < this.animaisInstalados.Length; i++)
        {          
          if (this.animaisInstalados[i] == null)
          {
            this.animaisInstalados[i] = animal;
            this.animaisAlocados += 1;
            Console.WriteLine("Animal instalado com sucesso!");
            return true;
          }
        }
      }
      else if(!this.temCapacidade() && !this.permiteInstalacaoDoAnimal(animal))
      {
        Console.WriteLine($"Não é possível instalar {tipoDoAnimalParaPermicao(animal)} em uma {tipoDeInstalacao}, além dessa instalação estar lotada. :c");
        Console.WriteLine($"CAPACIDADE RESTANTE É: {nivelDeOcupacao(animal)}.\n");
        return false;     
      }
      else if(!this.temCapacidade())
      {
        Console.WriteLine($"Não possível fazer a instalação! {tipoDeInstalacao} está com sua capacidade lotada. :c");
        Console.WriteLine($"CAPACIDADE RESTANTE É: {nivelDeOcupacao(animal)}.\n");
        return false;
      }
      Console.WriteLine($"Não é possível instalar {tipoDoAnimalParaPermicao(animal)} em uma {tipoDeInstalacao}");
      Console.WriteLine($"CAPACIDADE RESTANTE É: {nivelDeOcupacao(animal)}.\n");
      return false;
    }

    // Abstract methods:
    public abstract bool temCapacidade();
    public abstract bool permiteInstalacaoDoAnimal(IAnimal animal);


    // Using in instalarAnimal:
    private string tipoDoAnimalParaPermicao(IAnimal animal) => animal.GetType().ToString().Split('.')[1];
    private string tipoDeInstalacao => base.GetType().ToString().Split('.')[1].Insert(10, " ");

    private int nivelDeOcupacao(IAnimal animal)
    {
      return this.animaisInstalados
      .Where(animaisInstalados => animaisInstalados == null)
      .Count();
    } 
  }
}