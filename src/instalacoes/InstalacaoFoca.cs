using modelos;
using animais;
using enums;
using interfaces;

namespace instalacoes 
{ 
  public class InstalacaoFoca : Instalacao
  {
    private const double TEMPERATURA = 15.0;
    private const int CAPACIDADE_MAXIMA = 5;
    private const double LITROS = 100.0;
    
    public InstalacaoFoca(Localizacao localizacao)
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
      return animal.GetType() == typeof(Foca);
    }
  }
}
