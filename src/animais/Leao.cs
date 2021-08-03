using System;
using System.Collections.Generic;

using enums;
using interfaces;

namespace animais 
{
  public class Leao : ITerrestre
  {
    private Porte porte;
    private Sexo sexo;
    private HashSet<Alimento> come;
    public Leao(Sexo sexo) 
    {
      this.porte = Porte.MEDIO;
      this.sexo = sexo;
      this.come = new HashSet<Alimento>();
      come.Add(Alimento.CARNES);
    }

    // Implementing ITerrestre metodos:
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





