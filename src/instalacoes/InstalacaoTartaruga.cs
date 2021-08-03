using modelos;
using animais;
using enums;
using interfaces;

namespace instalacoes 
{ 
  public class InstalacaoTartaruga : Instalacao
  {
    private const double TEMPERATURA = 20.0;
    private const int CAPACIDADE_MAXIMA = 17;
    private const double LITROS = 200.0;
    
    public InstalacaoTartaruga(Localizacao localizacao)
    {
      this.capacidadeMaxima = CAPACIDADE_MAXIMA;
      this.temperatura = TEMPERATURA;

      this.localizacao = localizacao;

      this.animaisInstalados = new IAnimal[CAPACIDADE_MAXIMA];
      
      ElementoInstalacao tanque = new Tanque(LITROS);     
      this.listaElementoIntalacao.Add(tanque);

    }

    public override bool temCapacidade() {
      return this.animaisAlocados < CAPACIDADE_MAXIMA;
    }

    public override bool permiteInstalacaoDoAnimal(IAnimal animal) {
      return animal.GetType() == typeof(Tartaruga);
    }
  }
}
