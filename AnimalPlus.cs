using System;
using System.Collections.Generic;

namespace zoologico
{
    public class AnimalPlus:Animal
    {
        
        public AnimalPlus(): base()
        {
            this.TipoAlimentacao = "";
        }

        public AnimalPlus(String especie, Double peso, String TipoAlimentacao): base(especie,peso)
        {
            this.TipoAlimentacao = TipoAlimentacao;
        }

        public string TipoAlimentacao { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine("Especie: " +this.Especie);
            Console.WriteLine("Peso: " + this.Peso);
            Console.WriteLine("Tipo alimentação: " + this.TipoAlimentacao);

        }

    }
}