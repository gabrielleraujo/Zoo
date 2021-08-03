using enums;

namespace interfaces
{ 
  public interface IAnimal
  {
    public bool alimentar(Alimento alimento);
    public void locomover();
    
    /*
    public Sexo getSexo();
    public void setSexo(Sexo sexo);
    public Porte getPorte();
    public void setPorte(Porte porte);
    */
    public Sexo Sexo {get; set;}
    public Porte Porte {get; set;}

  }
}