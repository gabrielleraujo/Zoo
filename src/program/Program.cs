using System;

using animais;
using enums;
using interfaces;
using modelos;

namespace program
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------------------------------\n");
            Console.WriteLine("TESTANDO AQUÁTICO COM BALEIRA\n");
            IAnimal baleia1 = new Baleia(Sexo.MASCULINO);
            IAnimal baleia2 = new Baleia(Sexo.FEMININO);
            IAnimal baleia3 = new Baleia(Sexo.FEMININO);
                
            Console.WriteLine($"SEXO baleia1: {baleia1.Sexo}");
            Console.WriteLine($"SEXO baleia2: {baleia1.Sexo}");
            Console.WriteLine("");

            Console.WriteLine($"PORTE baleia1: {baleia1.Porte}");
            Console.WriteLine($"PORTE baleia2: {baleia1.Porte}");
            Console.WriteLine("");
            
            baleia1.Porte = Porte.PEQUENO;
            Console.WriteLine($"PORTE da baleia1 modificado para: {baleia1.Porte}");
            Console.WriteLine("");
            
            Console.WriteLine($"baleia1 COME FRUTAS: {baleia1.alimentar(Alimento.FRUTAS)}");
            Console.WriteLine($"baleia1 COME CARNES: {baleia1.alimentar(Alimento.CARNES)}");
            Console.WriteLine();
            
            Console.WriteLine("BALEIA SE LOCOMOCOMOVENDO:");
            baleia1.locomover();
            baleia2.locomover();
            Console.WriteLine();
            
            
            // CRIANDO INSTALAÇÕES -------------------------------------------------------------------------------------
            Instalacao instalacaoBaleia1 = FabricaInstalacao.criarInstalacaoBaleia(Localizacao.NORTE);
            Instalacao instalacaoBaleia2 = FabricaInstalacao.criarInstalacaoBaleia(Localizacao.SUL);

            Console.WriteLine("Tentando fazer mais uma instalação em uma localização já ocupada:");
            FabricaInstalacao.criarInstalacaoBaleia(Localizacao.NORTE);
            Console.WriteLine();
            

            // ADICIONANDO INSTALAÇÕES NO ZOO --------------------------------------------------------------------------
            Console.WriteLine("ADICIONANDO INSTALAÇÕES NO ZOO\n");
            Zoologico_ zoo = new Zoologico_();
            zoo.adicionarInstalacao(instalacaoBaleia1);
            zoo.adicionarInstalacao(instalacaoBaleia2);
            Console.WriteLine();        


            // ADICIONANDO ANIMAIS NA INSTALAÇÃO PARA BALEIA -----------------------------------------------------------
            Console.WriteLine("ADICIONANDO ANIMAIS NA INSTALAÇÃO PARA BALEIA\n");
            
            Console.WriteLine("Testando com animal do tipo correto: ");
            instalacaoBaleia1.instalarAnimal(baleia1);
            instalacaoBaleia2.instalarAnimal(baleia2);
            Console.WriteLine("");
            Console.WriteLine($"LOCALIZAÇÃO da instalacaoBaleia1: {instalacaoBaleia1.localizacao}");
            Console.WriteLine($"LOCALIZAÇÃO da instalacaoBaleia2: {instalacaoBaleia2.localizacao}");
            Console.WriteLine("");

            // TESTANDO ANIMAL DO TIPO ERRADO --------------------------------------------------------------------------
            Console.WriteLine("Testando com animal do tipo errado: ");
            IAnimal elefante1 = new Elefante(Sexo.MASCULINO);
            IAnimal elefante2 = new Elefante(Sexo.FEMININO);
            instalacaoBaleia1.instalarAnimal(elefante1);
            Console.WriteLine("");


            // ADICIONANDO + ANIMAIS DO TIPO CERTO NA INSTALAÇÃO PARA BALEIA -------------------------------------------
            Console.WriteLine("ADICIONANDO + 1 ANIMAl DO TIPO CERTO NA INSTALAÇÃO PARA BALEIA\n");
            instalacaoBaleia1.instalarAnimal(baleia2);
            instalacaoBaleia1.instalarAnimal(baleia3);            
            Console.WriteLine("-----------------------------------------------------------------------------------------\n");

            

            //__________________________________________________________________________________________________________

            Console.WriteLine("-----------------------------------------------------------------------------------------\n");
            Console.WriteLine("TESTANDO AQUÁTICO COM BALEIRA\n");
            IAnimal elefante3 = new Elefante(Sexo.FEMININO);
                
            Console.WriteLine($"SEXO elefante1: {elefante1.Sexo}");
            Console.WriteLine($"SEXO elefante2: {elefante2.Sexo}");
            Console.WriteLine("");

            Console.WriteLine($"PORTE elefante1: {elefante1.Porte}");
            Console.WriteLine($"PORTE elefante2: {elefante2.Porte}");
            Console.WriteLine("");
            
            elefante1.Porte = Porte.MEDIO;
            Console.WriteLine($"PORTE da elefante1 modificado para: {elefante1.Porte}");
            Console.WriteLine("");
            
            Console.WriteLine($"elefante1 COME FRUTAS: {elefante1.alimentar(Alimento.FRUTAS)}");
            Console.WriteLine($"elefante1 COME CARNES: {elefante2.alimentar(Alimento.CARNES)}");
            Console.WriteLine();
            
            Console.WriteLine("ELEFANTE SE LOCOMOCOMOVENDO:");
            elefante1.locomover();
            elefante2.locomover();
            Console.WriteLine();
            
            
            // CRIANDO INSTALAÇÕES -------------------------------------------------------------------------------------
            Instalacao instalacaoElefante1 = FabricaInstalacao.criarInstalacaoElefante(Localizacao.NORDESTE);
            Instalacao instalacaoElefante2 = FabricaInstalacao.criarInstalacaoElefante(Localizacao.SULDESTE);

            Console.WriteLine("Tentando fazer mais uma instalação em uma localização já ocupada:");
            FabricaInstalacao.criarInstalacaoElefante(Localizacao.NORDESTE);
            Console.WriteLine();
            

            // ADICIONANDO INSTALAÇÕES NO ZOO --------------------------------------------------------------------------
            Console.WriteLine("ADICIONANDO INSTALAÇÕES NO ZOO\n");
            zoo.adicionarInstalacao(instalacaoElefante1);
            zoo.adicionarInstalacao(instalacaoElefante2);
            Console.WriteLine();        


            // ADICIONANDO ANIMAIS NA INSTALAÇÃO PARA ELEFANTE -----------------------------------------------------------
            Console.WriteLine("ADICIONANDO ANIMAIS NA INSTALAÇÃO PARA ELEFANTE\n");
            
            Console.WriteLine("Testando com animal do tipo correto: ");
            instalacaoElefante1.instalarAnimal(elefante1);
            instalacaoElefante2.instalarAnimal(elefante2);
            Console.WriteLine("");
            Console.WriteLine($"LOCALIZAÇÃO da instalacaoElefante1: {instalacaoElefante1.localizacao}");
            Console.WriteLine($"LOCALIZAÇÃO da instalacaoElefante2: {instalacaoElefante2.localizacao}");
            Console.WriteLine("");

            // TESTANDO ANIMAL DO TIPO ERRADO --------------------------------------------------------------------------
            Console.WriteLine("Testando com animal do tipo errado: ");
            IAnimal foca1 = new Foca(Sexo.FEMININO);
            IAnimal foca2 = new Foca(Sexo.MASCULINO);
            instalacaoElefante1.instalarAnimal(foca1);
            Console.WriteLine("");

            Console.WriteLine("-----------------------------------------------------------------------------------------\n");



            //__________________________________________________________________________________________________________

            Console.WriteLine("-----------------------------------------------------------------------------------------\n");
            Console.WriteLine("TESTANDO ANFÍBIO COM FOCA\n");
            IAnimal foca3 = new Foca(Sexo.FEMININO);
                
            Console.WriteLine($"SEXO foca1: {foca1.Sexo}");
            Console.WriteLine($"SEXO foca2: {foca2.Sexo}");
            Console.WriteLine("");

            Console.WriteLine($"PORTE foca1: {foca1.Porte}");
            Console.WriteLine($"PORTE foca2: {foca2.Porte}");
            Console.WriteLine("");
            
            foca1.Porte = Porte.GRANDE;
            Console.WriteLine($"PORTE da foca1 modificado para: {foca1.Porte}");
            Console.WriteLine("");
            
            Console.WriteLine($"foca1 COME FRUTAS: {foca1.alimentar(Alimento.FRUTAS)}");
            Console.WriteLine($"foca1 COME CARNES: {foca2.alimentar(Alimento.CARNES)}");
            Console.WriteLine();
            
            Console.WriteLine("FOCA SE LOCOMOCOMOVENDO:");
            foca1.locomover();
            foca2.locomover();
            Console.WriteLine();
            
            
            // CRIANDO INSTALAÇÕES -------------------------------------------------------------------------------------
            Instalacao instalacaoFoca1 = FabricaInstalacao.criarInstalacaoFoca(Localizacao.NOROESTE);
            Instalacao instalacaoFoca2 = FabricaInstalacao.criarInstalacaoFoca(Localizacao.SUDOESTE);

            Console.WriteLine("Tentando fazer mais uma instalação em uma localização já ocupada:");
            FabricaInstalacao.criarInstalacaoFoca(Localizacao.NOROESTE);
            Console.WriteLine();
            

            // ADICIONANDO INSTALAÇÕES NO ZOO --------------------------------------------------------------------------
            Console.WriteLine("ADICIONANDO INSTALAÇÕES NO ZOO\n");
            zoo.adicionarInstalacao(instalacaoFoca1);
            zoo.adicionarInstalacao(instalacaoFoca2);
            Console.WriteLine();        


            // ADICIONANDO ANIMAIS NA INSTALAÇÃO PARA FOCA -----------------------------------------------------------
            Console.WriteLine("ADICIONANDO ANIMAIS NA INSTALAÇÃO PARA FOCA\n");
            
            Console.WriteLine("Testando com animal do tipo correto: ");
            instalacaoFoca1.instalarAnimal(foca1);
            instalacaoFoca2.instalarAnimal(foca2);
            Console.WriteLine("");
            Console.WriteLine($"LOCALIZAÇÃO da instalacaoFoca1: {instalacaoFoca1.localizacao}");
            Console.WriteLine($"LOCALIZAÇÃO da instalacaoFoca2: {instalacaoFoca2.localizacao}");
            Console.WriteLine("");

            // TESTANDO ANIMAL DO TIPO ERRADO --------------------------------------------------------------------------
            Console.WriteLine("Testando com animal do tipo errado: ");
            IAnimal zebra1 = new Zebra(Sexo.FEMININO);
            instalacaoFoca1.instalarAnimal(zebra1);
            Console.WriteLine("");

            Console.WriteLine("-----------------------------------------------------------------------------------------\n");


        }
    }
}
