using System;
using System.Collections.Generic;

using enums;
using interfaces;

namespace animais
{ 
  public class Foca : IAnfibio
  {
    private Porte porte;
    private Sexo sexo;
    private HashSet<Alimento> come;
    public Foca(Sexo sexo) 
    {
      this.porte = Porte.MEDIO;
      this.sexo = sexo;
      this.come = new HashSet<Alimento>();
      come.Add(Alimento.PEIXES);
    }

    // Implementing IAnfibio metodos:
    public void nadar()
    {
      Console.WriteLine("estou nadando!");
    }
    public void andar()
    {
      Console.WriteLine("estou andando!");
    }

    // Implementing IAnimal metodos:
    public bool alimentar(Alimento alimento)
    {
      return come.Contains(alimento);
    }
    public void locomover()
    {
      this.nadar();
      this.andar();
    }
    
    public Porte Porte
    {
      get { return this.porte; }
      set {this.porte = value; }
    }
    public Sexo Sexo
    {
      get { return this.sexo; }
      set {this.sexo = value; }
    }
    
  }
}





