using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstros_Terra_ADM
{
    public class Arma : Objeto
    {
        //Variáveis
        private int ataque; //Valor inteiro, nunca negativo
        private int defesa; //Valor inteiro, nunca negativo

        //Propriedades {get;set;}
        public int Ataque
        {
            get { return ataque; }
            set
            {
                if (value < 0)
                {
                    // Valor definido para 0 se o valor inserido for negativo
                    Console.WriteLine("Erro: Ataque - Valor negativo, " + value);
                    ataque = 0;
                }
                else
                {
                    ataque = value;
                }
            }
        }

        public int Defesa
        {
            get { return defesa; }
            set
            {
                if (value < 0)
                {
                    // Valor definido para 0 se o valor inserido for negativo
                    Console.WriteLine("Erro: Defesa - Valor negativo, " + value);
                    defesa = 0;
                }
                else
                {
                    defesa = value;
                }
            }
        }
        //Construtores
        public Arma(string nome, string descricao, int ataque, int defesa) : base(nome, descricao)
        {
            Ataque = ataque;
            Defesa = defesa;
        }
        public Arma() : base(" ", " ")
        {
        }
        //Metodos
        public override String ToString() { return Nome; }
    }
}
