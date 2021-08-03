using System;
using System.Collections.Generic;

using enums;
using interfaces;

namespace animais
{ 
  public class Baleia : IAquatico
  {
    private Porte porte;
    private Sexo sexo;
    private HashSet<Alimento> come;
    public Baleia(Sexo sexo) 
    {
      this.porte = Porte.GRANDE;
      this.sexo = sexo;
      this.come = new HashSet<Alimento>();
      come.Add(Alimento.PEIXES);
    }

    // Implementing IAquatico metodos:
    public void nadar()
    {
      Console.WriteLine("estou nadando!");
    }

    // Implementing IAnimal metodos:
    public bool alimentar(Alimento alimento)
    {
      return come.Contains(alimento);
    }
    public void locomover()
    {
      this.nadar();
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





