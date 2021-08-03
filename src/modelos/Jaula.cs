namespace modelos
{
  public class Jaula : ElementoInstalacao
  { 
    private double altura;
    private double largura;
    private double comprimento;

    public Jaula(double altura, double largura, double comprimento)
    {
      this.altura = altura;
      this.largura = largura;
      this.comprimento = comprimento;
    }

    public double area()
    {
      return this.largura * this.comprimento * this.altura;
    }
  }
}