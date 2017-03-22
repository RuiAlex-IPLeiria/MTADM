using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstros_Terra_ADM
{
    public class Raça : Objeto
    {
        //Variáveis
        private int mana;           //Valor inteiro, nunca negativo
        private int estamina;       //Valor inteiro, nunca negativo
        private int força;          //Valor inteiro, mínimo 10
        private int inteligência;   //Valor inteiro, mínimo 25
        private int destreza;       //Valor inteiro, mínimo 10

        //Propriedades {get;set;}
        public int Mana
        {
            get { return mana; }
            set
            {
                if (value < 0)
                {
                    // Valor definido para 0 se o valor inserido for negativo
                    Console.WriteLine("Erro: Mana - Valor negativo, " + value);
                    mana = 0;
                }
                else
                {
                    mana = value;
                }
            }
        }

        public int Estamina
        {
            get { return estamina; }
            set
            {
                if (value < 0)
                {
                    // Valor definido para 0 se o valor inserido for negativo
                    Console.WriteLine("Erro: Estamina - Valor negativo, " + value);
                    estamina = 0;
                }
                else
                {
                    estamina = value;
                }
            }
        }
        
        public int Força
        {
            get { return força; }
            set
            {
                if (value < 10)
                {
                    // Valor definido para 10 se o valor inserido for menor do que 10
                    Console.WriteLine("Erro: Força - Valor inferior a 10, " + value);
                    força = 10;
                }
                else
                {
                    força = value;
                }
            }
        }

        public int Inteligência
        {
            get { return inteligência; }
            set
            {
                if (value < 25)
                {
                    // Valor definido para 10 se o valor inserido for menor do que 25
                    Console.WriteLine("Erro: Inteligência - Valor inferior a 25, " + value);
                    inteligência = 25;
                }
                else
                {
                    inteligência = value;
                }
            }
        }

        public int Destreza
        {
            get { return destreza; }
            set
            {
                if (value < 10)
                {
                    // Valor definido para 10 se o valor inserido for negativo
                    Console.WriteLine("Erro: Destreza - Valor inferior a 10, " + value);
                    destreza = 10;
                }
                else
                {
                    destreza = value;
                }
            }
        }
        //Construtores
        public Raça(string nome, string descrição, int mana, int estamina, int força,
            int inteligência, int destreza) : base(nome, descrição)
        {
            Mana = mana;
            Estamina = estamina;
            Força = força;
            Inteligência = inteligência;
            Destreza = destreza;
        }
        //Metodos
        public override string ToString()
        {
            return Nome;
        }
    }
}
