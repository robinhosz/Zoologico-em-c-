using System;
using System.Collections.Generic;


namespace zoologico
{

    class program
    {

        static void Main(string[] args)
        {
            List<AnimalPlus> animais = new List<AnimalPlus>();
            int countCarnivoro=0, countHerbivoro=0;
            Console.WriteLine("Programa que conta quantos animais são carnivoros e herbivoros");
            for (int i = 0; i < 4; i++)
            {
                AnimalPlus animal = new AnimalPlus();
                Console.Write("Especie: ");
                animal.Especie = Console.ReadLine();
                Console.Write("Peso: ");
                animal.Peso = Convert.ToDouble(Console.ReadLine());
                Console.Write("Tipo de Alimentação: ");
                animal.TipoAlimentacao = Console.ReadLine();
                if (animal.TipoAlimentacao=="Carnivoro")
                {
                    countCarnivoro++;
                }
                else
                {
                    countHerbivoro++;
                }

                animais.Add(animal);


            }
            Console.WriteLine("Total de animais carnivoros: " + countCarnivoro);
            Console.WriteLine("Total de animais herbivoros:" + countHerbivoro);
            Console.ReadKey();
        }

    }

}


