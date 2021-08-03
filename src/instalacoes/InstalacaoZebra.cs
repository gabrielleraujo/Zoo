using modelos;
using animais;
using enums;
using interfaces;

namespace instalacoes 
{ 
  public class InstalacaoZebra : Instalacao
  {
    private const double TEMPERATURA = 24.0;
    private const int CAPACIDADE_MAXIMA = 2;
    private const double ALTURA = 20.0;
    private const double LARGURA = 30.0;
    private const double COMPRIMENTO = 25.0;
    
    public InstalacaoZebra(Localizacao localizacao)
    {
      this.capacidadeMaxima = CAPACIDADE_MAXIMA;
      this.temperatura = TEMPERATURA;

      this.localizacao = localizacao;

      this.animaisInstalados = new IAnimal[CAPACIDADE_MAXIMA];
      
      ElementoInstalacao jaula = new Jaula(ALTURA, LARGURA, COMPRIMENTO);     
      this.listaElementoIntalacao.Add(jaula);

    }

    public override bool temCapacidade() {
      return this.animaisAlocados < CAPACIDADE_MAXIMA;
    }

    public override bool permiteInstalacaoDoAnimal(IAnimal animal) {
      return animal.GetType() == typeof(Zebra);
    }
  }
}
