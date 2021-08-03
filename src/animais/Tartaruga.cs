using System;
using System.Collections.Generic;

using enums;
using interfaces;

namespace animais
{
  public class Tartaruga : IAnfibio
  { 
    private Porte porte;
    private Sexo sexo;
    private HashSet<Alimento> come;
    public Tartaruga(Sexo sexo) 
    {
      this.porte = Porte.PEQUENO;
      this.sexo = sexo;
      this.come = new HashSet<Alimento>();
      come.Add(Alimento.FRUTAS);
      come.Add(Alimento.VERDURAS);
      come.Add(Alimento.PEIXES);
    }

    // Implementing IAquatico metodos:
    public void nadar()
    {
      Console.WriteLine("estou andando!");
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





