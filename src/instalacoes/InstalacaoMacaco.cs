using modelos;
using animais;
using enums;
using interfaces;

namespace instalacoes 
{ 
  public class InstalacaoMacaco : Instalacao
  {
    private const double TEMPERATURA = 25.0;
    private const int CAPACIDADE_MAXIMA = 10;
    private const double ALTURA = 40.0;
    private const double LARGURA = 35.7;
    private const double COMPRIMENTO = 90.0;
    
    public InstalacaoMacaco(Localizacao localizacao)
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
      return animal.GetType() == typeof(Macaco);
    }
  }
}
